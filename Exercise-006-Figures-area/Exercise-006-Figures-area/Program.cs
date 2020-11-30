using System;
using System.Globalization;

namespace Exercise_006_Figures_area
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program that reads three double precision floating point values: A, B and C.Then, calculate and  show:
             * a) the area of the rectangle triangle with A as the base and C as the height.
             * b) the area of the circle of radius C. (pi = 3.14159)
             * c) the trapezoid area that has A and B for bases and C for height.
             * d) the area of the square with side B.
             * e) the area of the rectangle that has sides A and B.*/

            string[] vet = Console.ReadLine().Split(' ');
            float A = float.Parse(vet[0], CultureInfo.InvariantCulture);
            float B = float.Parse(vet[1], CultureInfo.InvariantCulture);
            float C = float.Parse(vet[2], CultureInfo.InvariantCulture);

            double aTriangle, aCircle, aTrapezoid, aSquare, aRectangle, pi = 3.14159;

            aTriangle = (A * C) / 2;
            aCircle = pi * (Math.Pow(C, 2.0));
            aTrapezoid = ((A + B) * C) / 2;
            aSquare = B * B;
            aRectangle = A * B;


            Console.WriteLine("Triangle Area: " + aTriangle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Circle Area: " + aCircle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezoid Area: " + aTrapezoid.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Square Area: " + aSquare.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Rectangle Area: " + aRectangle.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
