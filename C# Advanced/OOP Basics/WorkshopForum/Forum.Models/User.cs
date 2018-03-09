using System;
using System.Collections.Generic;

namespace Forum.Models
{
    public class User
    {
        public int Id { get; set; }
        public ICollection<int> Posts { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(int id, string username, string password, IEnumerable<int> postIds)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Posts = new List<int>(postIds);
        }
    }
}
