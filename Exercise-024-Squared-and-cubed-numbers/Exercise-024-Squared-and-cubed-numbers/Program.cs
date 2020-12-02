using System;

namespace Exercise_024_Squared_and_cubed_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read a positive integer N. The program should then show on the screen N lines,
             * starting from 1 to N. For each line, show the line number, then the square and the value cube.*/


            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                double n1 = Math.Pow(i, 2.0);
                double n2 = Math.Pow(i, 3.0);
                Console.WriteLine("{0} {1} {2}", i, n1, n2);
            }
        }
    }
}
