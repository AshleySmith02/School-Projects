using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ashley_Smith_CPT_185_A01H_Lab_9
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        //Closes the "About for" of the Halls and Meal Plan About Form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
