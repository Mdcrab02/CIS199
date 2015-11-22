/*Assignment 2: Shopping
 * Author: Mike Crabtree
 * Class: CIS199-01
 * Purpose: This program will allow a user to select products from
 * the list of products, see their information, put them into a shopping
 * cart, see the amount they will have to pay after taxes and perhaps
 * a discount.  It will also allow them to select from a number of shipping
 * options and see the estimated time for delivery.  Classes, ya'll.
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

namespace MikeCrabtree_Assignment3
{
    public partial class Form1 : Form
    //This is the form class.
    {
        private Product[] products = new Product[5];
        //Okay, here is an array of type Product.  This way, the
        //array has 5 entries, and each entry has 4 properties
        //(the ones we declared in the Product class)

        private Shipping[] shippingoptions = new Shipping[4];
        //This array is of type Shipping and has 4 entries, each
        //with

        private ShoppingCart shoppingcart = new ShoppingCart();
        //This creates a new shopping cart named shoppingcart of type
        //ShoppingCart.  This way, shoppingcart has all the properties
        //described in ShoppingCart.

        float ShippingCostHolder = 0;
        //This is the variable I used to hold the value of the shipping
        //cost to add it with the shoppingcart.subtotal to give me the
        //total.

        public Form1()
        {
            InitializeComponent();
            //This where I populate the products array with data for each property
            //described in the Product class
            products[0] = new Product("Microsoft Surface Pro", 999.99f, 10.6f, 128);
            products[1] = new Product("Apple iPad Air", 479.99f, 9.7f, 16);
            products[2] = new Product("Samsung Galaxy Tab 3", 349.99f, 10.1f, 16);
            products[3] = new Product("Google Nexus 7", 229.99f, 7f, 16);
            products[4] = new Product("Amazon Kindle Fire HD", 149.99f, 7f, 16);

            //This populated with shippingoptions array with data for each property
            //in the Shipping class
            shippingoptions[0] = new Shipping("Next Day", 24.99f,1);
            shippingoptions[1] = new Shipping("Two Days", 19.99f,2);
            shippingoptions[2] = new Shipping("One Week", 14.99f,7);
            shippingoptions[3] = new Shipping("Two Weeks", 5.99f,14);

            //This populates the listbox of available products with each product's
            //name property as described in the products array above
            foreach (Product product in products)
            {
                lboxProductList.Items.Add(product.Name);
                //Again, this only uses the name property
            }

            //This populates the combo box cboxShipping with the option (think of this
            //like the "name") property as described in the shippingoptions array
            foreach (Shipping shipping in shippingoptions)
            {
                cboxShipping.Items.Add(shipping.Option);
            }
            //This makes the calendar control "read only" so the user can't get lost
            //clicking around on the calendar wondering if he can have items delivered
            //to the past without a TARDIS class.
            calDelivery.Enabled = false;
        }

        private void lboxProductList_SelectedIndexChanged(object sender, EventArgs e)
        //This is the method called when the user clicks on different products in the product
        //list box
        {
            Product product;
            //This declares a variable named product of class Product.

            product = products[lboxProductList.SelectedIndex];
            //This says that product is of the products array with the index value of whatever
            //product the user selected.

            txtProductDetails.Text = "Product name: " + product.Name + "\r\n" + "Screen size: " + product.ScreenSize
                + "\"" + "\r\n" + "Storage capacity: " + product.StorageCapacity + "GB" +
                "\r\n" + "Price: $" + product.Price;
            //This populates the multiline textbox with all of the information defined in the
            //products array with all the appropriate properties.

        }

        private void lboxProductList_DoubleClick(object sender, EventArgs e)
        //This is the event for when the user double clicks a product and intends to add it
        //to the shopping cart.
        {
            Product product;
            //This declares a variable named product of class Product.

            product = products[lboxProductList.SelectedIndex];
            shoppingcart.products.Add(product);
            //This says that whatever index position the user double clicked, the data for
            //that index position in the products array is added to the shopping cart
            //property products

            Updateshoppingcart();
            //This is my method that updates the GUI

            //lboxShoppingCart.Items.Add(product.Name);
            //This line above was causing me to have a duplicate entry in my 
            //shopping cart listbox becuase it comes after the updateshoppingcart()
            //with adding the name (nothing else) to the list box.

        }

        private void cboxShipping_SelectedIndexChanged(object sender, EventArgs e)
        //This is the even for when the user selects different items in the shipping
        //options combo box
        {
            Shipping option;
            //This is a variable named option of class Shipping

            if (cboxShipping.SelectedIndex != -1)
            //This checks to see if the user has actually selected anything in the
            //shipping option combo box.
            {
                option = shippingoptions[cboxShipping.SelectedIndex];
                //This says that option is to hold the data given in the shippingoptions
                //array for whatever index position the user has selected

                shoppingcart.shipping = option;
                //This says that shoppingcart's property shipping is to be populated
                //with everything in option.

                txtShippingCost.Text = shoppingcart.shipping.Cost.ToString("c");
                //This populats the shipping cost text box with the Cost property of the
                //shopping cart's shipping property.

                ShippingCostHolder = shoppingcart.shipping.Cost;
                //Here I add the data in the cost property of the shopping cart's shipping
                //property to my global variable I use to get the grand total for the order.

                lblDelivery.Text = "Delivery in " + shoppingcart.shipping.DeliveryDays + " day(s): " +
                    DateTime.Now.AddDays(shoppingcart.shipping.DeliveryDays).ToString("dddd MMMM dd, yyyy");
                //This is the fancy part that shows the user the expected delivery time based
                //on their selection of shipping options.

                calDelivery.SetDate(DateTime.Now.AddDays(shoppingcart.shipping.DeliveryDays));
                //This highlights the expected delivery date on the month calendar control
                //so the user can see it.

                Updateshoppingcart();
                //again here is my method that updates the GUI
            }

        }

        private void lboxShoppingCart_DoubleClick(object sender, EventArgs e)
        //This is the event when the user double clicks on an item in the shopping cart
        //list box with the intent to remove it
        {
            Product product = null;
            //This sets the variable product of class Product to null.

            if (lboxShoppingCart.SelectedItem != null)
            //If the user hasn't clicked on empty space in the listbox, then...
            {
                foreach (Product product2 in products)
                {
                    if (product2.Name == lboxShoppingCart.SelectedItem.ToString())
                    //This checks for the name property to match what the user
                    //double clicked with the item that is in the shopping cart.
                    {
                        product = product2;
                    }
                }
                //remove product from shopping cart
                shoppingcart.products.Remove(product);

                //update GUI
                Updateshoppingcart();
            }
        }

        private void Updateshoppingcart()
        //This is the infamous method that updates the GUI
        {
            float newshippingcost = 0;
            //This variable is what eventually holds the grand total

            lboxShoppingCart.Items.Clear();
            //This clears all of the items in the shopping cart

            foreach (Product product in shoppingcart.products)
            //This repopulates the shopping cart with all the products in
            //product
            {
                lboxShoppingCart.Items.Add(product.Name);
            }
            txtSubtotal.Text = shoppingcart.subtotal.ToString("c");
            //This displays the subtotal of the shopping cart in the
            //appropriate text box in a currency format.

            txtTax.Text = shoppingcart.salestax.ToString("c");
            //This populates the text box for the tax amount with the
            //data in the salestax property of the shopping cart.  Again
            //in currency format.

            txtDiscount.Text = shoppingcart.discount.ToString("c");
            //This displays the discount amount (not percentage) in the
            //text box in a currency format.  This comes from the shopping
            //cart.

            newshippingcost = shoppingcart.total + ShippingCostHolder;
            //This assigns the grand total (shopping cart total and the
            //cost of the shipping from the global variable ShippingCostHolder)
            //to our local variable newshippingcost

            txtTotal.Text = newshippingcost.ToString("c");
            //This displays the contents of newshippingcost in the total
            //textbox.  The grand total!
        }

        private void ClearEverything()
        //This method clears everything, almost.
        {
            txtSubtotal.Clear();
            txtTax.Clear();
            txtDiscount.Clear();
            txtTotal.Clear();
            txtShippingCost.Clear();
            //Clear all the textboxes
            lboxShoppingCart.Items.Clear();
            //Clear the shopping cart listbox
            cboxShipping.SelectedIndex = -1;
            //Clear the shipping combobox
            shoppingcart.Clear();
            //This clears the shopping cart so we aren't left with
            //leftover data from the last purchase.
            lblDelivery.Text = "";
            //This resets the label so we don't know the expected delivery
            //of any past purchases
            tabControl1.SelectTab(tabSelect);
            //This selects the first tab, the product tab!
        }

        private void btnReset_Click(object sender, EventArgs e)
        //This event runs the ClearEverything method when the user clicks the
        //reset button
        {
            ClearEverything();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        //This event is when the user clicks the purchase button
        {
            double newsubtotal;
            newsubtotal = shoppingcart.subtotal;
            //This is a variable to see if the subtotal is zero.  If
            //it is zero, we assume they haven't put anything in the shopping
            //cart.  Can't order nothing and pay shipping!

            if (cboxShipping.SelectedIndex != -1)
            //If the user has selected a shipping option.
            {
                if (newsubtotal != 0)
                //if the subtotal is not zero
                {
                    MessageBox.Show("You have placed your order!");
                    ClearEverything();
                    //This processes the order and resets the GUI so that another
                    //user can order some stuff.
                }
                else
                {
                    MessageBox.Show("You haven't ordered anything, breh.");
                    //if the user hasn't put anything in the shopping cart.
                }
            }
            else
            {
                MessageBox.Show("You have to select a shipping option");
                //if the user has not selected a shipping option.
            }
        }

    }
}
