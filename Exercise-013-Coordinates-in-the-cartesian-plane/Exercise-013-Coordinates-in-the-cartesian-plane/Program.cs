using System;
using System.Globalization;

namespace Exercise_013_Coordinates_in_the_cartesian_plane
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Read 2 values with one decimal place (x and y), which must represent the coordinates of a point on a plane.
             * Next, determine which quadrant the point belongs to, or whether it is on one of the Cartesian axes or at the 
             * origin (x = y = 0). If the point is at the origin, write the message “Origin”.
             * If the point is on one of the axes, write “Axis X” or “Axis Y”, depending on the situation.*/

            string[] vect = Console.ReadLine().Split(' ');
            double X = double.Parse(vect[0], CultureInfo.InvariantCulture);
            double Y = double.Parse(vect[1], CultureInfo.InvariantCulture);

            if (X > 0 && Y > 0)
                Console.WriteLine("Q1");
            else if (X < 0 && Y > 0)
                Console.WriteLine("Q2");
            else if (X < 0 && Y < 0)
                Console.WriteLine("Q3");
            else if (X > 0 && Y < 0)
                Console.WriteLine("Q4");
            else if ((X > 0 || X < 0) && Y == 0)
                Console.WriteLine("Axis X");
            else if ((Y > 0 || Y < 0) && X == 0)
                Console.WriteLine("Axis Y");
            else
                Console.WriteLine("Origin");
        }
    }
}
