﻿using Forum.App.Services;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Forum.App.UserInterface.ViewModels
{
    public class PostViewModel
    {
        private const int LINE_LENGHT = 37;

        public int PostId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public IList<string> Content { get; set; }
        public IList<ReplyViewModel> Replies { get; set; }

        private IList<string> GetLines(string content)
        {
            char[] contentChars = content.ToCharArray();
            IList<string> lines = new List<string>();
            for (int i = 0; i < content.Length; i+=LINE_LENGHT)
            {
                lines.Add(contentChars.Skip(i).Take(LINE_LENGHT).ToArray().ToString());
            }
            return lines;
        }

        public PostViewModel()
        {
            this.Content = new List<string>();
        }

        public PostViewModel(Post post)
        {
            this.PostId = post.Id;
            this.Title = post.Title;
            this.Content = this.GetLines(post.Content);
            this.Author = UserService.GetUser(post.AuthorId).Username;
            this.Category = PostService.GetCategory(post.CategoryId).Name;
            this.Replies = PostService.GetPostReplies(post.Id);
        }
    }
}
