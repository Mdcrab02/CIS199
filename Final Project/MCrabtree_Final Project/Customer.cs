using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCrabtree_Final_Project
{
    class Customer
    {
        //Here I have set all the properties for the customer
        //class in my normal fashion.
        public string SSN { get; set; }

        public string customerName { get; set; }

        public string customerAddress { get; set; }

        public string customerCity { get; set; }

        public string customerState { get; set; }

        public string customerZIP { get; set; }

        public string customerPhone { get; set; }

        public string customerEmail { get; set; }

        public Bank_Account customerAccount { get; set; }

        public Customer(string aSSN, string acustomerName, string acustomerAddress,
            string acustomerCity, string acustomerState, string acustomerZIP,
            string acustomerPhone, string acustomerEmail)
            //and here is the constructor for those properties
        {
            SSN = aSSN;
            customerName = acustomerName;
            customerAddress = acustomerAddress;
            customerCity = acustomerCity;
            customerState = acustomerState;
            customerZIP = acustomerZIP;
            customerPhone = acustomerPhone;
            customerEmail = acustomerEmail;
            //customerAccount = abankAccount;
        }

        public Bank_Account AddAccount(double accountBalance)
        {
            //This is the method for adding a bank account
            //given a balance amount to be used in the form.
            if (accountBalance < 0)
            {
                throw new ArgumentOutOfRangeException("accountBalance");
                //This was my attempt at doing some fancy error
                //notification, which became more trouble than it was
                //worth.
            }

            if (accountBalance == 0)
            {
                accountBalance = 100;
            }

            Bank_Account newBankAccount = new Bank_Account(this, accountBalance,
                DateTime.Now, 200, 0);
            //This is the code that instantiates a new bank account.
            //this is done after the above checks are performed

            customerAccount = newBankAccount;

            return newBankAccount;
        }

        public void Deposit(double amount)
        {
            //This is the method that processes a deposit from
            //information entered into the GUI
            if (customerAccount == null)
            {
                throw new ArgumentNullException("account");
                //again, tried to be fancy here
            }

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("amount");
                //same here
            }
            customerAccount.accountBalance += amount;
            //This adds the balance entered to the customer's
            //existing bank account balance
        }

        public void Withdrawl(double amount)
        {
            //This is the method that processes a withdrawal
            //, which is misspelled I now realize...
            if (customerAccount == null)
            {
                throw new ArgumentNullException("account");
                //these were for error checking, but I ended
                //up putting that into the form.  This one
                //is if the user has no account selected.
            }

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("amount");
                //this one is for if the amount entered is less
                //than or equal to zero
            }

            if (customerAccount.accountBalance < amount)
            {
                throw new BusinessRuleException("Insufficient funds");
                //this one is if the user tried to withdraw
                //more than is in the account.
            }
            customerAccount.accountBalance -= amount;
            //otherwise subtract it from the account balance.
        }

        public void WriteCheck(double amount)
        {
            this.Withdrawl(amount);
            customerAccount.numberOfChecks--;
            //This is for writing checks.  Since it works
            //the same way as the withdrawal method, I used
            //this.withdrawl(amount) to tell it to call from
            //this class the withdrawl method with the amount
            //given in the gui.  it also subtracts one check.

        }
    }
}
