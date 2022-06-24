using Exercise_049_Creating_a_Blog.Models;
using Exercise_049_Creating_a_Blog.Repositories;
using System;

namespace Exercise_049_Creating_a_Blog.Screens.TagScreens
{
    public static class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Updating a tag");
            Console.WriteLine("-------------");
            Console.Write("Id: ");
            var id = Console.ReadLine();

            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Tag
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Update(tag);
                Console.WriteLine("Tag successfully updated!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to update tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
