using Exercise_049_Creating_a_Blog.Models;
using Exercise_049_Creating_a_Blog.Repositories;
using System;

namespace Exercise_049_Creating_a_Blog.Screens.TagScreens
{
    public static class ListTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Tag List");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Tag>(Database.Connection);
            var tags = repository.Get();
            foreach (var item in tags)
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
        }
    }
}
