/*Ashley Smith
 * CPT-206-A01S (Adv Event-Driven Program
 * Lab 3: Creating State Database
 * Main Form
 */


using ASmith_Lab_3_State_Class_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASmith_Lab_3
{
    public partial class StateData : Form
    {
        public StateData()
        {
            InitializeComponent();
        }

        private void stateTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try /*After updating, it will let the user know if they have enter in wrong data
                 and need to be corrected*/
            {
                this.stateTableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.statelistDataSet);
            }
            catch (Exception ex)
            {
                /*Shows the problem of what the user try to enter in
                 the database*/
                MessageBox.Show(ex.Message);
            }
            

        }

        //Shows the database when running
        private void StateData_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'statelistDataSet1.StateTable' table. You can move, or remove it, as needed.
            //this.stateTableTableAdapter.Fill(this.statelistDataSet1.StateTable);
            // TODO: This line of code loads data into the 'statelistDataSet.StateTable' table. You can move, or remove it, as needed.
            this.stateTableTableAdapter.Fill(this.statelistDataSet.StateTable);

        }

        //Select different ranges of median income
        private void btnFilterMedian_Click(object sender, EventArgs e)
        {
            stateTableDataGridView.AutoGenerateColumns = true;

            /*Choose from the 'Filter Median' combo box to select
             which median the user selected*/
            switch (stateMedianCB.SelectedIndex)
            {
                case 0:
                    stateTableBindingSource.DataSource = StateName.
                        updatemedian(10000, 19999);
                    break;
                case 1:
                    stateTableBindingSource.DataSource = StateName.
                        updatemedian(20000, 29999);
                    break;
                case 2:
                    stateTableBindingSource.DataSource = StateName.
                        updatemedian(30000, 39999);
                    break;
                case 3:
                    stateTableBindingSource.DataSource = StateName.
                        updatemedian(40000, 49999);
                    break;
                case 4:
                    stateTableBindingSource.DataSource = StateName.
                        updatemedian(50000, 59999);
                    break;
                case 5:
                    stateTableBindingSource.DataSource = StateName.
                        updatemedian(60000, 69000);
                    break;
                case 6:
                    stateTableBindingSource.DataSource = StateName.
                        updatemedian(0, 10000000000000000000);
                    break;
                default: //else
                    MessageBox.Show("Please select within the range");
                    break;


            }//end of switch

            /*Combo box keep the list with the median; Once the median is change then the
            'Select Name State' box will change to the name of the range of what the median
            choosen base on income*/
            stateNamebox.DataSource = stateTableBindingSource;
            stateNamebox.DataSource = "State_Name";
            stateNamebox.ValueMember = "Id";


        }//end of Filter Median button

        /*Searches the state of what user typed (if they choose to type the
         state in*/
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Keeps the data in the database
            stateTableDataGridView.AutoGenerateColumns = true;

            //Looks up the letters of what the user typed
            stateTableBindingSource.DataSource = 
            StateName.searchstate(txtSearchBox.Text);

            stateNamebox.DataSource = stateTableBindingSource;
            stateNamebox.DisplayMember = "State_Name";
            stateNamebox.ValueMember = "Id";

        }//End of Search button


        //Show the database in detail form for each states (StateDetails)
        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            StateDetails stateDetails = new StateDetails();
            stateDetails.ShowDialog();
        }


        //Clears the search textbox
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchBox.ResetText();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
