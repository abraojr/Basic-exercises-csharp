using Exercise_036_Order_summary.Entities;
using Exercise_036_Order_summary.Entities.Enums;
using System;
using System.Globalization;

namespace Exercise_036_Order_summary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Read the data of an order with N items (N provided by the user). Then, show a summary of the order. 
             * Note: the request instant should be the system instant: DateTime.Now*/

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            DateTime moment = DateTime.Now;
            Client client = new Client(name, email, birthDate);


            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order?");
            int n = int.Parse(Console.ReadLine());

            Order order = new Order(moment, status, client);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: U$ ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product p = new Product(productName, productPrice);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantity, productPrice, p);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
