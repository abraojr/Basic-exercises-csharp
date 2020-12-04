using System;

namespace Exercise_034_Negative_values_of_a_matrix
{
    class Program
    {
        /*Make a program to read an integer N and an N order matrix containing integers. Then show the main diagonal and the amount of negative 
         *values of the matrix.*/

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matrix[i, i] + "  ");
            }
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < 0)
                        count++;
                }
            }
            Console.WriteLine("Negative numbers: " + count);
        }
    }
}
