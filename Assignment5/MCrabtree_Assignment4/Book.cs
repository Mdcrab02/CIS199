using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCrabtree_Assignment4
{
    class Book
    //This creates the book class as specified in the
    //instructions.
    {
        public string callNumber { get; set; }

        public string bookTitle { get; set; }

        public string authorName { get; set; }

        public string genre { get; set; }

        public int numberOfPages { get; set; }

        public string publisher { get; set; }
        //This sets all the properties for my book class, again
        //as specified in the instructions.  I'm not sure why the
        //number of pages is an int, as we will be doing no
        //calculations with it, it should be a string just like the
        //call number.

        public Book(string acallNumber, string abookTitle, string anauthorName,
            string agenre, int anumberOfPages, string apublisher)
        {
            //This method sets all these class variables to their class
            //property equivalents.
            callNumber = acallNumber;
            bookTitle = abookTitle;
            authorName = anauthorName;
            genre = agenre;
            numberOfPages = anumberOfPages;
            publisher = apublisher;

        }

        public override string ToString()
        //This is the ToString method that will override the normal
        //ToString with what is listed here.  It could save some typing
        //were the form to contain a multiline text box, but I didn't
        //see the need to use this, it was just listed in the class diagram.
        //I ain't trying to miss any more points.
        {
            return "Call Number: " + callNumber + Environment.NewLine + "Title: "
                + bookTitle + Environment.NewLine + "Author: " + authorName +
                Environment.NewLine + "Genre: " + genre + Environment.NewLine +
                "Number of Pages: " + numberOfPages + Environment.NewLine +
                "Publisher: " + publisher;
            //This returns a formatted string of data that would be good for
            //a multiline text box.
        }
    }
}
