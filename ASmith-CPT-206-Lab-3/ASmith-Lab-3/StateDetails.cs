/*Ashley Smith
 * CPT-206-A01S (Adv Event-Driven Program)
 * Lab 3: Creating State Database
 * Details Form (of each state)
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
    public partial class StateDetails : Form
    {
        //Connection to the State Data (Main Form) to show in text
        public StateDetails()
        {
            InitializeComponent();
        }

        //Navigation bar
        private void stateTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stateTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.statelistDataSet);

            ////Variables
            //int count = -1; /*If the user click on 'Next (>)' on Naivgator bar
            //then the image would go to zero as number one. If they clicked on
            //'Previous (<)' then it will go to the first image index 1 to 0
            //(that has a image)*/

            ////Shows the bird image
            //birdPicBox.Image = birdImageList.Images[count];

            ////Check if the condition is right
            //if (count < 46)
            //{
            //    count++; /*Continue to count*/
            //}


        }

        //Show the states from the database to the textbox in separate form
        private void StateDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'statelistDataSet.StateTable' table. You can move, or remove it, as needed.
            this.stateTableTableAdapter.Fill(this.statelistDataSet.StateTable);

        }

        


        //Exits out the State Details form and back to the database form
        private void btnExitDetails_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
