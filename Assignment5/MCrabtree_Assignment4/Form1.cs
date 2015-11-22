/*Assignment 5: Library 2.0
 * Author: Mike Crabtree
 * Class: CIS199-01
 * Purpose:  This program will allow the user to add books
 * to his library, see the details for each book and search
 * for books in his library given certain criteria.  This
 * program will also allow the user to add ebooks to the
 * library.
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
        //private Book aBook;

        public Form1()
        {
           InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (myLibrary.CallNumberExists(txtCallAdd.Text) == true)
            //This calls the CallNumberExists method from the Library class
            //which returns a bool
            //and checks it with the data entered in the call number txtbox.
            {
                MessageBox.Show("That call number already exists.");
                txtCallAdd.Focus();
                //If the call number exists already, then bring up a message box
                //and let the user know what's up as well as put the focus on that
                //text box
            }
            else
            {
            //If that checks out, move on to the rest of the program.
                int pageHolder = 0;
                int callholder = 0;
                double sizeholder = 0;

                //Two local variables used in error checking to make sure both the
                //page number and call number are indeed numbers


                try
                {
                    if (string.IsNullOrWhiteSpace(txtAuthorAdd.Text) || string.IsNullOrWhiteSpace(txtCallAdd.Text)
                        || string.IsNullOrWhiteSpace(txtGenreAdd.Text) || string.IsNullOrWhiteSpace(txtPagesAdd.Text)
                        || string.IsNullOrWhiteSpace(txtPubAdd.Text) || string.IsNullOrWhiteSpace(txtTitleAdd.Text))
                    //This is a really rough way of making sure all the textboxes
                    //have something in them
                    //Now that I think about it, if i had an array of textboxes this wouldn't
                    //be necessary
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
                    else if (pageHolder >= 9000)
                    {
                        MessageBox.Show("Over 9000?  Your scouter must be broken!");
                        txtPagesAdd.Focus();
                        //If the user tries to say that the book has more than 9000 pages
                        //tell him to check again.
                    }
                    else
                    {
                        if (chkEbookAdd.Checked == false)
                        {
                            //If all this checks out, add the book to the library
                            Book newbook = new Book(txtCallAdd.Text, txtTitleAdd.Text, txtAuthorAdd.Text,
                                txtGenreAdd.Text, int.Parse(txtPagesAdd.Text), txtPubAdd.Text);
                            //Create a new book based on the information given in the text
                            //boxes
                            myLibrary.mybooks.Add(newbook);
                            //myLibrary.mybooks.Add(newbook);
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
                            txtEbookAdd.Clear();
                            chkEbookAdd.Checked = false;

                            txtAuthorAdd.Focus();
                            //set the focus on the first text box

                            PopulateBooks();
                            //Run the method that updates the lbox on the second
                            //tab so information is updated in real time

                        }
                        if (chkEbookAdd.Checked == true)
                        //if the user checks the ebook checkbox, then run some
                        //input value as it relates to ebooks.
                        {
                            if (!double.TryParse(txtEbookAdd.Text, out sizeholder))
                            //If the user tries to enter something that isn't a number
                            {
                                MessageBox.Show("File size must be a number...");
                                txtEbookAdd.Focus();
                                //Show a message box and then put the focus on that text box
                            }
                            else if ((sizeholder <= 0) || (sizeholder >= 10000))
                            //if the user enters a value at 0 or below, or above 10,000MB
                            {
                                MessageBox.Show("The file size must be greater than 0 and less than 10GB");
                                txtEbookAdd.Focus();
                                //Show a messagebox and put the focus on that text box.
                            }
                            else if (string.IsNullOrWhiteSpace(txtEbookAdd.Text))
                            //if the user enters nothing in the text box
                            {
                                MessageBox.Show("You must enter a non zero value for file size.");
                                txtEbookAdd.Focus();
                                //Show a messagebox and put the focus on that text box.
                            }
                            else
                            {
                                Book newbook = new eBook(txtCallAdd.Text, txtTitleAdd.Text, txtAuthorAdd.Text,
                                    txtGenreAdd.Text, int.Parse(txtPagesAdd.Text), txtPubAdd.Text, double.Parse(txtEbookAdd.Text));
                                myLibrary.mybooks.Add(newbook);
                                //This adds a new ebook of type book (because ebook is a child
                                //class of Book and that's what inheritance is all about) and
                               //instantiates it with all of the properties of Book with the
                                //addition of the property for ebook.

                                //Display "book added" message box
                                MessageBox.Show("Book Added to Library!");

                                //Clear fields
                                txtAuthorAdd.Clear();
                                txtCallAdd.Clear();
                                txtGenreAdd.Clear();
                                txtPagesAdd.Clear();
                                txtPubAdd.Clear();
                                txtTitleAdd.Clear();
                                txtEbookAdd.Clear();
                                chkEbookAdd.Checked = false;
                                //uncheck the check box

                                txtAuthorAdd.Focus();
                                //set the focus on the first text box

                                PopulateBooks();
                                //Run the method that updates the lbox on the second
                                //tab so information is updated in real time
                            }

                        }

                    }
                }
                catch
                {
                    MessageBox.Show("An error occurred, please try again.");
                    //Just in case a non-specified error occurs
                }
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

                var book = GetABook(lboxView.SelectedIndex);
                //This runs the selected index from the lbox through the GetABook
                //Method and makes it a variable named book.

                if (book is eBook)
                //if the variable book is an eBook, that is if it has the properties
                //of an eBook
                {
                    var ebook = (eBook)book;
                    //then our book in question is now made an ebook (which is a type
                    //of book) so that we can use the filesize property for the
                    //text box.

                    txtSizeView.Text = ebook.fileSize.ToString();
                    //display the file size in the text box as a string.
                }
                else
                {
                    txtSizeView.Clear();
                    //Otherwise, clear the text box (just in case there was something
                    //there.
                }
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
            //I could also add a for loop with a counter to make sure that the
            //user only hits the search button once, otherwise an error
            //message box pops up.
            try
            {
                if (lboxSearch.SelectedIndex != -1)
                {
                    txtAuthorSearch.Text = SearchABook(lboxSearch.SelectedIndex).authorName;
                    txtCallSearch.Text = SearchABook(lboxSearch.SelectedIndex).callNumber.ToString();
                    txtGenreSearch.Text = SearchABook(lboxSearch.SelectedIndex).genre;
                    txtPagesSearch.Text = SearchABook(lboxSearch.SelectedIndex).numberOfPages.ToString();
                    txtPubSearch.Text = SearchABook(lboxSearch.SelectedIndex).publisher;
                    txtTitleSearch.Text = SearchABook(lboxSearch.SelectedIndex).bookTitle;
                    //again this just updates the text boxes with the information
                    //depending on the index selected which is associated with a book.

                    var book = SearchABook(lboxSearch.SelectedIndex);
                    //This runs the selected index from the lbox through the SearchABook
                    //Method and makes it a variable named book.
                    if (book is eBook)
                    //if the variable book is an eBook, that is if it has the properties
                    //of an eBook
                    {
                        var ebook = (eBook)book;
                        //then our book in question is now made an ebook (which is a type
                        //of book) so that we can use the filesize property for the
                        //text box.

                        txtSizeSearch.Text = ebook.fileSize.ToString();
                        //display the file size in the text box as a string.
                    }
                    else
                    {
                        txtSizeSearch.Clear();
                        //Otherwise, clear the text box (just in case there was something
                        //there.
                    }
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
            txtSizeSearch.Clear();
            //This clears everything on the search page, the third tab,
            //and I have verified that the searchResults list is cleared
            //and at the end of this holds no data, but the lbox and
            //selected index still hold data, which I suspect points to
            //the GetABook method and how it is used to populate the 
            //textboxes.  AGAIN, I would like to do something about it
            //but I'm out of time.
        }

        private void chkEbookAdd_CheckStateChanged(object sender, EventArgs e)
        {
            //This is my event that will make the lbl and txt for the
            //ebook's filesize visible only if the user tells the form
            //that the book being entered is an ebook.
            if (chkEbookAdd.Checked == true)
            {
                txtEbookAdd.Visible = true;
                lblSizeAdd.Visible = true;
            }
            else
            {
                txtEbookAdd.Visible = false;
                lblSizeAdd.Visible = false;
            }
        }
    }
}
