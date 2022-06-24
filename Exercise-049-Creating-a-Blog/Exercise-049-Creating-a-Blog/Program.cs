using Microsoft.Data.SqlClient;
using System;
using Exercise_049_Creating_a_Blog.Screens.TagScreens;

namespace Exercise_049_Creating_a_Blog
{
    public class Program
    {
        private const string CONNECTION_STRING = @"Data Source=localhost,1433; Database=Blog; User ID=sa; Password=SenhaDoSA123; Encrypt=False";
        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Console.ReadKey();
            Database.Connection.Close();

        }

        private static void Load()
        {
            Console.Clear();
            Console.WriteLine("My Blog");
            Console.WriteLine("-----------------");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("1 - User Management");
            Console.WriteLine("2 - Profile Management");
            Console.WriteLine("3 - Category Management");
            Console.WriteLine("4 - Tag Management");
            Console.WriteLine("5 - Link profile/user");
            Console.WriteLine("6 - Link post/tag");
            Console.WriteLine("7 - Reports");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 4:
                    MenuTagScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
