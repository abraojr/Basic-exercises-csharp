using System;

namespace Exercise_027_Measurements_of_a_rectangle
{
    class Rectangle
    {
        public double Widht;
        public double Height;

        public double Area()
        {
            return Widht * Height;
        }
        public double Perimeter()
        {
            return 2 * Widht + 2 * Height;
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Widht, 2.0) + Math.Pow(Height, 2.0));
        }

    }
}
