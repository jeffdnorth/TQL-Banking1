using System;
using System.Collections.Generic;
using System.Text;

namespace TQL_Banking1
{//using inheritence, Child : Parent
    class Savings : Account
    { 
        //addl properties
         public decimal InterestRate { get; set; } = 0.01m;
        //create method
         public decimal CalculateInterestByMonths (int NumberOfMonths)
        {    /*interest = balance * (InterestRate/12) * NumberOfMonths; 
             * the amount the earn on the set number of of months
             * and we need to change the balance   */
        return Balance * (InterestRate / 12.0m) * NumberOfMonths;
        }
         public void  PayInterest(int NumberOfMonths)
         {
            var interest = CalculateInterestByMonths(NumberOfMonths);
            Deposit(interest);
         }
    }
}
