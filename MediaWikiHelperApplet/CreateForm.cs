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

        }
    }
}
