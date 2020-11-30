using System;
using System.Globalization;

namespace Exercise_005_Value_of_a_piece
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read the code of a part 1, the number of parts 1, the unit value of each part 1, the 
             * part 2 code, the number of parts 2 and the unit value of each part 2.Calculate and show the amount to be paid*/

            string[] vet1 = Console.ReadLine().Split(' ');
            int codePart1 = int.Parse(vet1[0]);
            int numberPart1 = int.Parse(vet1[1]);
            double valuePart1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            int codePart2 = int.Parse(vet2[0]);
            int numberPart2 = int.Parse(vet2[1]);
            double valuePart2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double amountToPay = (valuePart1 * numberPart1) + (valuePart2 * numberPart2);

            Console.WriteLine("AMOUNT TO PAY: $" + amountToPay.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
