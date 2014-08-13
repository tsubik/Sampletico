using Sampletico.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sampletico.Models
{
    public class SessionUser
    {
        public static User Current
        {
            get { return (User)HttpContext.Current.Session["SessionUser"]; }
            set { HttpContext.Current.Session["SessionUser"] = value; }
        }

        public static bool IsCurrentAdmin()
        {
            var user = Current;
            if (user != null)
            {
                return user.IsAdmin;
            }
            return false;
        }
    }
}