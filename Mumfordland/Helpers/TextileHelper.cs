using System.Web.Mvc;
using Textile;

namespace Mumfordland.Helpers
{
    public class TextileHelper
    {
        public static MvcHtmlString TextileToHtml(string text)
        {
            return MvcHtmlString.Create(TextileFormatter.FormatString(text));
        }
    }
}