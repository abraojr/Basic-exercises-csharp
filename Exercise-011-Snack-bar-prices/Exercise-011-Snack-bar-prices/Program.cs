using System;
using System.Globalization;

namespace Exercise_011_Snack_bar_prices
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Based on the table below, write a program that reads the code of an item and the quantity of this item. Then calculate
            * and show the amount of the account payable.
            CODE         SPECIFICATION          PRICE
              1           Hot dog              U$ 4,00
              2           X-Salad              U$ 4,50    
              3           X-Bacon              U$ 5,00 
              4           Simple toast         U$ 2,00 
              5           Soda                 U$ 1,50 */

            string[] vect = Console.ReadLine().Split(' ');
            int code = int.Parse(vect[0]);
            int quantity = int.Parse(vect[1]);

            double amountToPay = 0.0;
            if (code == 1)
                amountToPay = quantity * 4.0;
            else if (code == 2)
                amountToPay = quantity * 4.5;
            else if (code == 3)
                amountToPay = quantity * 5.0;
            else if (code == 4)
                amountToPay = quantity * 2.0;
            else
                amountToPay = quantity * 1.5;

            Console.WriteLine("Total:U$ " + amountToPay.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
