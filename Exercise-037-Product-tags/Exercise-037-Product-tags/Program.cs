using Exercise_037_Product_tags.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercise_037_Product_tags
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read the data of N products (N provided by the user). At the end, show the price tag of each product in the same order 
             *they were typed.Every product has name and price. Imported products have a customs fee, and used products have a manufacturing date. These
             *specific data must be added to the price tag.For imported products, the customs fee must be added to the final price of the product.*/

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: U$ ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (ch == 'i')
                {
                    Console.Write("Custom fee: U$ ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customFee));
                }
                else if (ch == 'u')
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product p in list)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
