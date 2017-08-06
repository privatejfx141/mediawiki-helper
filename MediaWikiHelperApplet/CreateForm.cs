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
    public partial class CreateForm : Form {

        private TextBox tbTmpName;

        private TextBox tbVariable;

        private ListBox lbVariables;

        private Template template;

        /// <summary>
        /// This method creates and initializes the template layout creation form.
        /// </summary>
        public CreateForm() {
            InitializeComponent();
        }

        /// <summary>
        /// This method closes this form and returns to the start menu form.
        /// </summary>
        /// <param name="sender">The button control that calls this method.</param>
        /// <param name="e">Event arguments.</param>
        private void ReturnButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void CreateForm_Load(object sender, EventArgs e) {
            tbTmpName = NameTextBox;
            tbVariable = VarTextBox;
            lbVariables = VarListBox;
            template = new Template("infobox");
        }

        private void SetNameButton_Click(object sender, EventArgs e) {
            string tmpName = tbTmpName.Text;
            string consoleMsg;
            if (tmpName.Length == 0) {
                consoleMsg = "Template name cannot be empty.";
            } else {
                // set template object name
                template.Name = tmpName;
                consoleMsg = String.Format("Template name set to {0}.", tmpName);
            }
            Console.WriteLine(consoleMsg);
        }

        private void InsertVarButton_Click(object sender, EventArgs e) {
            string addVar = tbVariable.Text;
            string consoleMsg;
            if (addVar.Length == 0) {
                consoleMsg = "Variable name cannot be empty.";
            } else {
                // add variable to list box and template object
                lbVariables.Items.Add(addVar);
                template.AddVariable(addVar);
                tbVariable.Text = "";
                consoleMsg = String.Format("Variable {0} has been added.", addVar);
            }
            Console.WriteLine(consoleMsg);
        }
    }
}
