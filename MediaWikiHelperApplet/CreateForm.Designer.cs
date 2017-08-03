namespace MediaWikiHelperApplet {
    partial class CreateForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ReturnButton = new System.Windows.Forms.Button();
            this.CreateMenuStrip = new System.Windows.Forms.MenuStrip();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(344, 264);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(108, 32);
            this.ReturnButton.TabIndex = 0;
            this.ReturnButton.Text = "&Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // CreateMenuStrip
            // 
            this.CreateMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CreateMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.CreateMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.CreateMenuStrip.Name = "CreateMenuStrip";
            this.CreateMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.CreateMenuStrip.Size = new System.Drawing.Size(465, 35);
            this.CreateMenuStrip.TabIndex = 2;
            this.CreateMenuStrip.Text = "menuStrip1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(296, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 224);
            this.listBox1.TabIndex = 3;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 309);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.CreateMenuStrip);
            this.MainMenuStrip = this.CreateMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateForm";
            this.Text = "Create New Template Layout";
            this.Load += new System.EventHandler(this.CreateForm_Load);
            this.CreateMenuStrip.ResumeLayout(false);
            this.CreateMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.MenuStrip CreateMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
    }
}