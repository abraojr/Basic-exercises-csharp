using System;

namespace Exercise_022_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Read a N. value. Calculate and write your respective factorial. Factorial of N = N * (N-1) * (N-2) * (N-3) * ... * 1.
             *Remembering that, by definition, a factorial of 0 is 1.*/

            int N = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= N; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
