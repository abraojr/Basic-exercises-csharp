using System;

namespace Exercise_032_Renting_a_pension
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The owner of a boarding house has ten rooms to rent for students, these rooms being identified by the numbers 0 to 9.When 
             *a student wants to rent a room, one must register the name and email of this student.Make a program that starts with all ten 
             *empty rooms, and then read an N amount representing the number of students that will rent rooms (N can be from 1 to 10).Then, 
             *register the N students' rent. For each rental registration, inform the name and email of the student, as well as which of the 
             *rooms he chose (from 0 to 9). Suppose a vacant room is chosen.At the end, your program must print a report of all occupations of
             *the boarding house, in order of room*/

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
