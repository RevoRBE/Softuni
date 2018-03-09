using System;
using System.Collections.Generic;

namespace Forum.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public ICollection<int> Replies { get; set; }

        public Post(int id, string title, string content, int categoryId, int authorId, IEnumerable<int> replies)
        {
            this.Id = id;
            this.CategoryId = categoryId;
            this.Title = title;
            this.AuthorId = authorId;
            this.Content = content;
            this.Replies = new List<int>(replies);
        }
    }
}
