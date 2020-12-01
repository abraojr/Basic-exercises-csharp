using System;
using System.Globalization;

namespace Exercise_014_Income_tax
{
    class Program
    {
        static void Main(string[] args)
        {
            /*In an imaginary country called Lisarb, all the inhabitants are happy to pay their taxes, as they know 
             * there are no corrupt politicians and the funds raised are used for the benefit of the population, without 
             * any deviation. The currency of this country is Rombus, whose symbol is R$.
             * Read a value to two decimal places, equivalent to the salary of a person from Lisarb. Then calculate and 
             * show the amount that this person must pay Income Tax, according to the table below.
                    INCOME                   INCOME TAX
             from 0.00 to R$ 2000.00           Exempt       
             from 2000.01 to R$ 3000.00           8%
             from 3000.01 to R$ 4500.00          18% 
             above R$ 4500.00                    28%
            
             Remember that, if the salary is R$ 3002.00, the tax that is levied is 8% only on R $ 1000.00, since the salary
             range between R $ 0.00 and R$ 2000.00 is exempt from Income Tax. In the example provided (below), the tax is 8% on
             R $ 1000.00 + 18% on R $ 2.00, which results in R$ 80.36 in total. The value must be printed with two decimal places.*/

            Console.Write("Enter your salary: R$ ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double incomeTax = 0.0;

            /*Income tax formula: (salary-maxSalary) * fee, if the person receives more than 4500 --->
             * income tax = (salary-maxSalary) * 0.28 + (0.18 * (4500-3000)) + (0.08 (3000-2000))*/

            if (salary <= 2000)
            {
                Console.WriteLine("Exempt");
            }
            else if (salary <= 3000)
            {
                incomeTax = (salary - 2000) * 0.08;
                Console.WriteLine("R${0}", incomeTax.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salary <= 4500)
            {
                incomeTax = (salary - 3000) * 0.18 + 1000 * 0.08;
                Console.WriteLine("R${0}", incomeTax.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                incomeTax = (salary - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
                Console.WriteLine("R${0}", incomeTax.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
