using Dapper.Contrib.Extensions;

namespace Exercise_049_Creating_a_Blog.Models
{
    [Table("[Post]")]
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }
}
