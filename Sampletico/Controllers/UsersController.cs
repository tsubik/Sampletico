using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sampletico.ActionFilters;
using Sampletico.ViewModels;
using Sampletico.Core.Services;

namespace Sampletico.Controllers
{
    public partial class UsersController : Controller
    {
        //
        // GET: /Users/
        [SampleticoAutorization(IsAdmin=true)]
        [HttpGet]
        public virtual ActionResult List()
        {
            UserListViewModel model = new UserListViewModel();
            model.Users = AutoMapper.Mapper.Map<IList<UserListItemViewModel>>(UserService.GetAll());
            return View(model);
        }

        [SampleticoAutorization(IsAdmin = true)]
        [HttpGet]
        public virtual ActionResult Edit(int id)
        {
            var user = UserService.FindById(id);
            var model = user.ToViewModel<UserEditViewModel>();

            return View(model);
        }

        [SampleticoAutorization(IsAdmin = true)]
        [HttpGet]
        public virtual ActionResult New()
        {
            return View();
        }

        [SampleticoAutorization(IsAdmin = true)]
        [HttpPost]
        public virtual ActionResult New(UserNewViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = UserService.RegisterUser(model.Email, model.Password, model.IsAdmin);
                return RedirectToAction(MVC.Users.List());
            }
            return View(model);
        }

    }
}
