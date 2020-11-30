using System;

namespace Exercise_001_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program that sums two integer numbers*/

            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            int sum = a + b;

            Console.WriteLine("SUM:" + sum);
        }
    }
}
