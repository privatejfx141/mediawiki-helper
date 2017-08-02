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
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(128, 152);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(120, 40);
            this.ReturnButton.TabIndex = 0;
            this.ReturnButton.Text = "&Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // CreateMenuStrip
            // 
            this.CreateMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.CreateMenuStrip.Name = "CreateMenuStrip";
            this.CreateMenuStrip.Size = new System.Drawing.Size(257, 24);
            this.CreateMenuStrip.TabIndex = 2;
            this.CreateMenuStrip.Text = "menuStrip1";
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 201);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.CreateMenuStrip);
            this.MainMenuStrip = this.CreateMenuStrip;
            this.Name = "CreateForm";
            this.Text = "Create New Template Layout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.MenuStrip CreateMenuStrip;
    }
}