/*Ashley Smith
 * CPT-206-A01S (Adv Event-Driven Program)
 * Lab 3: Creating State Database
 * Introduction form (before showing the database)
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASmith_Lab_3
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        /*Shows the Main form (StateData database) once 
         the user clicks "Play"*/
        private void btnPlay_Click(object sender, EventArgs e)
        {
            StateData stateDataForm = new StateData();
            stateDataForm.ShowDialog(); /*Shows the database after
            clicking "Play"*/
            this.Hide(); //hides the Intro form to show the database
            
        }

        /*Leaves the database completely before getting to the database*/
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       








    }
}
