using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TASK2.EF;

namespace TASK2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new SHOPEntities();
            var data = db.Products.Include("Category").ToList();
            return View(data);
        }

        public ActionResult Buy()
        {
            var db = new SHOPEntities();
            var data = db.Products.ToList();
            return View(data);
        }

        

    }
}
