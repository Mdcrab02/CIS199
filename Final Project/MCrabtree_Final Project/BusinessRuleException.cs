using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCrabtree_Final_Project
{
    public class BusinessRuleException : Exception
    {
        //This class was going to be used to format
        //my own error messages in a more professional
        //manner, but again scope creep can cause these
        //projects to take an increasingly longer amount
        //of time at an increasing rate.
        public BusinessRuleException(string message)
            : base(message)
        {
        }
    }
}
