using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var daniBankAccount = new BankAccount();

            daniBankAccount.Deposit(1000);
            Console.WriteLine(daniBankAccount.GetBalance());
        }
    }
}
