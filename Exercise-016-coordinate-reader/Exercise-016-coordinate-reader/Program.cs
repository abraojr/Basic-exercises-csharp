using System;

namespace Exercise_016_coordinate_reader
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read the coordinates (X, Y) of an undetermined number of points in the Cartesian system.
             * For each point, write the quadrant to which it belongs. The algorithm will be terminated when at least one
             * of the two coordinates is NULL (in this situation without writing any message).*/

            string[] vect = Console.ReadLine().Split(' ');
            int x = int.Parse(vect[0]);
            int y = int.Parse(vect[1]);
            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("First");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Second");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Third");
                }
                else
                {
                    Console.WriteLine("Fourth");
                }
                vect = Console.ReadLine().Split(' ');
                x = int.Parse(vect[0]);
                y = int.Parse(vect[1]);

            }
        }
    }
}
