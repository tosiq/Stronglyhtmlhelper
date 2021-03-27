using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication21.Models;

namespace WebApplication21.Controllers
{
public  class HomeController : Controller
    {
        static List<Employee> obj = new List<Employee>();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost] //annotation
        public ActionResult Index(Employee a)
        {
            obj.Add(a);
            //ViewBag.id   =a.id;
            //ViewBag.name = a.name;
            //ViewBag.password = a.password;
            //ViewBag.age = a.age;
            ModelState.Clear();

            return RedirectToAction("Select","Home");
        }

        public ActionResult Select()
        {
            return View(obj.ToList());
        }
    }
}