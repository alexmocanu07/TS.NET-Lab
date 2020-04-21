using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace MyPhotosGUI
{
    public partial class EditFileForm : Form
    {
        private DatabaseClient client;

        private MainApp mainApp;
        private Bitmap image;
        private File selectedFile;

        //private FilePropertyController filePropertyController;
        //private FileController fileController;
        //private PropertyController propertyController;
        

        public EditFileForm(MainApp mainApp)
        {
            this.client = new DatabaseClient();
            this.mainApp = mainApp;
            this.selectedFile = mainApp.getSelectedFile();

            //fileController = new FileController();
            //propertyController = new PropertyController();
            //filePropertyController = new FilePropertyController();

            InitializeComponent();
            this.pathText.Text = selectedFile.Path;
            this.nameText.Text = selectedFile.Name;

            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.Image = (Image)new Bitmap(selectedFile.Path);

            UpdatePropertyListView();
            
        }

        private void UpdatePropertyListView()
        {
            List<Property> properties = client.GetFileProperties(selectedFile.Id).ToList<Property>();
            foreach (Property p in properties)
            {
                ListViewItem item = new ListViewItem(p.Name);
                item.SubItems.Add(p.Description);
                FileProperty fp = client.GetFileProperty(selectedFile.Id, p.Id);
                if (fp == null) return;
                item.SubItems.Add(fp.Value);
                propertyListView.Items.Add(item);
            }
        }

        private void addPropertyButton_Click(object sender, EventArgs e)
        {
            
            AddPropertyForm addPropertyForm = new AddPropertyForm(this);
            addPropertyForm.Show();
            
        }

        public void AddProperty(Property p, string propertyValue)
        {
            ListViewItem item = new ListViewItem(p.Name);

            item.SubItems.Add(p.Description);
            item.SubItems.Add(propertyValue);
            propertyListView.Items.Add(item);
            client.AddPropertyToFile(selectedFile.Id, p.Id, propertyValue);
        }

        private void editPropertyButton_Click(object sender, EventArgs e)
        {
            if (propertyListView.SelectedItems.Count < 1)
            {
                MessageBox.Show("You must select a property.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (propertyListView.SelectedItems.Count > 1)
            {
                MessageBox.Show("You must select only one property.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string newval = newValTextBox.Text;
                if (newval == null)
                {
                    MessageBox.Show("You must provide a new value if you want to edit the property.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int index = -1;
                    string propertyName = null;
                    for (int i = 0; i < propertyListView.Items.Count; i++)
                    {
                        if (propertyListView.Items[i].Selected)
                        {
                            index = i;
                            propertyName = propertyListView.Items[i].SubItems[0].Text;
                            break;
                        }
                    }
                    Property p = client.GetPropertyByName(propertyName);
                    if (!client.IsValueValid(newval, p.DataType))
                    {
                        MessageBox.Show("The value does not respect the property data type format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        propertyListView.Items[index].SubItems[2].Text = newval;

                        client.UpdateValue(selectedFile.Id, p.Id, newval);
                    }
                }
            }
        }

        private void removePropertyButton_Click(object sender, EventArgs e)
        {
            if (propertyListView.SelectedItems.Count < 1)
            {
                MessageBox.Show("You must select a property.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (propertyListView.SelectedItems.Count > 1)
            {
                MessageBox.Show("You must select only one property.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < propertyListView.Items.Count; i++)
                {
                    if (propertyListView.Items[i].Selected)
                    {
                        propertyListView.Items[i].Remove();
                        string propertyName = propertyListView.Items[i].SubItems[0].Text;
                        Property p = client.GetPropertyByName(propertyName);
                        client.RemoveProperty(selectedFile.Id, p.Id);
                        break;
                    }
                }
            }
        }

        private void SaveChanges()
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainApp.changePropertyListView(selectedFile);
        }
    }
}
