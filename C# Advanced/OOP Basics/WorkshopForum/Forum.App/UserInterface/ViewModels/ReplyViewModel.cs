using Forum.App.Services;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.App.UserInterface.ViewModels
{
    public class ReplyViewModel
    {
        private const int LINE_LENGHT = 37;
        public string Author { get; set; }
        public IList<string> Content { get; set; }
       
        private IList<string> GetLines(string content)
        {
            char[] contentChars = content.ToCharArray();
            IList<string> lines = new List<string>();
            for (int i = 0; i < content.Length; i += LINE_LENGHT)
            {
                lines.Add(contentChars.Skip(i).Take(LINE_LENGHT).ToArray().ToString());
            }
            return lines;
        }

        public ReplyViewModel(Reply reply)
        {
            this.Author = UserService.GetUser(reply.AuthorId).Username;
            this.Content = GetLines(reply.Content);
        }
    }
}