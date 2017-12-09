using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Principal;

namespace InjectionFactory.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private IIdentity user;
        public HomeController(IIdentity user)
        {
            this.user = user;
        }
        public ActionResult Index()
        {
            
            return View(user.Name as object);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}