using System;
using System.Collections.Generic;
using System.Text;

namespace TQL_Banking1
//Use composition instead of inheritance to build class brining in account
{
    class Savings2
    {
    public Account account { get; set; }
        //method for deposit
     public bool Deposit(decimal amount)
        {
            return account.Deposit(amount);
        }
     public bool Withdraw(decimal amount)
        {
            return account.Withdraw(amount);
        }
        public bool  Transfer(decimal amount, Account toAccount)
        {
            return account.Transfer(amount, toAccount);
        }
    //constructor
    public Savings2()
        {
            account = new Account();
        }
    }
}
