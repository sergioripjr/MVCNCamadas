using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace NorthwindApp.MVCExtensions
{
    public static class HtmlHelperExtensions
    {
        public static string PostBackActionLink(this HtmlHelper helper, string linkText, string actionName, object routeValues)
        {
            return CreateElement(helper, false, linkText, actionName, routeValues);
        }
        public static string SafePostBackActionLink(this HtmlHelper helper, string linkText, string actionName, object routeValues)
        {
            return CreateElement(helper, true, linkText, actionName, routeValues);
        }
        private static string CreateElement(HtmlHelper helper, bool safe, string linkText, string actionName, object routeValues)
        {
            var formId = "f_" + Guid.NewGuid().ToString().Replace("-","_");
            return string.Format(@"<form id=""{0}"" action=""{2}"" class=""PostBackActionLink"" method=""post""><a href=""javascript:{0}.submit();"">{1}</a>{3}</form>",
                formId,
                linkText,
                new UrlHelper(helper.ViewContext.RequestContext).Action(actionName, routeValues),
                (safe ? helper.AntiForgeryToken() : ""));
        }


    }
}
