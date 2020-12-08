using Exercise_039_Bank_account_with_exception_handling.Entities;
using Exercise_039_Bank_account_with_exception_handling.Entities.Exceptions;
using System;
using System.Globalization;

namespace Exercise_039_Bank_account_with_exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read the data of a bank account and then make a withdrawal in this bank account, showing the new balance. A withdrawal cannot
             *occur either if there is no balance in the account, or if the amount of the withdrawal is greater than the account withdrawal limit.*/

            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: U$ ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: U$ ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                Account acc = new Account(number, holder, balance, withdrawLimit);

                Console.Write("Enter amount for withdraw: U$ ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.Withdraw(amount);
                Console.WriteLine(acc);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format exception: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
