using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCrabtree_Final_Project
{
    class Bank
    {
        //these are properties for the bank class.
        //just like a library has books a bank has bank accounts
        //which are tied to customers.
        public List<Customer> customers { get; set; }

        public List<Bank_Account> bankAccounts { get; set; }

        public Bank()
            //here is the constructor.
        {
            customers = new List<Customer>();
            bankAccounts = new List<Bank_Account>();
        }

        public Customer CreateCustomer(string aSSN, string acustomerName, string acustomerAddress,
            string acustomerCity, string acustomerState, string acustomerZIP,
            string acustomerPhone, string acustomerEmail)
            //this method creates a customer with the parameters given
            //using information supplied from the GUI and adds that
            //customer to the list of customers in the bank
        {
            Customer customer = new Customer(aSSN, acustomerName, acustomerAddress,
            acustomerCity, acustomerState, acustomerZIP,
            acustomerPhone, acustomerEmail);

            customers.Add(customer);

            return customer;
        }
    }
}
