using System;

namespace Exercise_003_Product_of_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read four integer values A, B, C and D. Then calculate and show the product difference of A and B by
             * the product of C and D according to the formula: DIFFERENCE = (A * B - C * D).*/
            int a, b, c, d, dif;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            dif = (a * b - c * d);
            Console.WriteLine("DIFFERENCE: " + dif);
        }
    }
}
