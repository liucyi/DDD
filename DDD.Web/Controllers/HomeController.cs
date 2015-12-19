using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DDD.Infrastructure;

namespace DDD.Web.Controllers
{
    public class HomeController : Controller
    {
        private DDDContext db = new DDDContext();
        public ActionResult Index()
        {
         var s=   db.SysRole.ToList();
             
            return View();
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