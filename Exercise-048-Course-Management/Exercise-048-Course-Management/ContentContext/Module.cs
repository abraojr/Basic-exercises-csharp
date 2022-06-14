using System.Collections.Generic;

namespace Exercise_048_Course_Management.ContentContext
{
    public class Module
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }

        public Module()
        {
            Lectures = new List<Lecture>();
        }
    }
}
