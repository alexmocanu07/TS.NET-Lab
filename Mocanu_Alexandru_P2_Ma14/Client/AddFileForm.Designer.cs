namespace MyPhotosGUI
{
    partial class AddFileForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addPropertyButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.finishButton = new System.Windows.Forms.Button();
            this.removePropertyButton = new System.Windows.Forms.Button();
            this.propertyListView = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 323);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(12, 341);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(206, 65);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(224, 341);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(201, 65);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(21, 477);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(197, 65);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addPropertyButton
            // 
            this.addPropertyButton.Location = new System.Drawing.Point(457, 341);
            this.addPropertyButton.Name = "addPropertyButton";
            this.addPropertyButton.Size = new System.Drawing.Size(221, 65);
            this.addPropertyButton.TabIndex = 5;
            this.addPropertyButton.Text = "Add New Property";
            this.addPropertyButton.UseVisualStyleBackColor = true;
            this.addPropertyButton.Click += new System.EventHandler(this.addPropertyButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(429, 501);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(126, 41);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "File name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameTextBox.Location = new System.Drawing.Point(561, 506);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(154, 30);
            this.fileNameTextBox.TabIndex = 7;
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(721, 477);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(187, 65);
            this.finishButton.TabIndex = 8;
            this.finishButton.Text = "OK";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // removePropertyButton
            // 
            this.removePropertyButton.Location = new System.Drawing.Point(684, 341);
            this.removePropertyButton.Name = "removePropertyButton";
            this.removePropertyButton.Size = new System.Drawing.Size(224, 65);
            this.removePropertyButton.TabIndex = 9;
            this.removePropertyButton.Text = "Remove Property";
            this.removePropertyButton.UseVisualStyleBackColor = true;
            this.removePropertyButton.Click += new System.EventHandler(this.removePropertyButton_Click);
            // 
            // propertyListView
            // 
            this.propertyListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.descHeader,
            this.valueHeader});
            this.propertyListView.HideSelection = false;
            this.propertyListView.Location = new System.Drawing.Point(457, 12);
            this.propertyListView.Name = "propertyListView";
            this.propertyListView.Size = new System.Drawing.Size(451, 323);
            this.propertyListView.TabIndex = 10;
            this.propertyListView.UseCompatibleStateImageBehavior = false;
            this.propertyListView.View = System.Windows.Forms.View.Details;
            this.propertyListView.SelectedIndexChanged += new System.EventHandler(this.propertyListView_SelectedIndexChanged);
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 100;
            // 
            // descHeader
            // 
            this.descHeader.Text = "Description";
            this.descHeader.Width = 150;
            // 
            // valueHeader
            // 
            this.valueHeader.Text = "Value";
            this.valueHeader.Width = 100;
            // 
            // AddFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 554);
            this.Controls.Add(this.propertyListView);
            this.Controls.Add(this.removePropertyButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addPropertyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddFileForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AddFileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addPropertyButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button removePropertyButton;
        private System.Windows.Forms.ListView propertyListView;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader descHeader;
        private System.Windows.Forms.ColumnHeader valueHeader;
    }
}