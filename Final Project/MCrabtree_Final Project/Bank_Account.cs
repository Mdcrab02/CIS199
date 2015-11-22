using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCrabtree_Final_Project
{
    class Bank_Account
    {
        //these are the properties for the Bank_Account
        //class
        public string accountNumber { get; set; }

        public double accountBalance { get; set; }

        public DateTime dateAcctOpened { get; set; }

        public int numberOfChecks { get; set; }

        public double interestEarnings { get; set; }

        public Customer customer { get; set; }

        public List<DateTime> MontlyFeeDates { get; set; }

        public Bank_Account(Customer aCustomer, double anaccountBalance,
            DateTime adateAcctOpened, int anumberOfChecks, double aninterestEarnings)
            //a wild constructor appears!
        {
            customer = aCustomer;
            accountBalance = anaccountBalance;
            dateAcctOpened = adateAcctOpened;
            numberOfChecks = anumberOfChecks;
            interestEarnings = aninterestEarnings;

            accountNumber = Guid.NewGuid().ToString();
            //this says that the account number property
            //is to be given a random, application generated,
            //and unique ID which is then passed to a string
            //at the beginning to put it into text boxes

            MontlyFeeDates = new List<DateTime>();
            //This was going the be used to see if the user
            //had already applied fees this month, but again
            //it became a lot more time consuming than estimated
            //dat scope creep
        }

        public void ProcessInterest()
        {
            //This method processes the interest for the accounts
            //and the interest amount depends on the balance currently
            //in the account.
            double interest;

            if (accountBalance <= 0)
            {
                throw new InvalidOperationException("Account balance must be greater than zero.");
            }

            if (accountBalance >= 1 && accountBalance <= 999)
            {
                interest = 0.05;
            }
            else if (accountBalance >= 1000 && accountBalance <= 9999)
            {
                interest = 0.08;
            }
            else if (accountBalance >= 10000 && accountBalance <= 19999)
            {
                interest = 0.17;
            }
            else
            {
                interest = 0.24;
            }

            interestEarnings += (accountBalance * interest);

            accountBalance += interestEarnings;
        }

        //public void ApplyMonthlyFee()
        //{
        //    var currentDate = DateTime.Now;

        //    if (!AppliedFee(currentDate))
        //    {
        //        accountBalance -= 15;
        //    }
        //}

        //public bool AppliedFee(DateTime date)
        //{
        //    var appliedThisMonth = false;

        //    foreach (var feeDates in this.MontlyFeeDates)
        //    {
        //        if (feeDates.Month == date.Month && feeDates.Year == date.Year)
        //        {
        //            appliedThisMonth = true;
        //            break;
        //        }
        //    }

        //    return appliedThisMonth;
        //}
    }
}
