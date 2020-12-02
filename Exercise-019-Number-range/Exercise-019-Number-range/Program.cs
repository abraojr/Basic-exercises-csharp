using System;

namespace Exercise_019_Number_range
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Read an integer N. This value will be the amount of integer X values that will be read next. 
             *Show how many of these X values are in the range [10,20] and how many are out of the range, showing this information
             *as an example (use the word "in" for inside the range, and "out" for outside the range).*/
            Console.Write("Enter a number of values to be entered next: ");
            int n1 = int.Parse(Console.ReadLine());
            int _in = 0;
            int _out = 0;
            for (int i = 1; i <= n1; i++)
            {
                Console.Write($"Value #{i}: ");
                int x = int.Parse(Console.ReadLine());
                if (x < 10 ^ x <= 20)
                {
                    _in++;
                }
                else
                {
                    _out++;
                }
            }
            Console.WriteLine("{0} in", _in);
            Console.WriteLine("{0} out", _out);
        }
    }
}
