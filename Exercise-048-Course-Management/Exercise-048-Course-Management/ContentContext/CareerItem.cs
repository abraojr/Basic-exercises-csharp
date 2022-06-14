using Exercise_048_Course_Management.NotificationContext;
using Exercise_048_Course_Management.SharedContext;

namespace Exercise_048_Course_Management.ContentContext
{
    public class CareerItem : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }

        public CareerItem(int order, string title, string description, Course course)
        {
            if (course == null) AddNotification(new Notification("Course", "Invalid course"));

            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }
    }
}
