using System;

namespace Exercise_007_Positive_or_negative_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read an integer and tell if that number is negative or not.*/
            int x = int.Parse(Console.ReadLine());

            if (x >= 0)
                Console.WriteLine("NON-NEGATIVE");
            else
                Console.WriteLine("NEGATIVE");
        }
    }
}
