using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCrabtree_Assignment4
{
    class Library
    //This class is just like it says, a Library.
    //Just like a real library, it contains books.
    //Object-oriented programming
    {
        public List<Book> mybooks { get; set; }

        public Library()
        {
            mybooks = new List<Book>();
        }

        public bool CallNumberExists(string callnumber)
        //This method is used to take the logic of checking
        //for duplicate call numbers out of the form, which is
        //quickly turning into a gaggle.
        {
            foreach (Book book in mybooks)
            //this goes through each book in the list mybooks
            {
                if (book.callNumber == callnumber)
                //if the call number already exists in the list
                {
                    return true;
                    //then the boolean is then made true
                }
            }
            return false;
            //otherwise, it is false.
        }
    }
}
