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
    class Product
    //This is my product class.  Like IRL products, it has properties.
    //In this program, all products have the following properties:
    {
        public string Name { get; set; }
        //This is the name property, which is of type string

        public float Price { get; set; }
        //This is the price property, which is a float because I don't
        //need a large amount of precision and other numeric data types
        //are memory fatties

        public float ScreenSize { get; set; }
        //This is the screen size property, and is a float

        public int StorageCapacity { get; set; }
        //This is the storage capacity property, which is an int because all
        //of the storage capacities are whole numbers

        public Product(string name, float price, float screensize, int storagecapacity)
        //This method is used to set the variables declared here equal to their
        //equivalent properties within the class.
        {
            Name = name;
            Price = price;
            ScreenSize = screensize;
            StorageCapacity = storagecapacity;
        }
    }
}
