using Exercise_048_Course_Management.ContentContext.Enums;
using Exercise_048_Course_Management.SharedContext;

namespace Exercise_048_Course_Management.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}
