using Exercise_049_Creating_a_Blog.Models;
using Exercise_049_Creating_a_Blog.Repositories;
using System;

namespace Exercise_049_Creating_a_Blog.Screens.TagScreens
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("New tag");
            Console.WriteLine("-------------");
            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Tag
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Create(tag);
                Console.WriteLine("Tag successfully registered!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to save tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
