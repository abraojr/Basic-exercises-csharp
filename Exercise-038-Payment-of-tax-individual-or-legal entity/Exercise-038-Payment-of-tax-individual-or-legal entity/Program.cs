using Exercise_038_Payment_of_tax_individual_or_legal_entity.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercise_038_Payment_of_tax_individual_or_legal_entity
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read the data of N taxpayers (N provided by the user), which can be an individual or a company, and then show the amount of
             *tax paid by each, as well as the total tax collected.The data of individuals are: name, annual income and health expenditures. The data of 
             *legal entity are name, annual income and number of employees. The rules for tax calculation are as follows:
             *Individual: people whose income was below U$ 20000.00 pay 15% tax. People with income from U$ 20000.00 onwards pay 25% tax. If the person had
             *health expenses, 50% of these expenses are deducted from the tax.
             *Example: a person whose income was U$ 50000.00 and had U$ 2000.00 in health expenses, the tax stays: (50000 * 25%) - (2000 * 50%)= U$ 11500.00 
             *Legal entity: legal entities pay 16% tax. However, if the company has more than 10 employees, it pays 14% tax.
             *Example: a company whose income was U$ 400000.00 and has 25 employees, the tax is: 400000 * 14% = U$ 56000.00*/

            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: U$ ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: U$ ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(healthExpenditures, name, anualIncome));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int emp = int.Parse(Console.ReadLine());
                    list.Add(new Company(emp, name, anualIncome));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer payer in list)
            {
                Console.WriteLine(payer.Name + " : U$ " + payer.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
            double sum = 0;
            foreach (TaxPayer payer in list)
            {
                sum += payer.Tax();
            }
            Console.WriteLine("TOTAL TAXES: U$ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
