using System;
using System.Globalization;

namespace Exercise_030_Currency_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read the dollar quotation, and then a dollar amount to be bought by a person in Reais. 
             *Inform how many Reais the person will pay for the dollars, also considering that the person will have to pay 6% IOF
             *on the dollar amount*/

            Console.Write("What is the dollar quote? ");
            double quotation = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("How many dollars will you buy? U$ ");
            double dollar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = CurrencyConverter.Convert(quotation, dollar);

            Console.WriteLine("Amount to be paid in Reais: R$ " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
