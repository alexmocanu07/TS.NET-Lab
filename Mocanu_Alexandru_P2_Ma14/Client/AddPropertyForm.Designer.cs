namespace MyPhotosGUI
{
    partial class AddPropertyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.existingPropLabel = new System.Windows.Forms.Label();
            this.newPropertyLabel = new System.Windows.Forms.Label();
            this.newPropNameLabel = new System.Windows.Forms.Label();
            this.newPropDescriptionLabel = new System.Windows.Forms.Label();
            this.newPropNameTextBox = new System.Windows.Forms.TextBox();
            this.newPropDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.newPropDataTypeLabel = new System.Windows.Forms.Label();
            this.newPropDataTypeComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.newPropValueLabel = new System.Windows.Forms.Label();
            this.newPropValTextBox = new System.Windows.Forms.TextBox();
            this.propName = new System.Windows.Forms.Label();
            this.propertyNameComboBox = new System.Windows.Forms.ComboBox();
            this.propValueLabel = new System.Windows.Forms.Label();
            this.existingPropValTextBox = new System.Windows.Forms.TextBox();
            this.existingPropCancelButton = new System.Windows.Forms.Button();
            this.existingPropOkButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.existingPropOkButton);
            this.panel1.Controls.Add(this.existingPropCancelButton);
            this.panel1.Controls.Add(this.existingPropValTextBox);
            this.panel1.Controls.Add(this.propValueLabel);
            this.panel1.Controls.Add(this.propertyNameComboBox);
            this.panel1.Controls.Add(this.propName);
            this.panel1.Controls.Add(this.existingPropLabel);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 151);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.newPropValTextBox);
            this.panel2.Controls.Add(this.newPropValueLabel);
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.okButton);
            this.panel2.Controls.Add(this.newPropDataTypeComboBox);
            this.panel2.Controls.Add(this.newPropDataTypeLabel);
            this.panel2.Controls.Add(this.newPropDescriptionTextBox);
            this.panel2.Controls.Add(this.newPropNameTextBox);
            this.panel2.Controls.Add(this.newPropDescriptionLabel);
            this.panel2.Controls.Add(this.newPropNameLabel);
            this.panel2.Controls.Add(this.newPropertyLabel);
            this.panel2.Location = new System.Drawing.Point(13, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 199);
            this.panel2.TabIndex = 1;
            // 
            // existingPropLabel
            // 
            this.existingPropLabel.AutoSize = true;
            this.existingPropLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingPropLabel.Location = new System.Drawing.Point(-1, -4);
            this.existingPropLabel.Name = "existingPropLabel";
            this.existingPropLabel.Size = new System.Drawing.Size(167, 20);
            this.existingPropLabel.TabIndex = 0;
            this.existingPropLabel.Text = "Use existing property";
            // 
            // newPropertyLabel
            // 
            this.newPropertyLabel.AutoSize = true;
            this.newPropertyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPropertyLabel.Location = new System.Drawing.Point(0, -1);
            this.newPropertyLabel.Name = "newPropertyLabel";
            this.newPropertyLabel.Size = new System.Drawing.Size(139, 20);
            this.newPropertyLabel.TabIndex = 0;
            this.newPropertyLabel.Text = "Create a property";
            // 
            // newPropNameLabel
            // 
            this.newPropNameLabel.AutoSize = true;
            this.newPropNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPropNameLabel.Location = new System.Drawing.Point(3, 39);
            this.newPropNameLabel.Name = "newPropNameLabel";
            this.newPropNameLabel.Size = new System.Drawing.Size(48, 18);
            this.newPropNameLabel.TabIndex = 1;
            this.newPropNameLabel.Text = "Name";
            // 
            // newPropDescriptionLabel
            // 
            this.newPropDescriptionLabel.AutoSize = true;
            this.newPropDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPropDescriptionLabel.Location = new System.Drawing.Point(1, 72);
            this.newPropDescriptionLabel.Name = "newPropDescriptionLabel";
            this.newPropDescriptionLabel.Size = new System.Drawing.Size(83, 18);
            this.newPropDescriptionLabel.TabIndex = 2;
            this.newPropDescriptionLabel.Text = "Description";
            // 
            // newPropNameTextBox
            // 
            this.newPropNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPropNameTextBox.Location = new System.Drawing.Point(84, 36);
            this.newPropNameTextBox.Name = "newPropNameTextBox";
            this.newPropNameTextBox.Size = new System.Drawing.Size(372, 24);
            this.newPropNameTextBox.TabIndex = 3;
            // 
            // newPropDescriptionTextBox
            // 
            this.newPropDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPropDescriptionTextBox.Location = new System.Drawing.Point(84, 66);
            this.newPropDescriptionTextBox.Name = "newPropDescriptionTextBox";
            this.newPropDescriptionTextBox.Size = new System.Drawing.Size(372, 24);
            this.newPropDescriptionTextBox.TabIndex = 4;
            // 
            // newPropDataTypeLabel
            // 
            this.newPropDataTypeLabel.AutoSize = true;
            this.newPropDataTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPropDataTypeLabel.Location = new System.Drawing.Point(3, 115);
            this.newPropDataTypeLabel.Name = "newPropDataTypeLabel";
            this.newPropDataTypeLabel.Size = new System.Drawing.Size(75, 18);
            this.newPropDataTypeLabel.TabIndex = 5;
            this.newPropDataTypeLabel.Text = "Data Type";
            this.newPropDataTypeLabel.Click += new System.EventHandler(this.newPropDataTypeLabel_Click);
            // 
            // newPropDataTypeComboBox
            // 
            this.newPropDataTypeComboBox.AllowDrop = true;
            this.newPropDataTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPropDataTypeComboBox.FormattingEnabled = true;
            this.newPropDataTypeComboBox.Items.AddRange(new object[] {
            "Text",
            "Date",
            "Integer",
            "Decimal"});
            this.newPropDataTypeComboBox.Location = new System.Drawing.Point(84, 115);
            this.newPropDataTypeComboBox.Name = "newPropDataTypeComboBox";
            this.newPropDataTypeComboBox.Size = new System.Drawing.Size(158, 26);
            this.newPropDataTypeComboBox.TabIndex = 6;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(422, 154);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(107, 42);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(6, 154);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 42);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // newPropValueLabel
            // 
            this.newPropValueLabel.AutoSize = true;
            this.newPropValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPropValueLabel.Location = new System.Drawing.Point(274, 118);
            this.newPropValueLabel.Name = "newPropValueLabel";
            this.newPropValueLabel.Size = new System.Drawing.Size(44, 18);
            this.newPropValueLabel.TabIndex = 9;
            this.newPropValueLabel.Text = "Value";
            // 
            // newPropValTextBox
            // 
            this.newPropValTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPropValTextBox.Location = new System.Drawing.Point(324, 115);
            this.newPropValTextBox.Name = "newPropValTextBox";
            this.newPropValTextBox.Size = new System.Drawing.Size(205, 24);
            this.newPropValTextBox.TabIndex = 10;
            // 
            // propName
            // 
            this.propName.AutoSize = true;
            this.propName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propName.Location = new System.Drawing.Point(3, 27);
            this.propName.Name = "propName";
            this.propName.Size = new System.Drawing.Size(48, 18);
            this.propName.TabIndex = 1;
            this.propName.Text = "Name";
            // 
            // propertyNameComboBox
            // 
            this.propertyNameComboBox.AllowDrop = true;
            this.propertyNameComboBox.FormattingEnabled = true;
            this.propertyNameComboBox.Location = new System.Drawing.Point(72, 26);
            this.propertyNameComboBox.Name = "propertyNameComboBox";
            this.propertyNameComboBox.Size = new System.Drawing.Size(170, 24);
            this.propertyNameComboBox.TabIndex = 2;
            // 
            // propValueLabel
            // 
            this.propValueLabel.AutoSize = true;
            this.propValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propValueLabel.Location = new System.Drawing.Point(3, 68);
            this.propValueLabel.Name = "propValueLabel";
            this.propValueLabel.Size = new System.Drawing.Size(44, 18);
            this.propValueLabel.TabIndex = 3;
            this.propValueLabel.Text = "Value";
            // 
            // existingPropValTextBox
            // 
            this.existingPropValTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingPropValTextBox.Location = new System.Drawing.Point(63, 65);
            this.existingPropValTextBox.Name = "existingPropValTextBox";
            this.existingPropValTextBox.Size = new System.Drawing.Size(255, 24);
            this.existingPropValTextBox.TabIndex = 4;
            // 
            // existingPropCancelButton
            // 
            this.existingPropCancelButton.Location = new System.Drawing.Point(6, 95);
            this.existingPropCancelButton.Name = "existingPropCancelButton";
            this.existingPropCancelButton.Size = new System.Drawing.Size(107, 42);
            this.existingPropCancelButton.TabIndex = 9;
            this.existingPropCancelButton.Text = "Cancel";
            this.existingPropCancelButton.UseVisualStyleBackColor = true;
            this.existingPropCancelButton.Click += new System.EventHandler(this.existingPropCancelButton_Click);
            // 
            // existingPropOkButton
            // 
            this.existingPropOkButton.Location = new System.Drawing.Point(422, 95);
            this.existingPropOkButton.Name = "existingPropOkButton";
            this.existingPropOkButton.Size = new System.Drawing.Size(107, 42);
            this.existingPropOkButton.TabIndex = 10;
            this.existingPropOkButton.Text = "OK";
            this.existingPropOkButton.UseVisualStyleBackColor = true;
            this.existingPropOkButton.Click += new System.EventHandler(this.existingPropOkButton_Click);
            // 
            // AddPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 376);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddPropertyForm";
            this.Text = "AddPropertyForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label existingPropLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label newPropDataTypeLabel;
        private System.Windows.Forms.TextBox newPropDescriptionTextBox;
        private System.Windows.Forms.TextBox newPropNameTextBox;
        private System.Windows.Forms.Label newPropDescriptionLabel;
        private System.Windows.Forms.Label newPropNameLabel;
        private System.Windows.Forms.Label newPropertyLabel;
        private System.Windows.Forms.ComboBox newPropDataTypeComboBox;
        private System.Windows.Forms.Button existingPropOkButton;
        private System.Windows.Forms.Button existingPropCancelButton;
        private System.Windows.Forms.TextBox existingPropValTextBox;
        private System.Windows.Forms.Label propValueLabel;
        private System.Windows.Forms.ComboBox propertyNameComboBox;
        private System.Windows.Forms.Label propName;
        private System.Windows.Forms.TextBox newPropValTextBox;
        private System.Windows.Forms.Label newPropValueLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}