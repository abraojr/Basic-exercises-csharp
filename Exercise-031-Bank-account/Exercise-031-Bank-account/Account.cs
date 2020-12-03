using System.Globalization;

namespace Exercise_031_Bank_account
{
    class Account
    {
        public static int Tax = 5;
        public string Name { get; set; }
        public int AccountNumber { get; private set; }
        public double Balance { get; private set; }



        public Account(string name, int accountNumber)
        {
            Name = name;
            AccountNumber = accountNumber;
        }
        public Account(string name, int accountNumber, double initialDeposit) : this(name, accountNumber)
        {
            AddToAccount(initialDeposit);
        }
        public void AddToAccount(double quantity)
        {
            Balance += quantity;
        }
        public void WithdrawMoney(double quantity)
        {
            Balance = (Balance - Tax) - quantity;
        }

        public override string ToString()
        {
            return "Account " + AccountNumber + ", Holder: " + Name + ", Balance: U$ " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
