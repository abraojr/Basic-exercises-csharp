using System;

namespace Exercise_032_Renting_a_pension
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] vect = new Student[10];
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Student { Name = name, Email = email };
                Console.WriteLine();
            }
            Console.WriteLine("Busy Rooms: ");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {

                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
