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
    }
}
