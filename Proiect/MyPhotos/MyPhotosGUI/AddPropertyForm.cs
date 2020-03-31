using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyPhotosGUI
{
    public partial class AddPropertyForm : Form
    {
        //private FileController fileController;
        //private PropertyController propertyController;
        //private FilePropertyController filePropertyController;
        private File file;
        private Property property;
        private string propertyValue;
        private AddFileForm addFileForm;
        private EditFileForm editFileForm;
        public AddPropertyForm(AddFileForm addFileForm)
        {
            this.addFileForm = addFileForm;
            InitializeComponent();
            //fileController = new FileController();
            //propertyController = new PropertyController();
            //filePropertyController = new FilePropertyController();

            List<Property> properties = Program.client.GetAllProperties().ToList<Property>();
            foreach(Property p in properties)
            {
                propertyNameComboBox.Items.Add(p.Name);
            }
            
        }

        public AddPropertyForm(EditFileForm editFileForm)
        {
            this.editFileForm = editFileForm;
            InitializeComponent();
            //fileController = new FileController();
            //propertyController = new PropertyController();
            //filePropertyController = new FilePropertyController();

            List<Property> properties = Program.client.GetAllProperties().ToList<Property>();
            foreach (Property p in properties)
            {
                propertyNameComboBox.Items.Add(p.Name);
            }
        }

        public void SetFile(File f)
        {
            this.file = f;
        }

        public string getPropertyValue()
        {
            return this.propertyValue;
        }

        private void newPropDataTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void existingPropCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void existingPropOkButton_Click(object sender, EventArgs e)
        {
            string val = existingPropValTextBox.Text;
            
            string selectedProp = propertyNameComboBox.SelectedItem.ToString();
            this.property = Program.client.GetPropertyByName(selectedProp);
            if(this.property == null)
            {
                MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (val == null || selectedProp == null)
            {
                MessageBox.Show("You must provide a property and a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string dataType = property.DataType;
            
            if(!Program.client.IsValueValid(val, dataType))
            {
                String message = "The value does not respect the property data type format. You should insert a ";
                message += dataType == "string" ? "text" : dataType == "DateTime" ? "date" : dataType;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.propertyValue = val;
                if (this.addFileForm != null) this.addFileForm.AddProperty(this.property, val);
                else if (this.editFileForm != null) this.editFileForm.AddProperty(this.property, val);
                this.Close();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string name = newPropNameTextBox.Text;
            string val = newPropValTextBox.Text;
            string description = newPropDescriptionTextBox.Text;
            string dataType = newPropDataTypeComboBox.SelectedItem.ToString();

            if(name == null || val == null || description == null || dataType == null)
            {
                MessageBox.Show("You must provide a name, a description, a data type and a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string myDataType = null;
            if (dataType == "Text") myDataType = "string";
            if (dataType == "Date") myDataType = "date";
            if (dataType == "Integer") myDataType = "integer";
            if (dataType == "Decimal") myDataType = "decimal";
            if(!Program.client.IsValueValid(val, myDataType))
            {
                MessageBox.Show("The value does not respect the property data type format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Property p = Program.client.CreateProperty(name, description, myDataType);
                if(p == null)
                {
                    MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.propertyValue = val;
                this.property = p;
                if (this.addFileForm != null) addFileForm.AddProperty(p, val);
                else if (this.editFileForm != null) editFileForm.AddProperty(p, val);
                this.Close();
            }
        }
    }
}
