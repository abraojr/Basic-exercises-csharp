using System;
using System.Globalization;

namespace Exercise_041_Contract_process_automation.Entities
{
    class Installment
    {
        public DateTime DueTime { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueTime, double amount)
        {
            DueTime = dueTime;
            Amount = amount;
        }
        public override string ToString()
        {
            return DueTime.ToString("dd/MM/yyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
