/* Ashley Smith
 * CPT-185-A01H
 * Lab 9: Databases (Ch. 10; Question 6)
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ashley_Smith_CPT_185_A01H_Lab_9
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
       
        
        


        //Displays total on a separate form called Charges Form (txt: Dormitory Total Charges)
        public void btnDisplayTotal_Click(object sender, EventArgs e)
        {
            decimal ChargesMeals = 0.0m;
            decimal ChargesDorm = 0.0m;
            //Dorm groupbox
            if (radioAllen.Checked)
            {
                radioAllen.Checked = true;
                ChargesDorm = 1500;
            }
            else if (radioPike.Checked)
            {
                radioPike.Checked = true;
                ChargesDorm = 1600;
            }
            else if (radioFarthing.Checked)
            {
                radioFarthing.Checked = true;
                ChargesDorm = 1800;
            }
            else if (radioUniversity.Checked)
            {
                radioUniversity.Checked = true;
                ChargesDorm = 2500;
            }
            //Meal Plan groupBox
            if (radio7Meals.Checked)
            {
                radio7Meals.Checked = true;
                ChargesMeals = 600;
            }
            else if (radio14Meals.Checked)
            {
                radio14Meals.Checked = true;
                ChargesMeals = 1200;
            }
            else if (radioUnlimitedMeals.Checked)
            {
                radioUnlimitedMeals.Checked = true;
                ChargesMeals = 1700;
            }
            else
            {
                MessageBox.Show("Please select the both Dorm and Meal Plan groupboxes before clicking" +
                    " the display total button");
                return;
            }

            //Connecting the Charges form to the Main Form
            ChargesForm myChargesForm = new ChargesForm(ChargesMeals, ChargesDorm);

            //Shows separate form with the totals of dorm, cost, & total
            myChargesForm.ShowDialog();
            







        }
        
        


        //Clears the Main Form selected buttons
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        

        private void ClearAll()
        {
            ClearselectDormBox();
            ClearselectMealPlanBox();
        }
        private void ClearselectDormBox() //Un-Checked Dorm groupbox
        {
            radioAllen.Checked = false;
            radioPike.Checked = false;
            radioFarthing.Checked = false;
            radioUniversity.Checked = false;
        }

        private void ClearselectMealPlanBox() //Un-Checked Meal Plan groupbox
        {
            radio7Meals.Checked = false;
            radio14Meals.Checked = false;
            radioUnlimitedMeals.Checked = false;
        }

        //'Help' dropdown side title bar
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm myHelpForm = new AboutForm();
            myHelpForm.ShowDialog();
        }

        //Closes the Main Form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
    //Dorm GroupBox
    class Dorms
    {
        //Fields
        private double _allenHall = 0; //1500
        private double _pikeHall = 0; //1600
        private double _fatheringHall = 0; //1800
        private double _universityHall = 0; //2500

        //Constructor 
        public Dorms()
        {
            _allenHall = 1500;
            _pikeHall = 1600;
            _fatheringHall = 1800;
            _universityHall = 2500;
        }

        //Allen Hall Property
        public double AllenHall
        {
            get { return _allenHall; }
            set { _allenHall = value; }
        }

        //Pike Hall Property
        public double PikeHall
        {
            get { return _pikeHall; }
            set { _pikeHall = value; }
        }

        //Fathering Hall
        public double FatheringHall
        {
            get { return _fatheringHall; }
            set { _fatheringHall = value; }
        }

        //University Hall
        public double UniversityHall
        {
            get { return _universityHall; }
            set { _universityHall = value; }
        }

    }
    //Meal Plan Groupbox
    class Meals
    {
        //Fields
        private double _sevenMeals = 0; //600
        private double _fourteenMeals = 0;//1200
        private double _unlimitedMeals = 0;//1700

        //Constructor 
        public Meals()
        {
            _sevenMeals = 600;
            _fourteenMeals = 1200;
            _unlimitedMeals = 1700;
        }

        //7 Meals per week
        public double SevenMeals
        {
            get { return _sevenMeals; }
            set { _sevenMeals = value; }
        }

        //14 Meals per week
        public double FourteenMeals
        {
            get { return _fourteenMeals; }
            set { _fourteenMeals = value; }
        }

        //Unlimited Meals
        public double UnlimitedMeals
        {
            get { return _unlimitedMeals; }
            set { _unlimitedMeals = value; }
        }

    }

    

}
