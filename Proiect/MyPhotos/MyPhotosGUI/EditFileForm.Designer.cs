namespace MyPhotosGUI
{
    partial class EditFileForm
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
            this.propertyListView = new System.Windows.Forms.ListView();
            this.propertyNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.propertyDescriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.propertyValueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addPropertyButton = new System.Windows.Forms.Button();
            this.editPropertyButton = new System.Windows.Forms.Button();
            this.removePropertyButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pathText = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.Label();
            this.newValLabel = new System.Windows.Forms.Label();
            this.newValTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyListView
            // 
            this.propertyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.propertyNameHeader,
            this.propertyDescriptionHeader,
            this.propertyValueHeader});
            this.propertyListView.HideSelection = false;
            this.propertyListView.Location = new System.Drawing.Point(454, 12);
            this.propertyListView.Name = "propertyListView";
            this.propertyListView.Size = new System.Drawing.Size(461, 256);
            this.propertyListView.TabIndex = 0;
            this.propertyListView.UseCompatibleStateImageBehavior = false;
            this.propertyListView.View = System.Windows.Forms.View.Details;
            // 
            // propertyNameHeader
            // 
            this.propertyNameHeader.Text = "Name";
            this.propertyNameHeader.Width = 108;
            // 
            // propertyDescriptionHeader
            // 
            this.propertyDescriptionHeader.Text = "Description";
            this.propertyDescriptionHeader.Width = 198;
            // 
            // propertyValueHeader
            // 
            this.propertyValueHeader.Text = "Value";
            this.propertyValueHeader.Width = 150;
            // 
            // addPropertyButton
            // 
            this.addPropertyButton.Location = new System.Drawing.Point(454, 274);
            this.addPropertyButton.Name = "addPropertyButton";
            this.addPropertyButton.Size = new System.Drawing.Size(148, 54);
            this.addPropertyButton.TabIndex = 1;
            this.addPropertyButton.Text = "Add property";
            this.addPropertyButton.UseVisualStyleBackColor = true;
            this.addPropertyButton.Click += new System.EventHandler(this.addPropertyButton_Click);
            // 
            // editPropertyButton
            // 
            this.editPropertyButton.Location = new System.Drawing.Point(608, 274);
            this.editPropertyButton.Name = "editPropertyButton";
            this.editPropertyButton.Size = new System.Drawing.Size(151, 54);
            this.editPropertyButton.TabIndex = 2;
            this.editPropertyButton.Text = "Edit Property";
            this.editPropertyButton.UseVisualStyleBackColor = true;
            this.editPropertyButton.Click += new System.EventHandler(this.editPropertyButton_Click);
            // 
            // removePropertyButton
            // 
            this.removePropertyButton.Location = new System.Drawing.Point(765, 274);
            this.removePropertyButton.Name = "removePropertyButton";
            this.removePropertyButton.Size = new System.Drawing.Size(150, 54);
            this.removePropertyButton.TabIndex = 3;
            this.removePropertyButton.Text = "Remove Property";
            this.removePropertyButton.UseVisualStyleBackColor = true;
            this.removePropertyButton.Click += new System.EventHandler(this.removePropertyButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 315);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.Location = new System.Drawing.Point(12, 353);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(53, 20);
            this.pathLabel.TabIndex = 5;
            this.pathLabel.Text = "Path: ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 418);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 20);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name:";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(765, 471);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(150, 54);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pathText
            // 
            this.pathText.AutoSize = true;
            this.pathText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathText.Location = new System.Drawing.Point(80, 356);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(0, 20);
            this.pathText.TabIndex = 10;
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(91, 418);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(0, 20);
            this.nameText.TabIndex = 11;
            // 
            // newValLabel
            // 
            this.newValLabel.AutoSize = true;
            this.newValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newValLabel.Location = new System.Drawing.Point(13, 481);
            this.newValLabel.Name = "newValLabel";
            this.newValLabel.Size = new System.Drawing.Size(91, 20);
            this.newValLabel.TabIndex = 12;
            this.newValLabel.Text = "New value:";
            // 
            // newValTextBox
            // 
            this.newValTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newValTextBox.Location = new System.Drawing.Point(110, 478);
            this.newValTextBox.Name = "newValTextBox";
            this.newValTextBox.Size = new System.Drawing.Size(338, 27);
            this.newValTextBox.TabIndex = 13;
            // 
            // EditFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 537);
            this.Controls.Add(this.newValTextBox);
            this.Controls.Add(this.newValLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.removePropertyButton);
            this.Controls.Add(this.editPropertyButton);
            this.Controls.Add(this.addPropertyButton);
            this.Controls.Add(this.propertyListView);
            this.Name = "EditFileForm";
            this.Text = "EditFileProperties";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView propertyListView;
        private System.Windows.Forms.ColumnHeader propertyNameHeader;
        private System.Windows.Forms.ColumnHeader propertyDescriptionHeader;
        private System.Windows.Forms.ColumnHeader propertyValueHeader;
        private System.Windows.Forms.Button addPropertyButton;
        private System.Windows.Forms.Button editPropertyButton;
        private System.Windows.Forms.Button removePropertyButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label pathText;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Label newValLabel;
        private System.Windows.Forms.TextBox newValTextBox;
    }
}