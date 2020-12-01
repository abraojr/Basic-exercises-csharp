using System;

namespace Exercise_015_Password_reader
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that repeats reading a password until it is valid. For each incorrect password reading entered,
             * write an "Invalid password" message. When the password for correct information must be printed the message "Access Allowed" 
             * and the algorithm terminated. Consider that the correct password is the 2002 value.*/

            Console.Write("Enter a password: ");
            int password = int.Parse(Console.ReadLine());
            while (password != 2002)
            {
                Console.WriteLine("Invalid password");
                Console.Write("Enter a password:");
                password = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acess Allowed");

        }
    }
}
