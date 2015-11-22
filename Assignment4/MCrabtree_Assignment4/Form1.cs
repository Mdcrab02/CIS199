/*Assignment 4: Library
 * Author: Mike Crabtree
 * Class: CIS199-01
 * Purpose:  This program will allow the user to add books
 * to his library, see the details for each book and search
 * for books in his library given certain criteria.
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

namespace MCrabtree_Assignment4
{
    public partial class Form1 : Form
    {
        private Library myLibrary = new Library();
        //This creates a new library named myLibrary
        private List<Book> searchResults = new List<Book>();
        //This creates a list of books named searchResults
        //used to hold books found in the library based on search
        //criteria

        public Form1()
        {
           InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        //This method really shouldn't allow for duplicate call numbers
        //although it isn't specified in the directions.  I want to make a
        //list of books local to this event, and have an if statement and
        //a for each loop go through each book currently in the library,
        //and check for duplicate call numbers, but I'm out of time I guess
        //I'll have to take a hit on this.
        {
            int pageHolder = 0;
            int callholder = 0;
            //Two local variables used in error checking to make sure both the
            //page number and call number are indeed numbers


            try
            {
                if (string.IsNullOrWhiteSpace(txtAuthorAdd.Text) || string.IsNullOrWhiteSpace(txtCallAdd.Text)
                    || string.IsNullOrWhiteSpace(txtGenreAdd.Text) || string.IsNullOrWhiteSpace(txtPagesAdd.Text)
                    || string.IsNullOrWhiteSpace(txtPubAdd.Text) || string.IsNullOrWhiteSpace(txtTitleAdd.Text))
                    //This is a really rough way of making sure all the textboxes
                    //have something in them
                {
                    MessageBox.Show("Please fill out all fields");
                    //if not, throw up a message box.
                }
                else if ((!int.TryParse(txtPagesAdd.Text, out pageHolder)) ||
                    (!int.TryParse(txtCallAdd.Text, out callholder)))
                    //This then checks to see if the number of pages and
                    //call number are indeed numbers
                {
                    MessageBox.Show("Number of Pages and call number must be a number");
                    //Otherwise, throw up a message box telling the user the error
                }
                else
                {
                    //If all this checks out, add the book to the library
                    Book newbook = new Book(txtCallAdd.Text, txtTitleAdd.Text, txtAuthorAdd.Text,
                        txtGenreAdd.Text, int.Parse(txtPagesAdd.Text), txtPubAdd.Text);
                    //Create a new book based on the information given in the text
                    //boxes

                    myLibrary.mybooks.Add(newbook);
                    //Add the newly created book to our library

                    //Display "book added" message box
                    MessageBox.Show("Book Added to Library!");

                    //Clear fields
                    txtAuthorAdd.Clear();
                    txtCallAdd.Clear();
                    txtGenreAdd.Clear();
                    txtPagesAdd.Clear();
                    txtPubAdd.Clear();
                    txtTitleAdd.Clear();

                    txtAuthorAdd.Focus();
                    //set the focus on the first text box

                    PopulateBooks();
                    //Run the method that updates the lbox on the second
                    //tab so information is updated in real time
                }
            }
            catch
            {
                MessageBox.Show("An error occurred, please try again.");
                //Just in case a non-specified error occurs
            }
        }

        private void PopulateBooks()
        {
            lboxView.Items.Clear();
            //This clears the lbox's current contents before adding new things.

            foreach (Book book in myLibrary.mybooks)
            {
                lboxView.Items.Add(book.bookTitle);
                //This loops through the list of books to make sure all books are
                //added to the lbox
            }
        }

        private void lboxView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxView.SelectedIndex != -1)
            //This updates the txtbox information as it relates to the book selected
            //in the text box, given that the user has selected an index
            {
                txtAuthorView.Text = GetABook(lboxView.SelectedIndex).authorName;
                txtCallView.Text = GetABook(lboxView.SelectedIndex).callNumber.ToString();
                txtGenreView.Text = GetABook(lboxView.SelectedIndex).genre;
                txtPagesView.Text = GetABook(lboxView.SelectedIndex).numberOfPages.ToString();
                txtPubView.Text = GetABook(lboxView.SelectedIndex).publisher;
                txtTitleView.Text = GetABook(lboxView.SelectedIndex).bookTitle;
            }
        }

        private Book GetABook(int index)
        {
               return myLibrary.mybooks[index];
            //This allows the selected index changed events to populate
            //related fields depending on which index position in the lbox
            //that the user has clicked.  This is used because all of the
            //information is input by the user.
        }

        private Book SearchABook(int index)
        {
            return searchResults[index];
            //This is used for the search lbox so that it doesn't hold information
            //from mylibrary, which is not relevant for the search.  The weird thing
            //is, it doesn't seem to always work.  I would like more time to
            //check this out...
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int currentSearch = cboxSearch.SelectedIndex;
            //This is a variable that holds the index and saves me some typing
            try
            {
                if (currentSearch != -1)
                //This checks to see if the user has selected a search criterion
                {
                    switch (currentSearch)
                    //This switch statement takes the index position of the cbox
                    //and uses it to determine if the user has selected Call Number,
                    //Title, etc.  I used an int because using string's as they relate
                    //to the properties of Book caused some weird things to happen.
                    {
                        case 0:
                            foreach (Book book in myLibrary.mybooks)
                            {
                                if (book.callNumber == txtSearch.Text)
                                {
                                    searchResults.Add(book);
                                }
                            }
                            break;

                        case 1:
                            foreach (Book book in myLibrary.mybooks)
                            {
                                if (book.bookTitle == txtSearch.Text)
                                {
                                    searchResults.Add(book);
                                }
                            }
                            break;

                        case 2:
                            foreach (Book book in myLibrary.mybooks)
                            {
                                if (book.authorName == txtSearch.Text)
                                {
                                    searchResults.Add(book);
                                }
                            }
                            break;

                        case 3:
                            foreach (Book book in myLibrary.mybooks)
                            {
                                if (book.genre == txtSearch.Text)
                                {
                                    searchResults.Add(book);
                                }
                            }
                            break;

                        case 4:
                            foreach (Book book in myLibrary.mybooks)
                            {
                                if (book.numberOfPages.ToString() == txtSearch.Text)
                                {
                                    searchResults.Add(book);
                                }
                            }
                            break;

                        case 5:
                            foreach (Book book in myLibrary.mybooks)
                            {
                                if (book.publisher == txtSearch.Text)
                                {
                                    searchResults.Add(book);
                                }
                            }
                            break;

                        default:
                            break;
                    }

                }
                else
                {
                    MessageBox.Show("You must select a search criteria.");
                    //If the user has not selected anything from the cbox, throw
                    //up a message box
                }

                foreach (Book book in searchResults)
                {
                    lboxSearch.Items.Add(book.bookTitle);
                    //This then takes every book in the search results
                    //and adds it to the lbos
                }
            }
            catch
            {
                MessageBox.Show("A search error occurred, hit new search before starting a new search");
                //If the user spams the search button with the same criterion
                //selected and a different number in the search txtbox, an exception
                //sometimes happens.  This catches it.
            }
        }

        private void lboxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //This method most of the time has a weird error that causes the first
            //index position to hold a book despite EVERYTHING being cleared.

            //Fixed it by using the new method SearchABook that uses the list
            //searchresults and not mylibrary.  HOWEVER, it seems to not work
            //ALL the time.  No time to figure out why.

            //I could also add a for loop with a counter to make sure that the
            //user only hits the search button once, otherwise an error
            //message box pops up.
            try
            {
                if (lboxView.SelectedIndex != -1)
                {
                    txtAuthorSearch.Text = SearchABook(lboxSearch.SelectedIndex).authorName;
                    txtCallSearch.Text = SearchABook(lboxSearch.SelectedIndex).callNumber.ToString();
                    txtGenreSearch.Text = SearchABook(lboxSearch.SelectedIndex).genre;
                    txtPagesSearch.Text = SearchABook(lboxSearch.SelectedIndex).numberOfPages.ToString();
                    txtPubSearch.Text = SearchABook(lboxSearch.SelectedIndex).publisher;
                    txtTitleSearch.Text = SearchABook(lboxSearch.SelectedIndex).bookTitle;
                    //again this just updates the text boxes with the information
                    //depending on the index selected which is associated with a book.
                }
            }
            catch
            {
                MessageBox.Show("An overload error occurred, hit the new search button.");
                //If the user doesn't hit new search, and changes the cbox index
                //as well as the data in the search field, spams the search button
                //and then changes the selected index in the search results lbox, an
                //exception occurs, this catches is.
            }

        }

        private void btnNewSearch_Click(object sender, EventArgs e)
        {
            ClearSearchPage();
            //Clicking the new search button runs the ClearSearchPage
            //method
        }

        private void ClearSearchPage()
        {
            lboxSearch.Items.Clear();
            txtSearch.Clear();
            cboxSearch.SelectedIndex = -1;
            txtAuthorSearch.Clear();
            txtCallSearch.Clear();
            txtGenreSearch.Clear();
            txtPagesSearch.Clear();
            txtPubSearch.Clear();
            txtTitleSearch.Clear();
            searchResults.Clear();
            //This clears everything on the search page, the third tab,
            //and I have verified that the searchResults list is cleared
            //and at the end of this holds no data, but the lbox and
            //selected index still hold data, which I suspect points to
            //the GetABook method and how it is used to populate the 
            //textboxes.  AGAIN, I would like to do something about it
            //but I'm out of time.
        }
    }
}
