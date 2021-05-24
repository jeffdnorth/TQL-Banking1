using System;

namespace TQL_Banking1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // HOMEWORK  2 part constructor
            //var cd1 = new CertificateOfDeposit(Amount: 1000, Months: 12);
            //above is passing in amount of dep and # of months it will be in the cd
            //cd1.Deposit(1); and more

            */
            var sav1 = new Savings();
            sav1.Deposit(1000);
            sav1.PayInterest(3);
            Console.WriteLine($"Balance Savings is {sav1.Balance}");

            var acct1 = new Account();
            acct1.Deposit(500);
            acct1.Withdraw(200);
            acct1.Withdraw(600);
            acct1.Deposit(-400);
            Console.WriteLine($"Balance of Account 1 is {acct1.Balance}");

            var acct2 = new Account();
            acct1.Transfer(1000, acct2);
            Console.WriteLine($"Balance of Account 1 is {acct1.Balance}");
            Console.WriteLine($"Balanceof Account 2 is {acct2.Balance}");
        }
    }
}
