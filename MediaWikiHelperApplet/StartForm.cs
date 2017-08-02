using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaWikiHelperApplet {
    public partial class StartForm : Form {

        /// <summary>
        /// Creates and initializes the start menu form.
        /// </summary>
        public StartForm() {
            InitializeComponent();
        }

        /// <summary>
        /// Prompts the user to exit this application.
        /// </summary>
        private void exitApplication() {
            String exitMsg = "Are you sure you want to exit the application?";
            String exitTitle = "Exit Application";
            DialogResult exitResult = MessageBox.Show(exitMsg, exitTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // if user clicks "Yes" on prompt, exit the application
            if (exitResult == DialogResult.Yes) {
                Application.Exit();
            }
        }

        /// <summary>
        /// Opens the template layout creation form modally.
        /// </summary>
        private void openCreateLayoutForm() {
            Form frmCreate = new CreateForm();
            frmCreate.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        private void openGenerateCodeForm() {

        }

        /// <summary>
        /// Prompts the user to exit this application.
        /// </summary>
        /// <param name="sender">The button control that calls this method.</param>
        /// <param name="e">Event arguments.</param>
        private void ExitButton_Click(object sender, EventArgs e) {
            exitApplication();
        }

        /// <summary>
        /// Opens the template layout creation form modally.
        /// </summary>
        /// <param name="sender">The button control that calls this method.</param>
        /// <param name="e">Event arguments.</param>
        private void CreateLayoutButton_Click(object sender, EventArgs e) {
            openCreateLayoutForm();
        }

        private void createLayoutToolStripMenuItem_Click(object sender, EventArgs e) {
            openCreateLayoutForm();
        }

        private void generateCodeToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            exitApplication();
        }

    }
}
