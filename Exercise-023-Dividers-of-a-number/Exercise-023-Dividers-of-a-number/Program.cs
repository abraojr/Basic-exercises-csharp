using System;

namespace Exercise_023_Dividers_of_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Read an integer N and calculate all of its divisors.*/

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
