using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Sampletico.Helpers
{
    public static class FormExtensions
    {
        public static MvcForm BeginDataForm(this HtmlHelper html)
        {
            var form = html.BeginForm();
            html.ViewContext.Writer.Write(html.AntiForgeryToken().ToHtmlString());
            return form;
        }
        public static MvcForm BeginDataForm(this HtmlHelper html, ActionResult result)
        {
            var form = html.BeginForm(result);
            html.ViewContext.Writer.Write(html.AntiForgeryToken().ToHtmlString());
            return form;
        }
    }
}