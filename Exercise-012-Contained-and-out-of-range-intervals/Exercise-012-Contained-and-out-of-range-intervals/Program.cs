using System;
using System.Globalization;

namespace Exercise_012_Contained_and_out_of_range_intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program that reads a value and displays a message saying which of the following intervals
            * ([0.25], (25.50], (50.75], (75,100]) this value is in. Obviously if the value is not is in any of these ranges,
            * the message “Out of range” should be printed.*/

            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (0 <= x && x <= 25)
                Console.WriteLine("It's in the range [0,25]");
            else if (25 < x && x <= 50)
                Console.WriteLine("It's in the range [25,50]");
            else if (50 < x && x <= 75)
                Console.WriteLine("It's in the range [50,75]");
            else if (75 < x && x <= 100)
                Console.WriteLine("It's in the range [75,100]");
            else
                Console.WriteLine("Out of range");
        }
    }
}
