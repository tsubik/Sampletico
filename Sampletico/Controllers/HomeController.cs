using Sampletico.ActionFilters;
using Sampletico.Core.Entities;
using Sampletico.Core.Services;
using Sampletico.Models;
using Sampletico.ViewModels;
using Simple.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Sampletico.Controllers
{
    public partial class HomeController : Controller
    {
        //
        // GET: /Home/

        public virtual ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public virtual ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult SignIn(SignInViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = UserService.Authenticate(model.Login, model.Password);
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Login, false);
                    SessionUser.Current = user;
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    return RedirectToAction(MVC.Users.List());
                }
                ModelState.AddModelError("Login", "Wrong credentials");
            }

            return View(model);
        }

        [HttpGet]
        [SampleticoAutorization]
        public virtual ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            SessionUser.Current = null;
            return RedirectToAction(MVC.Home.Index());
        }

        [HttpGet]
        public virtual ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult SignUp(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserService.RegisterUser(model.Email, model.Password, false);
                return RedirectToAction(MVC.Home.Index());
            }

            return View(model);
        }
    }
}
