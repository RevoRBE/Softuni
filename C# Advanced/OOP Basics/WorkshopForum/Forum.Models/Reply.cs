﻿using System;
using System.Collections.Generic;

namespace Forum.Models
{
    public class Reply
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public int PostId { get; set; }

        public Reply(int id, string content, int authorId, int postId)
        {
            this.Id = id;
            this.AuthorId = authorId;
            this.PostId = postId;
            this.Content = content;
        }
    }
}
