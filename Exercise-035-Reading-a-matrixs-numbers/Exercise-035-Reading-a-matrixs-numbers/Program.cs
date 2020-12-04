using System;

namespace Exercise_035_Reading_a_matrixs_numbers
{
    class Program
    {
        /*Make a program to read two integers M and N, and then read an array of M rows by N columns containing integers, there may be repetitions.
         *Then read an integer X that belongs to the matrix. For each occurrence of X, show the values to the left, above, right and below X, when
         *there is one.*/

        static void Main(string[] args)
        {
            string[] var = Console.ReadLine().Split(' ');
            int m = int.Parse(var[0]);
            int n = int.Parse(var[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + ", " + j + " :");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
