using System;

namespace MySupperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Shadab",10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);
        }
    }
}
