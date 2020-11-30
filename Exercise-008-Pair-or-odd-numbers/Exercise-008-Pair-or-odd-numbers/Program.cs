using System;

namespace Exercise_008_Pair_or_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read an integer and tell if the number is pair or odd.*/
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
                Console.WriteLine("PAIR");
            else
                Console.WriteLine("ODD");

        }
    }
}
