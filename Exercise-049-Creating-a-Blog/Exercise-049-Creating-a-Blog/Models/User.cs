using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace Exercise_049_Creating_a_Blog.Models
{
    [Table("[User]")]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }

        [Write(false)]
        public List<Role> Roles { get; set; }

        public User() => Roles = new List<Role>();
    }
}
