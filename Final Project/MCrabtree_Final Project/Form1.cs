/*Final Project: Cardinal Bank
 * Class: CIS199-01
 * Purpose:  This program will allow the user to process
 * customer information, add customer accounts to the bank,
 * search for those customers, view statistics, edit customer
 * information, and process financial activities. 
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

namespace MCrabtree_Final_Project
{
    public partial class Form1 : Form
    {
        private List<Customer> searchResults = new List<Customer>();
        private List<Bank_Account> searchResultsAccount = new List<Bank_Account>();

        private Bank myBank = new Bank();
        //private Bank_Account myBankAccount = new Bank_Account();

        public double searchAverage = 0;
        private int customerCount = 0;

        public Form1()
        {
            InitializeComponent();
            //indevelopment = true;
            chkEdit.Visible = false;
            btnCommitEdit.Enabled = false;

            //if (indevelopment)
            //{
            //    txtAddressAdd.Text = "Cherokee Road";
            //    txtBalanceAdd.Text = "1500";
            //    txtCityAdd.Text = "Louisville";
            //    txtEmailAdd.Text = "name@gmail.com";
            //    txtNameAdd.Text = "Dlo Gubnuh";
            //    txtPhoneAdd.Text = "5023329653";
            //    txtSSNAdd.Text = "666666666";
            //    txtStateAdd.Text = "KY";
            //    txtZipAdd.Text = "40350";
            //}

            this.SetupProcessCustomerActions();
            //this calls the SetupProcessCustomerActions
            //method to make sure that buttons are kept disabled
            //when the user has not selected a customer.
        }

        //bool indevelopment;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //This is to add a customer and his information and
            //account to the bank.  I added all the error checking
            //I could think of to keep the user from crashing
            //the application.  Although it is a little rickety
            //I declared some new local variables as part of this
            //error checking.
            try
            {
                double amount;
                double phoneNumber;
                int socialNumber;
                int zipNumber;

                if(string.IsNullOrWhiteSpace(txtAddressAdd.Text)||
                    string.IsNullOrWhiteSpace(txtBalanceAdd.Text)||
                    string.IsNullOrWhiteSpace(txtCityAdd.Text)||
                    string.IsNullOrWhiteSpace(txtEmailAdd.Text)||
                    string.IsNullOrWhiteSpace(txtNameAdd.Text)||
                    string.IsNullOrWhiteSpace(txtPhoneAdd.Text)||
                    string.IsNullOrWhiteSpace(txtSSNAdd.Text)||
                   string.IsNullOrWhiteSpace(txtStateAdd.Text)||
                    string.IsNullOrWhiteSpace(txtZipAdd.Text))
                {
                    MessageBox.Show("Please fill out all fields");
                }
                else if (!int.TryParse(txtZipAdd.Text, out zipNumber))
                {
                    MessageBox.Show("Zip code can only contain numbers");
                    txtZipAdd.Focus();
                }
                else if (!double.TryParse(txtPhoneAdd.Text, out phoneNumber))
                {
                    MessageBox.Show("Please enter a real phone number.");
                    txtPhoneAdd.Focus();
                }
                else if (!int.TryParse(txtSSNAdd.Text, out socialNumber))
                {
                    MessageBox.Show("Social Security number must be a number.");
                    txtSSNAdd.Focus();
                }
                else if (!double.TryParse(txtBalanceAdd.Text, out amount))
                {
                    MessageBox.Show("Account balance must be numbers only.");
                    txtBalanceAdd.Focus();
                }
                else if (amount < 100)
                {
                    MessageBox.Show("The minimum starting balance is $100.");
                    txtBalanceAdd.Focus();
                }
                else
                {
                    Customer customer = myBank.CreateCustomer(txtSSNAdd.Text, txtNameAdd.Text,
                    txtAddressAdd.Text, txtCityAdd.Text, txtStateAdd.Text, txtZipAdd.Text,
                    txtPhoneAdd.Text, txtEmailAdd.Text);
                    customer.AddAccount(amount);
                    MessageBox.Show("Customer created!");
                    ClearAddPage();
                    PopulateCustomerList();
                }
            }
            catch
            {
                MessageBox.Show("An error occurred, please try again.");
                //I tend to add try catch blocks outside of normal
                //error checking just in case I missed something.
            }
        }

        private void ClearAddPage()
        {
            //one method to clear them all...
            //well on the Add tab, anyway
            txtAddressAdd.Clear();
            txtBalanceAdd.Clear();
            txtCityAdd.Clear();
            txtEmailAdd.Clear();
            txtNameAdd.Clear();
            txtPhoneAdd.Clear();
            txtSSNAdd.Clear();
            txtStateAdd.Clear();
            txtZipAdd.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAddPage();
        }

        private void PopulateCustomerList()
        {
            //This method keeps all the list boxes up to date
            //with the latest list of customers and their
            //information.
            lboxView.Items.Clear();
            lboxEdit.Items.Clear();
            lboxProcess.Items.Clear();
            foreach (Customer customer in myBank.customers)
            {
                lboxView.Items.Add(customer.customerName);
                lboxEdit.Items.Add(customer.customerName);
                lboxProcess.Items.Add(customer.customerName);
            }
        }

        private Customer GetACustomer(int index)
        {
            return myBank.customers[index];
        }

        private void lboxView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //like all the selected index changed events, this
            //populates the text boxes with the appropriate user
            //information.
            try
            {
                if (lboxView.SelectedIndex != -1)
                {
                    Customer customer = GetACustomer(lboxView.SelectedIndex);

                    txtAddressView.Text = customer.customerAddress;
                    txtCityView.Text = customer.customerCity;
                    txtEmailView.Text = customer.customerEmail;
                    txtNameView.Text = customer.customerName;
                    txtPhoneView.Text = customer.customerPhone;
                    txtSSNView.Text = customer.SSN;
                    txtStateView.Text = customer.customerState;
                    txtZipView.Text = customer.customerZIP;

                    txtAccountView.Text = customer.customerAccount.accountNumber;
                    txtBalanceView.Text = customer.customerAccount.accountBalance.ToString("c");
                    txtDateView.Text = customer.customerAccount.dateAcctOpened.ToShortDateString();
                }
            }
            catch
            {
                MessageBox.Show("An error occurred, please try again.");
            }
        }

        private void lboxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lboxEdit.SelectedIndex != -1)
                {
                    Customer customer = GetACustomer(lboxEdit.SelectedIndex);

                    txtAddressEdit.Text = customer.customerAddress;
                    txtCityEdit.Text = customer.customerCity;
                    txtEmailEdit.Text = customer.customerEmail;
                    txtNameEdit.Text = customer.customerName;
                    txtPhoneEdit.Text = customer.customerPhone;
                    txtSSNEdit.Text = customer.SSN;
                    txtStateEdit.Text = customer.customerState;
                    txtZipEdit.Text = customer.customerZIP;

                    //txtAccountEdit.Text = customer.customerAccount.accountNumber;
                    txtBalanceEdit.Text = customer.customerAccount.accountBalance.ToString("c");
                    txtDateEdit.Text = customer.customerAccount.dateAcctOpened.ToShortDateString();

                    chkEdit.Visible = true;
                    //if a customer is selected, the checkbox shows
                    //up in case the user wants to change some customer
                    //information
                }
                else
                {
                    chkEdit.Visible = false;
                    //otherwise there is no point in it being visible.
                }
            }
            catch
            {
                MessageBox.Show("An error occurred, please try again.");
            }
        }

        private void chkEdit_CheckedChanged(object sender, EventArgs e)
        {
            //this event is where the fields become enabled and
            //the user can change the information and save it.
            if (chkEdit.Checked == true)
            {
                txtNameEdit.ReadOnly = false;
                txtAddressEdit.ReadOnly = false;
                txtCityEdit.ReadOnly = false;
                txtEmailEdit.ReadOnly = false;
                txtPhoneEdit.ReadOnly = false;
                txtSSNEdit.ReadOnly = false;
                txtStateEdit.ReadOnly = false;
                txtZipEdit.ReadOnly = false;

                btnCommitEdit.Enabled = true;
            }
            else if (chkEdit.Checked == false)
            {
                txtNameEdit.ReadOnly = true;
                txtAddressEdit.ReadOnly = true;
                txtCityEdit.ReadOnly = true;
                txtEmailEdit.ReadOnly = true;
                txtPhoneEdit.ReadOnly = true;
                txtSSNEdit.ReadOnly = true;
                txtStateEdit.ReadOnly = true;
                txtZipEdit.ReadOnly = true;

                btnCommitEdit.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //This search event is just like the library.  A
            //switch statement for each index position in the combo
            //box and the appropriate code for each selection.
            int currentSearch = cboxSearch.SelectedIndex;

            switch (currentSearch)
            {
                case 0:
                    foreach (Customer customer in myBank.customers)
                    {
                        if (customer.customerZIP == txtSearch.Text)
                        {
                            searchResults.Add(customer);
                        }
                    }
                    break;

                case 1:
                    foreach (Customer customer in myBank.customers)
                    {
                        if (customer.customerCity == txtSearch.Text)
                        {
                            searchResults.Add(customer);
                        }
                    }
                    break;

                case 2:
                    foreach (Customer customer in myBank.customers)
                    {
                        if (customer.customerState == txtSearch.Text)
                        {
                            searchResults.Add(customer);
                        }
                    }
                    break;

                default:
                    break;
            }

            foreach (Customer customer in searchResults)
            {
                //this adds all relevant customers to the
                //list box.
                lboxSearch.Items.Add(customer.customerName);
            }

            PopulateSearchBox();
        }
        private void PopulateSearchBox()
        {
            //This is the method that takes all of the relevant
            //customers and averages their account balances
            //and displays that average in the text box.
            foreach (Customer customer in searchResults)
            {
                searchAverage += customer.customerAccount.accountBalance;
                customerCount++;
            }

            searchAverage = searchAverage / customerCount;

            txtAvgSearch.Text = searchAverage.ToString("c");
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //This is the event for processing a check.  It has
            //error checking and stuff.
            double checkAmount = 0;
            double checkTest = 0;
            Customer customer = GetACustomer(lboxProcess.SelectedIndex);
            try
            {
                if (lboxProcess.SelectedIndex != -1)
                {
                    if (!double.TryParse(txtCheckProcess.Text, out checkTest))
                    {
                        MessageBox.Show("Check amount must be a number.");
                    }
                    else if (checkTest > customer.customerAccount.accountBalance)
                    {
                        MessageBox.Show("Insufficient funds.");
                        txtCheckProcess.Focus();
                    }
                    else if (customer.customerAccount.numberOfChecks == 0)
                    {
                        MessageBox.Show("The customer has no more checks available.");
                        txtCheckProcess.Focus();
                    }
                        //Here I was trying for more bonus points but at
                        //this point I am running on fumes and need a break
                        //from C#, lol.

                        //if (result == DialogResult.Yes)
                        //{
                        //    checkAmount = double.Parse(txtCheckProcess.Text);

                        //    customer.WriteCheck(checkAmount);

                        //    MessageBox.Show("Check processed.");
                        //    ClearProcessPage();
                        //    PopulateCustomerList();
                        //}
                        //if (result == DialogResult.No)
                        //{
                        //    return;
                        //}

                        //checkAmount = double.Parse(txtCheckProcess.Text);

                        //customer.WriteCheck(checkAmount);

                        //MessageBox.Show("Check processed.");
                        //ClearProcessPage();
                        //PopulateCustomerList();
                    else
                    {
                        //Customer customer = GetACustomer(lboxProcess.SelectedIndex);
                        checkAmount = double.Parse(txtCheckProcess.Text);

                        customer.WriteCheck(checkAmount);

                        MessageBox.Show("Check processed.");
                        ClearProcessPage();
                        PopulateCustomerList();
                        if (customer.customerAccount.accountBalance < 100)
                        {
                            MessageBox.Show("All accounts under $100 are charged $15/mo.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select a customer first");
                }
            }
            catch
            {
                MessageBox.Show("An unknown error occurred, please try again.");
            }
        }

        private void btnCommitEdit_Click(object sender, EventArgs e)
        {
            //This is the event that saves the changes for
            //the customer information from the edit tab
            //it's a lot like the add tab and has similar
            //error checking and incident handling
            if (lboxEdit.SelectedIndex != -1)
            {
                double phoneNumber;
                int socialNumber;
                int zipNumber;
                Customer customer = GetACustomer(lboxEdit.SelectedIndex);

                try
                {
                    if (string.IsNullOrWhiteSpace(txtAddressEdit.Text) ||
                        string.IsNullOrWhiteSpace(txtCityEdit.Text) ||
                        string.IsNullOrWhiteSpace(txtEmailEdit.Text) ||
                        string.IsNullOrWhiteSpace(txtNameEdit.Text) ||
                        string.IsNullOrWhiteSpace(txtPhoneEdit.Text) ||
                        string.IsNullOrWhiteSpace(txtSSNEdit.Text) ||
                       string.IsNullOrWhiteSpace(txtStateEdit.Text) ||
                        string.IsNullOrWhiteSpace(txtZipEdit.Text))
                        //I bet this would be shorted if I made the boxes
                        //and array but I would still be typing everything
                        //out anyway.
                    {
                        MessageBox.Show("Please fill out all fields");
                    }
                    else if (!int.TryParse(txtZipEdit.Text, out zipNumber))
                    {
                        MessageBox.Show("Zip code can only contain numbers");
                        txtZipEdit.Focus();
                    }
                    else if (!double.TryParse(txtPhoneEdit.Text, out phoneNumber))
                    {
                        MessageBox.Show("Please enter a real phone number.");
                        txtPhoneEdit.Focus();
                    }
                    else if (!int.TryParse(txtSSNEdit.Text, out socialNumber))
                    {
                        MessageBox.Show("Social Security number must be a number.");
                        txtSSNEdit.Focus();
                    }
                    else
                    {
                        //Customer customer = GetACustomer(lboxEdit.SelectedIndex);

                        customer.customerName = txtNameEdit.Text;
                        customer.customerAddress = txtAddressEdit.Text;
                        customer.customerCity = txtCityEdit.Text;
                        customer.customerState = txtStateEdit.Text;
                        customer.customerZIP = txtZipEdit.Text;
                        customer.customerPhone = txtPhoneEdit.Text;
                        customer.customerEmail = txtEmailEdit.Text;
                        customer.SSN = txtSSNEdit.Text;

                        MessageBox.Show("Changes saved.");
                        txtNameEdit.Clear();
                        txtAddressEdit.Clear();
                        txtCityEdit.Clear();
                        txtStateEdit.Clear();
                        txtZipEdit.Clear();
                        txtPhoneEdit.Clear();
                        txtEmailEdit.Clear();
                        txtSSNEdit.Clear();
                        txtBalanceEdit.Clear();
                        txtDateEdit.Clear();

                        lboxEdit.SelectedIndex = -1;

                        chkEdit.Checked = false;
                    }
                }
                catch
                {
                    MessageBox.Show("An unknown error occurred, please try again.");
                }
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            //This is the event for processing a withdrawal.  I
            //added as much error handling as I could think of
            //and a trusty try catch block.
            double withdrawAmount = 0;
            double withdrawTest = 0;
            Customer customer = GetACustomer(lboxProcess.SelectedIndex);

            try
            {
                if (lboxProcess.SelectedIndex != -1)
                {

                    if (!double.TryParse(txtWithdrawProcess.Text, out withdrawTest))
                    {
                        MessageBox.Show("Withdraw amount must be a number.");
                    }
                    else if (withdrawTest > customer.customerAccount.accountBalance)
                    {
                        MessageBox.Show("Insufficient funds.");
                    }
                    else
                    {
                        //Customer customer = GetACustomer(lboxProcess.SelectedIndex);

                        //If everything checks out, process the withdrawal.
                        withdrawAmount = double.Parse(txtWithdrawProcess.Text);

                        customer.Withdrawl(withdrawAmount);

                        MessageBox.Show("Withdrawl processed.");
                        ClearProcessPage();
                        PopulateCustomerList();
                        if (customer.customerAccount.accountBalance < 100)
                        {
                            MessageBox.Show("All accounts under $100 are charged $15/mo.");
                            //Warn the user that the balance will fall below the minimum.
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Select a customer first.");
                }
            }
            catch
            {
                MessageBox.Show("An unknown error occurred, please try again.");
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //This event is for depositing money into accounts.
            //More error checking and more try/catch action.
            double depositAmount = 0;
            double depositTest = 0;
            Customer customer = GetACustomer(lboxProcess.SelectedIndex);

            try
            {
                if (lboxProcess.SelectedIndex != -1)
                {
                    if (!double.TryParse(txtDepositProcess.Text, out depositTest))
                    {
                        MessageBox.Show("Deposit amount must be a number.");
                    }
                    else
                    {
                        //Customer customer = GetACustomer(lboxProcess.SelectedIndex);

                        depositAmount = double.Parse(txtDepositProcess.Text);

                        customer.Deposit(depositAmount);

                        MessageBox.Show("Deposit processed.");
                        ClearProcessPage();
                        PopulateCustomerList();
                    }
                }
                else
                {
                    MessageBox.Show("Select a customer first.");
                }
            }
            catch
            {
                MessageBox.Show("An unknown error occurred, please try again.");
            }
        }

        private void ClearProcessPage()
        {
            //This method is for clearing the process page
            txtCheckProcess.Clear();
            txtDepositProcess.Clear();
            txtWithdrawProcess.Clear();
            lboxProcess.SelectedIndex = -1;
            btnProcess.Enabled = false;
            btnWithdraw.Enabled = false;
            btnDeposit.Enabled = false;
            btnInterest.Enabled = false;
            btnProcessFee.Enabled = false;
            //I had to add the buttons here because they
            //weren't disabling after processing!
        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            //This is the event to process interest for a selected
            //customer depending on how much is in the account, which
            //is all listed in the classes.
            try
            {
                if (lboxProcess.SelectedIndex != -1)
                {
                    Customer customer = GetACustomer(lboxProcess.SelectedIndex);

                    customer.customerAccount.ProcessInterest();

                    MessageBox.Show("Interest applied.");

                    ClearProcessPage();
                }
                else
                {
                    MessageBox.Show("Select a customer first.");
                }
            }
            catch
            {
                MessageBox.Show("An unknown error occurred, please try again.");
            }
        }

        private void lboxProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxProcess.SelectedIndex >= 0)
            {
                this.EnableProcessing();
            }
        }

        private void EnableProcessing()
        {
            this.btnProcess.Enabled = true;
            this.btnWithdraw.Enabled = true;
            this.btnDeposit.Enabled = true;
            this.btnInterest.Enabled = true;
            this.btnProcessFee.Enabled = true;
            //this is to make sure the buttons are enabled
            //only when needed
        }


        private void SetupProcessCustomerActions()
        {
            this.btnProcess.Enabled = false;
            this.btnWithdraw.Enabled = false;
            this.btnDeposit.Enabled = false;
            this.btnInterest.Enabled = false;
            this.btnProcessFee.Enabled = false;
            //otherwise they are not enabled.  Again more
            //use of this.____
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            //This resets the search page just in case the
            //user is looking for an "abort" button.
            lboxSearch.Items.Clear();
            cboxSearch.SelectedIndex = -1;
            txtAvgSearch.Clear();
            searchResults.Clear();
            txtSearch.Clear();
        }

        private void btnProcessFee_Click(object sender, EventArgs e)
        {
            //This is for tacking on a fee to a customer's
            //account.  It should only be used if the balance is below
            //100.  I tried adding some logic to make sure the user
            //cannot spam the fee button, and I wanted to have it check
            //with the dates but that became a mess.
            Customer currentCustomer = GetACustomer(lboxProcess.SelectedIndex);

            if(lboxProcess.SelectedIndex !=-1)
            {
                if (currentCustomer.customerAccount.accountBalance < 100)
                {
                    for (int count = 0; count == 1 ; count++)
                    {
                        currentCustomer.customerAccount.accountBalance -= 15;
                    }
                }
                else
                {
                    MessageBox.Show("Fee already applied.");
                }
            }
            else
            {
                MessageBox.Show("Select a customer first.");
            }
            //Below is what I tried to do for some fancy fee checkin'

            //var res = currentCustomer.customerAccount.AppliedFee(DateTime.Now);

            //if (!res)
            //{
            //    currentCustomer.customerAccount.ApplyMonthlyFee();
                
            //}
            //else
            //{
            //    MessageBox.Show("Already applied this month");
            //}

        }

    }
}

