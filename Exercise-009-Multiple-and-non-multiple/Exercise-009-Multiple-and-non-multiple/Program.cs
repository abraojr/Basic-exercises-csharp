using System;

namespace Exercise_009_Multiple_and_non_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Read 2 integer values (A and B). Then, the program should display the message "Are multiple" or "Are not multiple",
             * indicating whether the values read are multiple with each other. Attention: numbers must be entered 
             * ascending or descending order.*/

            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("They are multiple!");
            }
            else
            {
                Console.WriteLine("They're not multiple!");
            }
        }
    }
}
