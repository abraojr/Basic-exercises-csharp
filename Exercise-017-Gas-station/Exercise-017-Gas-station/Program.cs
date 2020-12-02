using System;

namespace Exercise_017_Gas_station
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A gas station wants to determine which of its products is preferred by its customers.
             *Write an algorithm to read the type of fuel supplied (coded as follows: 1.Alcohol 2.Gasoline 3.Diesel 4.Exit). 
             *If the user enters an invalid code (outside the range of 1 to 4), a new code must be requested (until it is valid).
             *The program will end when the code entered is number 4. The message: "THANK YOU VERY MUCH" and the number of customers
             *who supplied each type of fuel must be written.*/

            int alcohol = 0;
            int gasoline = 0;
            int diesel = 0;
            Console.Write("Enter the fuel type: ");
            int x = int.Parse(Console.ReadLine());


            while (x != 4)
            {
                if (x == 1)
                {
                    alcohol++;
                    Console.Write("Enter the fuel type: ");
                }

                else if (x == 2)
                {
                    gasoline++;
                    Console.Write("Enter the fuel type: ");
                }

                else if (x == 3)
                {
                    diesel++;
                    Console.Write("Enter the fuel type: ");
                }
                else if (x <= 0 || x > 4)
                {
                    Console.Write("Invalid code, enter a valid code: ");
                }
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("THANK YOU VERY MUCH");
            Console.WriteLine("ALCOHOL: " + alcohol);
            Console.WriteLine("GASOLINE: " + gasoline);
            Console.WriteLine("DIESEL: " + diesel);
        }
    }
}
