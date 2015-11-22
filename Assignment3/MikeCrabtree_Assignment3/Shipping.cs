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
    class Shipping
    //This is my shipping class.  This class has properties like real shipping
    //selections do
    {
        public string Option { get; set; }
        //Option is of type string because option is the name I gave to the data
        //like "One Week" etc

        public float Cost { get; set; }
        //Cost is a float because the cost will have decimals but doesn't require
        //the added precision of double or decimal

        public int DeliveryDays { get; set; }
        //Delivery days is the name I have given to the numeric representative of
        //all the data in option.  If Option is "One Week" then DeliveryDays
        //is "7"

        public Shipping(string option, float cost, int deliverydays)
        //This method is used to set the variables declared here equal to their
        //equivalent properties within the class.
        {
            Option = option;

            Cost = cost;

            DeliveryDays = deliverydays;
        }
    }
}
