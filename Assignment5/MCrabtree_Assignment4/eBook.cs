using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCrabtree_Assignment4
{
    class eBook:Book
    {
        public double fileSize { get; set; }
        //Here is the property that is associated with an ebook
        //but not a regular book.


        public eBook(string acallNumber, string abookTitle, string anauthorName,
            string agenre, int anumberOfPages, string apublisher, double aFileSize)
            :base(acallNumber, abookTitle, anauthorName, agenre, anumberOfPages, apublisher)
        //Now here we have all of the ebook's properties set in the
        //constructor and we are passing in all of the variables from
        //the parent class, book.
        {
            fileSize = aFileSize;
        }

        public string FileSize {get; set;}

        public override string ToString()
        //This is the ToString method that replaces the standard
        //ToString with what we specify.
        {
 	         return base.ToString();
        }
    }
}
