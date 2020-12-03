using System;
using System.Globalization;

namespace Exercise_031_Bank_account
{
    class Program
    {
        static void Main(string[] args)
        {
            /* In order to register a bank account, it is necessary to inform the account number, the name of the account holder, and the initial
             *deposit amount that the holder deposited when opening the account. This initial deposit amount, however, is optional, that is: 
             *if the holder has no money to deposit at the time of opening his account, the initial deposit will not be made and the initial 
             *balance of the account will, of course, be zero.
             * Important: once a bank account has been opened, the account number can never be changed. The holder's name can be changed (because
             *a person can change his or her name at a wedding, for example).
             * Finally, the account balance cannot be freely changed. There must be a mechanism to protect this. The balance only increases through
             *deposits, and only decreases through withdrawals.For each withdrawal made, the bank charges a fee of U$ 5.00. Note: the account may
             *be left with a negative balance if the balance is not sufficient to make the withdrawal and/or pay the fee.
             * You must make a program that performs the registration of an account, giving the option to be informed or not the initial deposit 
             *amount. Then, make a deposit and then a withdrawal, always showing the account data after each operation.*/

            Account account;

            Console.Write("Enter the account number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter the account holder: ");
            string name = Console.ReadLine();
            Console.Write("Will there be an initial deposit(y/n)? ");
            char answer = char.Parse(Console.ReadLine());

            if (answer == 'y' || answer == 'Y')
            {
                Console.Write("Enter an initial deposit amount: U$ ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new Account(name, number, initialDeposit);
                Console.WriteLine();

                Console.WriteLine("Account data: ");
                Console.WriteLine(account);
                Console.WriteLine();
            }
            else
            {
                account = new Account(name, number);
                Console.WriteLine();

                Console.WriteLine("Account data: ");
                Console.WriteLine(account);
                Console.WriteLine();
            }

            Console.Write("Enter a deposit amount: U$ ");
            double postDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.AddToAccount(postDeposit);

            Console.WriteLine("Updated account data: ");
            Console.WriteLine(account);
            Console.WriteLine();

            Console.Write("Enter a withdrawal amount: U$ ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.WithdrawMoney(withdraw);

            Console.WriteLine("Updated account data: ");
            Console.WriteLine(account);
        }
    }
}
