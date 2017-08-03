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
            this.ExitButton.Location = new System.Drawing.Point(264, 135);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(240, 74);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "E&xit Application";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CreateLayoutButton
            // 
            this.CreateLayoutButton.Location = new System.Drawing.Point(12, 49);
            this.CreateLayoutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateLayoutButton.Name = "CreateLayoutButton";
            this.CreateLayoutButton.Size = new System.Drawing.Size(240, 74);
            this.CreateLayoutButton.TabIndex = 1;
            this.CreateLayoutButton.Text = "&Create Template Layout";
            this.CreateLayoutButton.UseVisualStyleBackColor = true;
            this.CreateLayoutButton.Click += new System.EventHandler(this.CreateLayoutButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(264, 49);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(240, 74);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "&Generate Markup Code";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // StartMenuStrip
            // 
            this.StartMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StartMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.StartMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.StartMenuStrip.Name = "StartMenuStrip";
            this.StartMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.StartMenuStrip.Size = new System.Drawing.Size(518, 35);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createLayoutToolStripMenuItem
            // 
            this.createLayoutToolStripMenuItem.Name = "createLayoutToolStripMenuItem";
            this.createLayoutToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.createLayoutToolStripMenuItem.Text = "Create Layout";
            this.createLayoutToolStripMenuItem.Click += new System.EventHandler(this.CreateLayoutToolStripMenuItem_Click);
            // 
            // generateCodeToolStripMenuItem
            // 
            this.generateCodeToolStripMenuItem.Name = "generateCodeToolStripMenuItem";
            this.generateCodeToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.generateCodeToolStripMenuItem.Text = "Generate Code";
            this.generateCodeToolStripMenuItem.Click += new System.EventHandler(this.GenerateCodeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abouitToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // abouitToolStripMenuItem
            // 
            this.abouitToolStripMenuItem.Name = "abouitToolStripMenuItem";
            this.abouitToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.abouitToolStripMenuItem.Text = "About";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 225);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.CreateLayoutButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartMenuStrip);
            this.MainMenuStrip = this.StartMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartForm";
            this.Text = "MediaWiki Helper Applet";
            this.Load += new System.EventHandler(this.StartForm_Load);
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

