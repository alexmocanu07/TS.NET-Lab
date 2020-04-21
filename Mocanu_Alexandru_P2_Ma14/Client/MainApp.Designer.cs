namespace MyPhotosGUI
{
    partial class MainApp
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileListView = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pathHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.propertyListView = new System.Windows.Forms.ListView();
            this.propertyNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.propertyDescriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.propertyValueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileToolStripMenuItem,
            this.editFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(97, 726);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.addFileToolStripMenuItem.Text = "Add File";
            this.addFileToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
            // 
            // editFileToolStripMenuItem
            // 
            this.editFileToolStripMenuItem.Name = "editFileToolStripMenuItem";
            this.editFileToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.editFileToolStripMenuItem.Text = "Edit File";
            this.editFileToolStripMenuItem.Click += new System.EventHandler(this.editFileToolStripMenuItem_Click);
            // 
            // fileListView
            // 
            this.fileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.pathHeader});
            this.fileListView.HideSelection = false;
            this.fileListView.Location = new System.Drawing.Point(127, 0);
            this.fileListView.Name = "fileListView";
            this.fileListView.Size = new System.Drawing.Size(301, 721);
            this.fileListView.TabIndex = 1;
            this.fileListView.UseCompatibleStateImageBehavior = false;
            this.fileListView.View = System.Windows.Forms.View.Details;
            this.fileListView.Click += new System.EventHandler(this.fileListView_Click);
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 146;
            // 
            // pathHeader
            // 
            this.pathHeader.Text = "Path";
            this.pathHeader.Width = 159;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(434, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(763, 438);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // propertyListView
            // 
            this.propertyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.propertyNameHeader,
            this.propertyDescriptionHeader,
            this.propertyValueHeader});
            this.propertyListView.HideSelection = false;
            this.propertyListView.Location = new System.Drawing.Point(434, 444);
            this.propertyListView.Name = "propertyListView";
            this.propertyListView.Size = new System.Drawing.Size(763, 277);
            this.propertyListView.TabIndex = 3;
            this.propertyListView.UseCompatibleStateImageBehavior = false;
            this.propertyListView.View = System.Windows.Forms.View.Details;
            // 
            // propertyNameHeader
            // 
            this.propertyNameHeader.Text = "Name";
            this.propertyNameHeader.Width = 200;
            // 
            // propertyDescriptionHeader
            // 
            this.propertyDescriptionHeader.Text = "Description";
            this.propertyDescriptionHeader.Width = 300;
            // 
            // propertyValueHeader
            // 
            this.propertyValueHeader.Text = "Value";
            this.propertyValueHeader.Width = 200;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 726);
            this.Controls.Add(this.propertyListView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fileListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainApp";
            this.Text = "MyPhotos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFileToolStripMenuItem;
        private System.Windows.Forms.ListView fileListView;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader pathHeader;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView propertyListView;
        private System.Windows.Forms.ColumnHeader propertyNameHeader;
        private System.Windows.Forms.ColumnHeader propertyDescriptionHeader;
        private System.Windows.Forms.ColumnHeader propertyValueHeader;
    }
}

