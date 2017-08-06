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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VarListBox = new System.Windows.Forms.ListBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.VarTextBox = new System.Windows.Forms.TextBox();
            this.InsertVarButton = new System.Windows.Forms.Button();
            this.SetNameButton = new System.Windows.Forms.Button();
            this.CreateMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(344, 288);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // VarListBox
            // 
            this.VarListBox.FormattingEnabled = true;
            this.VarListBox.ItemHeight = 20;
            this.VarListBox.Location = new System.Drawing.Point(280, 48);
            this.VarListBox.Name = "VarListBox";
            this.VarListBox.Size = new System.Drawing.Size(176, 224);
            this.VarListBox.TabIndex = 3;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(8, 48);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(256, 26);
            this.NameTextBox.TabIndex = 4;
            // 
            // VarTextBox
            // 
            this.VarTextBox.Location = new System.Drawing.Point(8, 120);
            this.VarTextBox.Name = "VarTextBox";
            this.VarTextBox.Size = new System.Drawing.Size(256, 26);
            this.VarTextBox.TabIndex = 5;
            // 
            // InsertVarButton
            // 
            this.InsertVarButton.Location = new System.Drawing.Point(8, 152);
            this.InsertVarButton.Name = "InsertVarButton";
            this.InsertVarButton.Size = new System.Drawing.Size(168, 32);
            this.InsertVarButton.TabIndex = 6;
            this.InsertVarButton.Text = "&Insert New Variable";
            this.InsertVarButton.UseVisualStyleBackColor = true;
            this.InsertVarButton.Click += new System.EventHandler(this.InsertVarButton_Click);
            // 
            // SetNameButton
            // 
            this.SetNameButton.Location = new System.Drawing.Point(8, 80);
            this.SetNameButton.Name = "SetNameButton";
            this.SetNameButton.Size = new System.Drawing.Size(168, 32);
            this.SetNameButton.TabIndex = 7;
            this.SetNameButton.Text = "&Set Template Name";
            this.SetNameButton.UseVisualStyleBackColor = true;
            this.SetNameButton.Click += new System.EventHandler(this.SetNameButton_Click);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 326);
            this.Controls.Add(this.SetNameButton);
            this.Controls.Add(this.InsertVarButton);
            this.Controls.Add(this.VarTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.VarListBox);
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
        private System.Windows.Forms.ListBox VarListBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox VarTextBox;
        private System.Windows.Forms.Button InsertVarButton;
        private System.Windows.Forms.Button SetNameButton;
    }
}