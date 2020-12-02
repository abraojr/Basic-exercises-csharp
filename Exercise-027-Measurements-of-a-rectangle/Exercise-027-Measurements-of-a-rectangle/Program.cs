using System;
using System.Globalization;

namespace Exercise_027_Measurements_of_a_rectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Make a program to read the values of the width and height of a rectangle. Then show the value of your area,
             * perimeter and diagonal on the screen.*/

            Rectangle A;
            A = new Rectangle();


            Console.WriteLine("Enter the width and height of the rectangle: ");
            A.Widht = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaRect = A.Area();
            double perRect = A.Perimeter();
            double diagRect = A.Diagonal();

            Console.WriteLine("AREA: " + areaRect.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRER: " + perRect.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + diagRect.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
