namespace MediaWikiHelperApplet {
    partial class StartForm {
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.CreateLayoutButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.StartMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abouitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(176, 88);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(160, 48);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "E&xit Application";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CreateLayoutButton
            // 
            this.CreateLayoutButton.Location = new System.Drawing.Point(8, 32);
            this.CreateLayoutButton.Name = "CreateLayoutButton";
            this.CreateLayoutButton.Size = new System.Drawing.Size(160, 48);
            this.CreateLayoutButton.TabIndex = 1;
            this.CreateLayoutButton.Text = "&Create Template Layout";
            this.CreateLayoutButton.UseVisualStyleBackColor = true;
            this.CreateLayoutButton.Click += new System.EventHandler(this.CreateLayoutButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(176, 32);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(160, 48);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "&Generate Markup Code";
            this.GenerateButton.UseVisualStyleBackColor = true;
            // 
            // StartMenuStrip
            // 
            this.StartMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.StartMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.StartMenuStrip.Name = "StartMenuStrip";
            this.StartMenuStrip.Size = new System.Drawing.Size(345, 24);
            this.StartMenuStrip.TabIndex = 3;
            this.StartMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createLayoutToolStripMenuItem,
            this.generateCodeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createLayoutToolStripMenuItem
            // 
            this.createLayoutToolStripMenuItem.Name = "createLayoutToolStripMenuItem";
            this.createLayoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createLayoutToolStripMenuItem.Text = "Create Layout";
            this.createLayoutToolStripMenuItem.Click += new System.EventHandler(this.createLayoutToolStripMenuItem_Click);
            // 
            // generateCodeToolStripMenuItem
            // 
            this.generateCodeToolStripMenuItem.Name = "generateCodeToolStripMenuItem";
            this.generateCodeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.generateCodeToolStripMenuItem.Text = "Generate Code";
            this.generateCodeToolStripMenuItem.Click += new System.EventHandler(this.generateCodeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abouitToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // abouitToolStripMenuItem
            // 
            this.abouitToolStripMenuItem.Name = "abouitToolStripMenuItem";
            this.abouitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abouitToolStripMenuItem.Text = "About";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 146);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.CreateLayoutButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartMenuStrip);
            this.MainMenuStrip = this.StartMenuStrip;
            this.Name = "StartForm";
            this.Text = "MediaWiki Helper Applet";
            this.StartMenuStrip.ResumeLayout(false);
            this.StartMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CreateLayoutButton;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.MenuStrip StartMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abouitToolStripMenuItem;
    }
}

