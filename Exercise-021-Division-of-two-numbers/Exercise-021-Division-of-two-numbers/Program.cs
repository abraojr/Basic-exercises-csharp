using System;
using System.Globalization;

namespace Exercise_021_Division_of_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read a number N. Then read N pairs of numbers and show the division of the first by the second.
             * If the denominator is equal to zero,  show the message "Impossible division".*/

            int N = int.Parse(Console.ReadLine());


            for (int i = 1; i <= N; i++)
            {
                string[] vect = Console.ReadLine().Split(' ');
                double n1 = double.Parse(vect[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(vect[1], CultureInfo.InvariantCulture);

                if (n2 == 0)
                {
                    Console.WriteLine("Impossible division");
                }
                else
                {
                    double result = (double)n1 / n2;
                    Console.WriteLine("Result: " + result.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
        }
    }
}
