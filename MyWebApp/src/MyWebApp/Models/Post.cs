using System;

namespace MyWebApp.Models
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime PostDate { get; set; }
    }
}