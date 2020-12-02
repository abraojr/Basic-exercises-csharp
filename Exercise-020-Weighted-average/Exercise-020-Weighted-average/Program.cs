using System;
using System.Globalization;

namespace Exercise_020_Weighted_average
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Read 1 integer value N, which represents the number of test cases that follow. Each test case consists of 3 real values,
             * each with one decimal place. Present the weighted average for each of these sets of 3 values, with the first value having weight 2,
             * the second value having weight 3 and the third value having weight 5.*/

            int n1 = int.Parse(Console.ReadLine());
            double average = 0;

            for (int i = 1; i <= n1; i++)
            {
                string[] vect = Console.ReadLine().Split(' ');
                double grade1 = double.Parse(vect[0], CultureInfo.InvariantCulture);
                double grade2 = double.Parse(vect[1], CultureInfo.InvariantCulture);
                double grade3 = double.Parse(vect[2], CultureInfo.InvariantCulture);
                average = (grade1 * 2 + grade2 * 3 + grade3 * 5) / 10;

                Console.WriteLine("WEIGHTED AVERAGE: " + average.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
