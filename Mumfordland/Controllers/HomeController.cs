using Mumfordland.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mumfordland.Controllers
{
    public class HomeController : BaseDocumentStoreController
    {
        public ActionResult Index()
        {
            var frontPage = new FrontPageModel
            {
                Id = Guid.NewGuid().ToString(),
                Headline = "This is a test headline.",
                Details = "Testing out the new model that supports the home page.",
                RecentArticles = new List<ArticleModel>
                {
                    new ArticleModel
                    {
                        Id = Guid.NewGuid().ToString(),
                        Title = "First test article",
                        PublicationDate = DateTime.Now.AddDays(-1d),
                        Body = "Here is the first test article.\r\n\r\n* Testing lists\r\n* More items",
                        Summary = "Here is the first test article.",
                        Author = "Dave Hanlon",
                    },
                    new ArticleModel
                    {
                        Id = Guid.NewGuid().ToString(),
                        Title = "Second test article",
                        PublicationDate = DateTime.Now.AddHours(-1d),
                        Body = "Here is the second test article.",
                        Summary = "Here is the second test article.",
                        Author = "Dave Hanlon",
                    },
                },
            };

            return View(frontPage);
        }

        public ActionResult About()
        {
            ViewBag.Message = "mumfordland is my site, and I'm going to fill it with my stuff.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Track me along with the NSA.";

            return View();
        }
    }
}
