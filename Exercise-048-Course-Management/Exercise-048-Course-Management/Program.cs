using Exercise_048_Course_Management.ContentContext;
using Exercise_048_Course_Management.SubscriptionContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_048_Course_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Article about OOP", "object-oriented"));
            articles.Add(new Article("Article about C#", "csharp"));
            articles.Add(new Article("Article about .NET", "dotnet"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var courses = new List<Course>();
            var courseOOP = new Course("OOP basics", "oop-basics");
            var courseCsharp = new Course("C# basics", "csharp-basics");
            var courseAspNet = new Course("ASP.NET basics", "aspnet-basics");
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotnet = new Career(".NET Expert", "dotnet-expert");
            var careerItem1 = new CareerItem(1, "Start here", "", courseCsharp);
            var careerItem2 = new CareerItem(3, "Learn OOP", "", courseOOP);
            var careerItem3 = new CareerItem(2, "Learn .NET", "", courseAspNet);
            careerDotnet.Items.Add(careerItem1);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.Write(career.Title);

                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.Write($"{item.Order} - {item.Title}\n");
                    Console.Write($"{item.Course?.Title}\n");
                    Console.Write($"{item.Course?.Level}\n");

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }

                var payPalSubscription = new PayPalSubscription();
                var student = new Student();

                student.CreateSubscription(payPalSubscription);
            }
        }
    }
}
