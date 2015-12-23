using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DDD.Application.Interface;
using DDD.Domain.Entity;
using DDD.Infrastructure;

namespace DDD.Web.Controllers
{
    public class HomeController : Controller
    {
        //private IRoleService _roleService;
        //public HomeController(IRoleService roleService)
        //{
        //    _roleService = roleService;
        //}

        public ActionResult Index()
        {

            DDDContext db = new DDDContext();
            var model = db.User.ToList();
            return View(model);
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