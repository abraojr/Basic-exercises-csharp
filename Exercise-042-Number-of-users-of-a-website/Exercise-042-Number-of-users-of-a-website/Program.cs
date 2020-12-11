using Exercise_042_Number_of_users_of_a_website.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise_042_Number_of_users_of_a_website
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A website registers a log of users' access. A log record consists of the user name and the instant the user accessed the site in the ISO 8601
             *standard, separated by space.Make a program that reads the access log from a file, and then inform how many different users have accessed the site.*/

            HashSet<LogRecord> set = new HashSet<LogRecord>();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(" ");
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord() { Username = name, Instant = instant });
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred:");
                Console.WriteLine(e.Message);
            }
            /*INPUT FILE:                                                  OUTPUT:
             * amanda 2020-08-26T20:45:08                                 Total Users: 4
             *alex86 2020-08-26T21:49:37
             *bobbrown 2020-08-27T03:19:13
             *amanda 2020-08-27T08:11:00
             *jeniffer3 2020-08-27T09:19:24
             *alex86 2020-08-27T22:39:52
             *amanda 2020-08-28T07:42:19*/
        }
    }
}
