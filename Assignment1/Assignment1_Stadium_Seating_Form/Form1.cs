/* Assignment 1: Stadium Seating Calculator
 * Author: Mike Crabtree
 * Class: CIS199-01
 * Purpose: This program will calculate revenue earned from each class of ticket and total revenue based on revenue
 * for each ticket class
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

namespace Assignment1_Stadium_Seating_Form //I changed the name property in the solution explorer but it did not change this
{
    public partial class formStadiumSeating : Form
    {
        public formStadiumSeating()
        {
            InitializeComponent();//This initializes the form!  It has some stuff not seen here get up and going
        }

        private void btnCalc_Click(object sender, EventArgs e) //Everything in this block happens when the user hits btnCalc
        {
            //I added try/catch block because I like input validation!
            try
            {
                //Declare constant variables for the piece price for each class of ticket
                const double classAPrice = 15;
                const double classBPrice = 12;
                const double classCPrice = 9;
                //I made these constant because the program will not be changing these values

                //Declare variables for the calculations
                double classARevenue;
                double classBRevenue;
                double classCRevenue;
                double totalRevenue;
                //I like to declare variables on seperate lines in small programs for readability

                //Calculate the revenue from the data entered in the quantity field for class A tickets
                classARevenue = (double.Parse(txtClassAQuantity.Text) * classAPrice);
                txtClassARev.Text = classARevenue.ToString("c");
                //Once the revenue for Class A is calculated, display it in a currency format
                
                //Calculate the revenue from the data entered in the quantity field for class B tickets
                classBRevenue = (double.Parse(txtClassBQuantity.Text) * classBPrice);
                txtClassBRev.Text = classBRevenue.ToString("c");
                //Once the revenue for Class B is calculated, display it in a currency format...again

                //Calculate the revenue from the data entered in the quantity field for class C tickets
                classCRevenue = (double.Parse(txtClassCQuantity.Text) * classCPrice);
                txtClassCRev.Text = classCRevenue.ToString("c");
                //Once the revenue for Class C is calculated, display it in a currency format

                //Calculate the total revenue from the revenue of each class
                totalRevenue = classARevenue + classBRevenue + classCRevenue;
                txtTotalRev.Text = totalRevenue.ToString("c");
                //Once the revenue is calculated, display it in a currency format
            }
            catch//This is what happens when the program catches the user sneaking in letters as input!
            {
                //Show an error message if the user enters something other than numbers and punctuation(,.)
                MessageBox.Show("Invalid input, numbers only!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)//This is when you click btnClear!
        {
            //Clear the ticket quantity fields
            txtClassAQuantity.Text = "";
            txtClassBQuantity.Text = "";
            txtClassCQuantity.Text = "";
            //All of these fields could also use txtClass_Quantity.Clear(); alternative

            //Clear the revenue fields
            txtClassARev.Text = "";
            txtClassBRev.Text = "";
            txtClassCRev.Text = "";
            txtTotalRev.Text = "";
            //These could use the .Clear method as well, but not if they are labels

            txtClassAQuantity.Focus();
            //This sets the focus back in the first input field once everything is cleared.  Why not?
        }

        private void btnExit_Click(object sender, EventArgs e)//This is when you click btnExit!
        {
            //Close the form!
            this.Close();
        }
    }
}
