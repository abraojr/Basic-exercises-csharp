using Exercise_045_Average_products_price.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Exercise_045_Average_products_price
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read a set of products from a file in .csv format (suppose there is at least one product).Then show the average price of 
             *the products. After this, show the names, in descending order, of the products that have lower price than the average price.*/

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    double price = double.Parse(line[1], CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }
            }
            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price: U$ " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
        /*INPUT FILE:                                 OUTPUT:
         * Tv,900.00                           Average price: U$ 420.23
         * Mouse,50.00                         Tablet
         * Tablet,350.50                       Mouse
         * HD Case,80.90                       Monitor
         * Computer,850.00                     HD Case
         * Monitor,290.00                                             */
    }
}
