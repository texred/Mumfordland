using Raven.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mumfordland.Controllers
{
    public class BaseDocumentStoreController : Controller
    {
        public IDocumentSession DocumentSession { get; set; }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.IsChildAction) return;

            DocumentSession = DocumentConfig.DocumentStore.OpenSession();

            base.OnActionExecuting(filterContext);
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.IsChildAction) return;

            if (DocumentSession != null && filterContext.Exception == null)
            {
                DocumentSession.SaveChanges();
            }

            DocumentSession.Dispose();

            base.OnActionExecuted(filterContext);
        }
    }
}