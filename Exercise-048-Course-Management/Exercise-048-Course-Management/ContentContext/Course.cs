using Exercise_048_Course_Management.ContentContext.Enums;
using System.Collections.Generic;

namespace Exercise_048_Course_Management.ContentContext
{
    public class Course : Content
    {
        public string Tag { get; set; }
        public int DurationInMinutes { get; set; }
        public IList<Module> Modules { get; set; }
        public EContentLevel Level { get; set; }

        public Course(string title, string url) : base(title, url)
        {
            Modules = new List<Module>();
        }
    }
}
