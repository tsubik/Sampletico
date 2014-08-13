using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sampletico.Helpers
{
    public static class HtmlHelpers
    {
        public static MvcHtmlString MenuLink(this HtmlHelper htmlHelper, string linkText, ActionResult action)
        {
            var currentAction = htmlHelper.ViewContext.RouteData.GetRequiredString("action");
            var currentController = htmlHelper.ViewContext.RouteData.GetRequiredString("controller");

            var builder = new TagBuilder("li")
            {
                InnerHtml = htmlHelper.ActionLink(linkText, action).ToHtmlString()
            };
            var controllerName = action.GetT4MVCResult().Controller;
            var actionName = action.GetT4MVCResult().Action;

            if (controllerName == currentController && actionName == currentAction)
                builder.AddCssClass("active");

            return new MvcHtmlString(builder.ToString());
        }
    }
}