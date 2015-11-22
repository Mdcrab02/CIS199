using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikeCrabtree_Assignment2
{
    public partial class Form1 : Form
    {
        //apparently you can just declare arrays up here to hold data specified in the
        //constructor for later use.  This seems better because it saves me several
        //lines of code
        private decimal[] shirtPrice = new decimal[3];
        //this declares a decimal array (with 3 index values) and gives it the name shirtPrice
        private decimal[] shirtCost = new decimal[3];
        //this is a similar array but for the cost of the shirts

        private decimal TotalCash = 50000m;
        //Here is the variable that holds my starting cash.  It is outside of all the other
        //methods and events so that each piece of the program can access it

        private int[] shirtInventory = new int[3];
        //This array is down here because it is of type int.  Unless you can have .25 shirts,
        //int should be fine

        private string[] shirtNames = new string[3];

        public Form1()
        {
            InitializeComponent();
            //this starts the background code to initialize the form.  It's best not to change
            //this unless you know what you're doing.
            shirtPrice[0] = 18.99m;
            shirtPrice[1] = 19.99m;
            shirtPrice[2] = 20.99m;
            //Here I declared the values to be placed in the decimal arrays I named earlier
            //This puts the values in the constructor instead of declaring global constants
            //and calling them individually throughout the program
            //0 = small, 1 = medium, 2 = large

            shirtCost[0] = 15.99m;
            shirtCost[1] = 16.99m;
            shirtCost[2] = 17.99m;
            //Just like above these are the indexes in the array that are holding the cost
            //for each size of shirt
            //0 = small, 1 = medium, 2 = large

            shirtInventory[0] = 50;
            shirtInventory[1] = 50;
            shirtInventory[2] = 50;
            //Again, another array.  This one holds the values for the inventory.  With it
            //up here in the constructor, the programs many methods and such can access these
            //values
            //again, 0 = small, 1 = medium, 2 = large

            shirtNames[0] = "Red T-Shirt (S)";
            shirtNames[1] = "Red T-Shirt (M)";
            shirtNames[2] = "Red T-Shirt (L)";

            PopulateInventory();
            //This puts my PopulateInventory method in the constructor.  This way, the boxes
            //for the shirt inventory numbers start out with 50 as soon as I initialize the form
            //These values were also put into an array so I can call them throughout the program,
            //and have the program keep track of the numbers for me

        }

        //This is my original way of getting the index values for each of the selected items
        //and assigning them a value.  This should be just like we did in class.

        //private double GetShirtPrice(int index)
        //{
        //    double shirtPrice = 0;

        //    const double SMALL_PRICE = 18.99;
        //    const double MED_PRICE = 19.99;
        //    const double LAR_PRICE = 20.99;

        //    switch (index)
        //    {
        //        case 0:
        //            shirtPrice = SMALL_PRICE;
        //            break;

        //        case 1:
        //            shirtPrice = MED_PRICE;
        //            break;

        //        case 2:
        //            shirtPrice = LAR_PRICE;
        //            break;

        //        default:
        //            break;
        //    }

        //    return shirtPrice;
        //}

        //private double GetShirtCost(int index)
        //{
        //    double shirtCost = 0;

        //    const double SMALL_COST = 15.99;
        //    const double MED_COST = 16.99;
        //    const double LAR_COST = 17.99;

        //    switch (index)
        //    {
        //        case 0:
        //            shirtCost = SMALL_COST;
        //            break;

        //        case 1:
        //            shirtCost = MED_COST;
        //            break;

        //        case 2:
        //            shirtCost = LAR_COST;
        //            break;

        //        default:
        //            break;
        //    }

        //    return shirtCost;
        //}
        private void PopulateInventory()
        {
            //Turns out this will keep the displays up to date with the most current 
            //inventory numbers.  This should save me from having each method update
            //the display throughout the program
            txtInvSmall.Text = shirtInventory[0].ToString();
            txtInvMed.Text = shirtInventory[1].ToString();
            txtInvLar.Text = shirtInventory[2].ToString();
            //because the inventory array is an int, we have to use .ToString to populate
            //the respective text boxes
        }

        private void btnExecuteSale_Click(object sender, EventArgs e)
        {
            //Declare the variables for this event
            int shirtIndex = cboxSell.SelectedIndex;
            //This just makes ShirtIndex the item that the user selected in the cbox.
            //This way, I can just type shirtIndex in my code and not cboxSell.SelectedIndex
            string selectedName = shirtNames[cboxSell.SelectedIndex];
            //This way I have a placeholder for the string array I declared earlier but instead
            //of retrieving the value for the selected index, it retrieves the string that has
            //the name and size of the shirt I declared earlier.  This also saves me some typing

            int saleQuantity;
            //this is a placeholder for the amount of shirts the user enters to sell.
            decimal saleAmount;
            //These variables are for the amount of shirts
            decimal salePrice = shirtPrice[shirtIndex];
            //This way, the variable salePrice becomes shirtPrice(the array) with the index
            //shirtIndex, which we just said is the selected item in the combo box
            int currentInventory = shirtInventory[shirtIndex];
            //I needed to declare a variable here so that when this event decreases inventory
            //this variable takes what my array has stored for the selected index (cbox again)
            //and uses that to see if the business is trying to have -4 shirts, etc.

            if (!int.TryParse(txtSaleQuantity.Text, out saleQuantity))
            {
                //if the user tries to enter a letter for sale quantity, show and error messagebox
                MessageBox.Show("Numbers only, breh.", "ERROR", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSaleQuantity.Focus();
                return;
                //As it turns out, instead of using if and else, I can just put return at the end of
                //the if statement instead.  This way if it does go into the if statement, once it
                //finishes it returns to the normal part of the program
            }

            if (currentInventory - saleQuantity < 0)
            {
                //Same as above here, only this checks to see if the user is trying to run inventory
                //into the negative
                MessageBox.Show("You can't have fewer than zero shirts.", "ERROR", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSaleQuantity.Focus();
                return;
                //Again, same as above here
            }

            saleAmount = saleQuantity * salePrice;
            //this assigns the result of quantity * price to saleAmount

            txtSaleAmount.Text = saleAmount.ToString("c");
            //Display the contents of saleAmount in the appropriate textbox

            TotalCash += saleAmount;
            //This decreases TotalCash (remember, it's in the constructor) and decreases it
            //by the contents of saleAmount
            txtTotal.Text = TotalCash.ToString("c");
            //display the contents of what is NOW TotalCash in the appropriate text box
            shirtInventory[shirtIndex] -= saleQuantity;
            //This tells the program to decrease the inventory by the amount sold, but will not
            //update the text boxes -important-

            PopulateInventory();
            //This calls the method that will update the text boxes to show the correct inventory

            if (currentInventory <= 10)
            {
               DialogResult result = MessageBox.Show("Inventory for " + selectedName + " is currently at " + currentInventory +
                    ", would you like to order more shirts?", " Low Inventory Alert", MessageBoxButtons.YesNo);

               if (result == DialogResult.Yes)
               {
                   tboxTshirt.SelectTab(tabOrder);
                   txtOrderQuantity.Focus();
               }
               else
               {
                   return;
               }
               

            }

        }

        private void cboxSell_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExecuteOrder_Click(object sender, EventArgs e)
        {
            int costIndex = cboxOrder.SelectedIndex;
            //This has costIndex become the selected cbox item, keeping me from having to type
            //cboxOrder.SelectedIndex over and over
            int orderQuantity;
            //Again, int is fine here unless you can have <1 of a shirt
            decimal orderAmount;
            //This variable holds what the use enters as the quantity to order
            decimal orderCost = shirtCost[costIndex];
            //This says that the order cost is shirtCost(the array) with costIndex as the cbox
            //index selected by the user
            int CurrentInventory = shirtInventory[costIndex];
            //this, again, is a placeholder for the inventory of the shirt size selected by the user
            //which saves me some typing and keeps my keyboard from melting

            if (!int.TryParse(txtOrderQuantity.Text, out orderQuantity))
            {
                //If the user trieds to order a quantity of shirts that is a letter
                //Display a messagebox showing the error and return the focus to the
                //textbox where the error occurred
                MessageBox.Show("Numbers only, breh.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOrderQuantity.Focus();  //again, return the focus to the txtbox where
                //the error occurred
                return; //and again, return the program to the above code outside this statement
            }

            if (CurrentInventory + orderQuantity > 50)
            {
                //This keeps the user from increasing the inventory for any shirt size
                //to more than 50, which is no bueno apparently
                MessageBox.Show("We only have space for 50 of each shirt.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOrderQuantity.Focus();  //focus on the textbox where the error occurred
                return;  //return the program to it's pre-error state (above this statement
                //and above the above if statement
            }
            orderQuantity = int.Parse(txtOrderQuantity.Text);
            //this gets the quantity the user enters into txtOrderQuantity and makes it an
            //int that we declared earlier, orderQuantity.

            orderAmount = orderQuantity * orderCost;
            //this assigns the result of orderQuantity * orderCost to orderAmount.

            TotalCash -= orderAmount;
            //This decreases our TotalCash variable (declared at the top) by the
            //contents of orderAmount
            txtTotal.Text = TotalCash.ToString("c");
            //display the contents of TotalCash in the appropriate text box

            txtOrderAmount.Text = orderAmount.ToString("c");
            //This puts the contents of orderAmount in the appropriate text box
            //with a currency format

            shirtInventory[costIndex] += orderQuantity;
            //This increases our shirt inventory for the selected cbox item by the
            //quantity (not amount) we ordered

            PopulateInventory();
            //This updates all the textboxes with the new inventory amounts by calling our
            //handy method!

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //Clear the textboxes and set each combobox index to -1 (blank)
            txtSaleQuantity.Clear();
            txtOrderQuantity.Clear();
            txtSaleAmount.Clear();
            txtOrderAmount.Clear();
            cboxSell.SelectedIndex = -1;
            cboxOrder.SelectedIndex = -1;
            //This has the new transaction button select the selling tab
            tboxTshirt.SelectTab(tabSell);

        }

    }

}