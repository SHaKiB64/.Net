using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Name = "MD. SHAKIB HOWLADER";
            ViewBag.ID = "20-42752-1";
            ViewBag.Email = "mdshakib6477@gmail.com";
            ViewBag.ContactNum = "01743530117";

            return View();
        }

        public ActionResult Education()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult PersonalInfo()
        {
            ViewBag.Message = "Your Projects page.";
            ViewBag.Name = "MD. SHAKIB HOWLADER";
            ViewBag.ID = "20-42752-1";
            ViewBag.Email = "mdshakib6477@gmail.com";
            ViewBag.ContactNum = "01743530117";
            ViewBag.Hieght = "5'7\"";
            ViewBag.BloodGrp = "O+";
            ViewBag.Dept = "CSE";


            return View();
        }

        public ActionResult Reference()
        {
            ViewBag.Message = "Your Reference page.";

            return View();
        }
        

    }
}