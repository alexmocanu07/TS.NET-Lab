
using System;
using System.Drawing;
using System.Windows.Forms;
using Database;

namespace MyPhotosGUI
{
    public partial class AddFileForm : Form
    {
        private DatabaseClient client;
        private Bitmap image;
        private string filePath;
        private string fileName;
        //private FileController fileController;
        //private PropertyController propertyController;
        //private FilePropertyController filePropertyController;
        private MainApp mainApp;
        
        public AddFileForm(MainApp mainApp)
        {
            this.client = new DatabaseClient();
            this.mainApp = mainApp;
            image = null;
            filePath = null;
            fileName = null;
            //fileController = new FileController();
            //propertyController = new PropertyController();
            //filePropertyController = new FilePropertyController();

            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                String path = fileDialog.FileName;
     
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                image = new Bitmap(path);
                filePath = path;
                pictureBox1.Image = (Image)image;
            }
        }

        public void AddProperty(Property p, string propertyValue)
        {
            ListViewItem item = new ListViewItem(p.Name);
           
            item.SubItems.Add(p.Description);
            item.SubItems.Add(propertyValue);
            propertyListView.Items.Add(item);
        }

        private void AddFileForm_Load(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            filePath = null;
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            fileName = fileNameTextBox.Text;
            if(image == null || fileName == null || filePath == null)
            {
                MessageBox.Show("You must provide a name and a path for the image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(client.GetFileByPath(filePath) != null)
            {
                MessageBox.Show("File already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (client.GetFileByName(fileName) != null)
            {
                MessageBox.Show("File name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                File f = client.CreateFile(filePath, fileName);
                if (f == null)
                {
                    MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else {
                    foreach (ListViewItem item in propertyListView.Items)
                    {
                        Property p = client.GetPropertyByName(item.Text);
                        FileProperty fp = client.AddPropertyToFile(f.Id, p.Id, item.SubItems[2].Text);
                        if(fp == null)
                        {
                            MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    this.mainApp.addFileToListView(f);
                    this.Close();
                }
            }
            

        }

        private void addPropertyButton_Click(object sender, EventArgs e)
        {
            AddPropertyForm addPropertyForm = new AddPropertyForm(this);
            addPropertyForm.Show();
        }

        private void removePropertyButton_Click(object sender, EventArgs e)
        {
            if(propertyListView.SelectedItems.Count < 1)
            {
                MessageBox.Show("You must select a property.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(propertyListView.SelectedItems.Count > 1)
            {
                MessageBox.Show("You must select only one property.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for(int i = 0; i < propertyListView.Items.Count; i++)
                {
                    if (propertyListView.Items[i].Selected)
                    {
                        propertyListView.Items[i].Remove();
                        break;
                    }
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void propertyListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
