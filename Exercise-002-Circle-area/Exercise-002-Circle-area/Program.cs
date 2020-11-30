using System;
using System.Globalization;

namespace Exercise_002_Circle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read the radius value of a circle, and then show the area value of this circle with four decimal places . 
             Area formula: area = π.radius ^ 2
             Consider the value of π = 3.14159 */

            Console.Write("Enter a radius value: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area = pi * (Math.Pow(radius, 2.0));

            Console.WriteLine("Circle area: " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
