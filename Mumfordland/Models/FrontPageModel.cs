using System.Collections.Generic;

namespace Mumfordland.Models
{
    public class FrontPageModel
    {
        public string Id { get; set; }
        public string Headline { get; set; }
        public string Details { get; set; }
        public List<ArticleModel> RecentArticles { get; set; }
    }
}