using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TASK.Models;

namespace TASK.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(Signup s)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }
            return View(s);
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}