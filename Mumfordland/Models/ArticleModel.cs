using System;

namespace Mumfordland.Models
{
    public class ArticleModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Author { get; set; }
    }
}