using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DDD.Application;
using DDD.Application.Interface;
using DDD.Domain.Entity;
using DDD.Infrastructure;

namespace DDD.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRoleService _roleService { get; set; }
        private IUserService _userService { get; set; }


        public ActionResult Index()
        {
           
            // var s=  _roleService.GetByName(1);
            // DDDContext db = new DDDContext();
            // var model = db.Users.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Login()
        {


            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
           // var s = _roleService.GetByName(1);
             var model = _userService.Login(user);
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}