using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    class BankAccount
    {

        private double balance = 0;
        private string name;
        private int age;
        private string accountType;
        private string cosignerName;

        
        public void Greeting()
        {
            Console.WriteLine("Welcome to Wells Fargo! \nEnter 1 if you are an existing member. \nEnter 2 if you'd like to set up a new account.");
            int selection = int.Parse(Console.ReadLine());
            if(selection == 1)
            {
                Console.WriteLine("Enter 1 if you'd like to make a deposit. \nEnter 2 if you'd like to make a withdrawal. \n" +
                    "Enter 3 if you'd like to view your current balance.");
                int nextAction = int.Parse(Console.ReadLine());
                switch(nextAction)
                {
                    case 1:
                        Deposit();
                        break;
                    case 2:
                        Withdrawal();
                        break;
                    case 3:
                        GetBalance();
                        break;
                }
  
            }
            else
            {
                OpenAccount();
            }
        }
        
        public void OpenAccount()
        {
            Console.WriteLine("We have a few questions to determine which account types you qualify for!");
            Console.WriteLine("To start with, what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("...............................................................................................");
            
            Console.WriteLine($"Welcome {name}, how old are you?");
            age = int.Parse(Console.ReadLine());

            if(age >= 18)
            {
                Console.WriteLine("You qualify for a standard checking account");
                accountType = "Standard";
            }
            else
            {
                Console.WriteLine("You qualify for a youth checking account");
                accountType = "Youth";
                AssignCoSigner();
            }

            Console.WriteLine("In order to set up your account, we'll need an initail deposit of at least $5.");
            
            Deposit();

        }

        public void Deposit()
        {
            Console.WriteLine("How much would you like to deposit today?");
            double amount = int.Parse(Console.ReadLine());
            balance += amount;
            Console.WriteLine("Your deposit has been made");

        }

        public double GetBalance()
        {
            return balance;
        }

        public void Withdrawal()
        {
            Console.WriteLine("How much would you like to withdrawal today?");
            int withdrawalAmount = int.Parse(Console.ReadLine());
            if (withdrawalAmount <= balance)
            {
                balance -= withdrawalAmount;
                Console.WriteLine("Your withdrawal has been made.");

            }
            else
            {
                Console.WriteLine("Your withdrawal amount exceeds your account balance.");
            }
        }

        public void AssignCoSigner()
        {
            Console.WriteLine("Our youth accounts require a cosigner who is 18 years old or older.\n What is your cosigner's name?");
            cosignerName = Console.ReadLine();
        }

    }
}
