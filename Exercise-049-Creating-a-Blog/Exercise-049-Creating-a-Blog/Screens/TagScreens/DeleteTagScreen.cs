using Exercise_049_Creating_a_Blog.Models;
using Exercise_049_Creating_a_Blog.Repositories;
using System;

namespace Exercise_049_Creating_a_Blog.Screens.TagScreens
{
    class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Delete a tag");
            Console.WriteLine("-------------");
            Console.Write("What is the id of the tag you wish to exclude? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag successfully deleted!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not exclude the tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
