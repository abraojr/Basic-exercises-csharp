using System;

namespace Exercise_018_Odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Read an integer value X (1 <= X <= 1000). Then show the odd numbers from 1 to X, one value per line, including the 
             * X, if applicable.*/

            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
