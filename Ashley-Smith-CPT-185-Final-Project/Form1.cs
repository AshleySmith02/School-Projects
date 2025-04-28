using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ashley_Smith_CPT_185_Final_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //Message shown before showing the screen to start ordering
            
        }

        //Declare Variables
        decimal price = 0.0m;
        string displaySalTax = " ";
        decimal saleTax = 0.0m;
        decimal total = 0.0m;
        string userChoice = " ";
        decimal grandTotal = 0.0m;

        //Stream reader and writer
        StreamWriter outputFile;
        StreamReader inputFile;

        //Shows the result of what user put their name and selected choices
        private void btnDisplayOrderList_Click(object sender, EventArgs e)
        {
          
            //Selected Menu Groupbox
            if (radioCarButton.Checked)
            {
                radioCarButton.Checked = true;
                userChoice = "New Car\t";
                price = 10000;
                displaySalTax = "5%";
                saleTax = 0.05m;
            }
            else if (radioComputerButton.Checked)
            {
                radioComputerButton.Checked = true;
                userChoice = "Computer Set";
                price = 550;
                displaySalTax = "\t" +"6%";
                saleTax = 0.06m; 
            }
            else if (radioClothesButton.Checked)
            {
                radioClothesButton.Checked = true;
                userChoice = "Clothes\t";
                price = 40;
                displaySalTax = "\t" + "7%";
                saleTax = 0.07m;
            }
            else if (radioBurgerButton.Checked)
            {
                radioBurgerButton.Checked = true;
                userChoice = "Burger combo";
                price = 20;
                displaySalTax = "\t" + "8%";
                saleTax = 0.08m;
            }
            else if (radioFiveThouButton.Checked)
            {
                radioFiveThouButton.Checked = true;
                MessageBox.Show("Sorry, you can't get it that way" +
                    "please find the image the has it or click on " +
                    "the 'help' button");
                return;
            }
            else if (radioDeckCardsButton.Checked)
            {
                radioDeckCardsButton.Checked = true;
                userChoice = "Deck of Cards";
                price = 12;
                displaySalTax = "\t" + "2%";
                saleTax = 0.02m;
            }
            //Calculation Total
            total = (price * saleTax) + price;
            grandTotal += total;

            //Displaying results in the list (box) order window
            Intro Display = new Intro(txtName.Text);
            lstDisplayOrder.Items.Add(Display.Name + "\t\t" + userChoice + "\t\t" 
                + price.ToString("c") + "\t\t" + displaySalTax + "\t\t\t" +
                total.ToString("c"));
            

        }

        //Print receipt
        private void btnPrintWindowOrder_Click(object sender, EventArgs e)
        {
            try
            {
                //Creating 'receipt' file
                outputFile = File.CreateText("receipt.txt");

                //Puting information into a receipt from the Window Order (Display Order Window)
                outputFile.WriteLine("\t\t\t\t\t\t\tASH'S WAREHOUSE RECEIPT");
                outputFile.WriteLine("______________________________" +
                    "__________________________________________" +
                    "___________________________________________________________");

               
                //Items underneath the Title from Window Order listbox
                string[] Items = new string[lstDisplayOrder.Items.Count];
                lstDisplayOrder.Items.CopyTo(Items, 0);
                foreach (string Item in Items)
                {
                    outputFile.WriteLine(Item);
                    
                }
                //Space from the receipt and the grandTotal
                outputFile.WriteLine("\n");
                outputFile.WriteLine("The grand total is: " + grandTotal.ToString("c"));

                //Letting the user know that their receipt has been printed
                MessageBox.Show("Your receipt has been printed. Look inside your" +
                    "file that is titled 'receipt.txt");

                //Closing the 'receipt' file
                outputFile.Close();

            }
            catch (Exception ex) //Display's error message before printing receipt
            {
                MessageBox.Show(ex.Message);
            }
        }




        //Clear everything in the Menu groupbox
        private void btnClearOrderMenu_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            ClearAll();
        }
        private void ClearAll()
        {
            radioCarButton.Checked = false;
            radioComputerButton.Checked = false;
            radioClothesButton.Checked = false;
            radioBurgerButton.Checked = false;
            radioFiveThouButton.Checked = false;
            radioDeckCardsButton.Checked = false;
        }

        //Clears the Display Window Order List
        private void btnClearOrderWindow_Click(object sender, EventArgs e)
        {
            lstDisplayOrder.Items.Clear();
            lstDisplayOrder.Items.Add("Name\t\tMenu Item\t\tPrice\t\t\tSale Tax\t\t\tTotal");
            lstDisplayOrder.Items.Add("__________________________________________________" +
                "___________________________________________________________" +
                "______________________");
        }


        //Exit the register form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Energate class to make the list order appear from the Menu groupbox to Display Window Order
        class Intro
        {
            //Declare my variables/fields
            string _name = " ";


            //Constructor
            public Intro(string name)
            {
                _name = name;
            }

            //Name Property
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
        }

        
    }
   
}
