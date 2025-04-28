/* Ashley Smith
 * CPT-185-A01H
 * Lab 9: Databases (Ch. 10; Question 6) (Part 2)
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

namespace Ashley_Smith_CPT_185_A01H_Lab_9
{
    public partial class ChargesForm : Form
    {
        //Private Variables
        private decimal dorms = 0.0m;
        private decimal meals = 0.0m;
        decimal total = 0.0m;
        public ChargesForm(decimal MealCharges, decimal DormCharges)
        {
            InitializeComponent();
            //Variable calling the parameters (MealCharges and DormCharges)
            meals = MealCharges;
            dorms = DormCharges;

            //Calculation
            total += meals + dorms;

            //TextBoxes that shows Dormitority Total Charges
            txtDorm.Text = dorms.ToString("c");
            txtMeal.Text = meals.ToString("c");
            txtTotalCharges.Text = total.ToString("c");
        }

        //"About" shows the about form
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm myAboutForm = new AboutForm();
            myAboutForm.ShowDialog();
        }
        



        //"Go to about" button to show the "About Form"
        private void btnGoToAbout_Click(object sender, EventArgs e)
        {
            AboutForm myAboutForm = new AboutForm();
            myAboutForm.ShowDialog();
        }

        //Closes the Charges Form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
