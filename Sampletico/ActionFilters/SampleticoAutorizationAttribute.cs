using Sampletico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sampletico.ActionFilters
{
    public class SampleticoAutorizationAttribute : AuthorizeAttribute
    {
        public bool IsAdmin { get; set; }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (!httpContext.User.Identity.IsAuthenticated)
            {
                return false;
            }

            if (IsAdmin)
            {
                return SessionUser.IsCurrentAdmin();
            }

            return true;
        }
    }
}