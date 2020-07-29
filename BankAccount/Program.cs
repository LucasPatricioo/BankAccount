using BankAccount.Entities;
using BankAccount.Entities.Exceptions;
using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double iBalance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withDrawLimit = Convert.ToDouble(Console.ReadLine());
                Account account = new Account(number, holder, iBalance, withDrawLimit);

                Console.Write("\nEnter amount for withdraw: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                account.WithDraw(amount);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2"));
            }
            catch (DomainException e) {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
