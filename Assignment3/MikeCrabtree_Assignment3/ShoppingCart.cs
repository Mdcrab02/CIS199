/*Assignment 2: Shopping
 * Author: Mike Crabtree
 * Class: CIS199-01
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeCrabtree_Assignment3
{
    class ShoppingCart
    //This is my shopping cart class.  Like a real shopping cart, there
    //are items within it, and like a POS system, there is some math in
    //this class.  This way, most of the business logic is in the class
    //and not the form.
    {
        public List<Product> products {get; set;}
        //This is the list for products within the shopping cart.  This
        //is a list because there can be X number of products in the cart
        //depending on how much the user wants to spend.

        public float subtotal
        //Here is my subtotal property.  This has a variable, newsubtotal
        //which is the result of the foreach loop going through each product
        //in the above mentioned list, and adding up the price property of
        //the product class.
        //again, float is used because I need some decimal places, but not
        //so many as to require the precision of double or decimal
        {
            get
            {
                float newsubtotal = 0;
                foreach (Product product in products)
                {
                    newsubtotal = product.Price + newsubtotal;
                }
                return newsubtotal;
            }
        }

        public float salestax
        //Here, the float salestax is the property of the shopping cart
        //that represents the total tax owed.  The foreach loop takes
        //the value of the subtotal property and multiplies it by .06
        //to get the amount of sales tax owed for 6% (KY proud!)
        //newtax is the variable used to hold the amount of the tax
        //owed after the calculation is done.
        //again, float is used because I need some decimal places, but not
        //so many as to require the precision of double or decimal
        {
            get
            {
                float newtax = 0;
                foreach (Product product in products)
                {
                    newtax = subtotal * .06F;
                }
                return newtax;
            }
        }

        public float discount
        //Here is the discount property of the shopping cart.  This contains
        //the math for determining if the user gets a discount, and how much
        //again, float is used because I need some decimal places, but not
        //so many as to require the precision of double or decimal
        {
            get
            {
                float newdiscount = 0;
                if (subtotal >= 800)
                //if the user has 800 or more in the subtotal, he gets a 25%
                //discount
                {
                    newdiscount = subtotal * .25F;
                }
                else if (subtotal >= 600)
                //if his subtotal is 600 or more, but less than 800, he
                //gets a 10% discount
                {
                    newdiscount = subtotal * .10F;
                }
                else
                //Otherwise, no discount.  Meh.
                {
                    newdiscount = 0;
                }
                return newdiscount;
            }
        }

        public Shipping shipping { get; set; }
        //Here I have the shipping property of the shopping cart named
        //shipping, but it is also of type Shipping (one of the other
        //classes.  This means that shipping has all of the properties
        //listed in my Shipping class (e.g. shipping.deliverydays)

        public float total
        //This is the property of the total.  This represents the total
        //amount the user wants to spend SANS the amount from the shipping.
        //This way, most of the business logic is in the class but not all.
        //again, float is used because I need some decimal places, but not
        //so many as to require the precision of double or decimal
        {
            get
            {
                //This says that newtotal holds the value given by the
                //calculation below.  It's a float -again- because we 
                //need decimal places but not so many as to necessitate
                //a double or decimal
                float newtotal = 0;
                newtotal = newtotal + subtotal - discount + salestax;
                return newtotal;
            }
        }
        public ShoppingCart()
        //Here we have a method within the class, not a property.  This says
        //that this class will instantiate a new list of class Product by the name
        //of products.  Remember that from the top of the code in this class?
        {
            products = new List<Product>();
        }

        public void Clear()
        //This is another method within this class, except this method is used
        //to clear the list of products.  This is the same as emptying the shopping
        //cart and removing the amount from the selected shipping option
        {
            products.Clear();
            shipping = null;
        }
    }
}
