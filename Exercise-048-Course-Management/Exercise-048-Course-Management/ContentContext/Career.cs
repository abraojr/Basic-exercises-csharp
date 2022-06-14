using System.Collections.Generic;

namespace Exercise_048_Course_Management.ContentContext
{
    public class Career : Content
    {
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count; // Expression body




        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();
        }
    }
}
