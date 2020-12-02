using System;

namespace Exercise_025_Class_person
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read the data of two people, then show the name of the oldest person.*/

            Person p1, p2;
            p1 = new Person();
            p2 = new Person();

            Console.WriteLine("First person's data: ");
            Console.Write("Name: ");
            p1.Name = Console.ReadLine();
            Console.Write("Age: ");
            p1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Second person's data:");
            Console.Write("Name: ");
            p2.Name = Console.ReadLine();
            Console.Write("Age: ");
            p2.Age = int.Parse(Console.ReadLine());

            if (p1.Age > p2.Age)
                Console.WriteLine("The oldest person is: " + p1.Name);
            else
                Console.WriteLine("The oldest person is: " + p2.Name);
        }
    }
}
