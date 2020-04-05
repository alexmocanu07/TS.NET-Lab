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
    public partial class MainApp : Form
    {
        //private FileController fileController;
        //private PropertyController propertyController;
        //private FilePropertyController filePropertyController;

        private AddFileForm addFileForm;
        private EditFileForm editFileForm;

        private File selectedFile;

        private DatabaseClient client;


        public MainApp()
        {
            client = new DatabaseClient();
            //fileController = new FileController();
            //propertyController = new PropertyController();
            //filePropertyController = new FilePropertyController();
            InitializeComponent();
            InitializeFiles();
        }

        private List<File> InitializeFiles()
        {
            List<File> files = client.GetAllFiles().ToList<File>();
            foreach(File f in files)
            {
                ListViewItem item = new ListViewItem(f.Name);
                item.SubItems.Add(f.Path);

                fileListView.Items.Add(item);
            }

            return files;
        }

        public void addFileToListView(File f)
        {
            ListViewItem item = new ListViewItem(f.Name);
            item.SubItems.Add(f.Path);
            fileListView.Items.Add(item);
        }

        public void changePropertyListView(File f)
        {
            List<Property> properties = client.GetFileProperties(f.Id).ToList<Property>();
            propertyListView.Items.Clear();
            foreach(Property p in properties)
            {
                ListViewItem item = new ListViewItem(p.Name);
                item.SubItems.Add(p.Description);
                FileProperty fp = client.GetFileProperty(f.Id, p.Id);
                if (fp == null) return;
                item.SubItems.Add(fp.Value);
                propertyListView.Items.Add(item);
            }
        }
        private void fileListView_Click(object sender, EventArgs e)
        {
            if(fileListView.SelectedItems.Count == 1)
            {
                ListViewItem item = fileListView.SelectedItems[0];
  
                string path = item.SubItems[1].Text;
                File f = client.GetFileByPath(path);
                if (f == null) return;
                changePropertyListView(f);
                selectedFile = f;
                Bitmap image = new Bitmap(f.Path);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = (Image)image;
  
            }
        }

        private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.addFileForm = new AddFileForm(this);
            addFileForm.Show();
        }

        private void editFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.editFileForm = new EditFileForm(this);
            editFileForm.Show();
        }

        public File getSelectedFile()
        {
            return this.selectedFile;
        }

      
    }
}
