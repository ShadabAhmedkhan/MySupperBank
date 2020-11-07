using System;

namespace MySupperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Shadab",10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Number}");
        }
    }
}
