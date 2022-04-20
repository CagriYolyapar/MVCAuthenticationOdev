using MVCAuthentication_0.DesignPatterns.SingletonPattern;
using MVCAuthentication_0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuthentication_0.Controllers
{
    public class HomeController : Controller
    {

        NorthwindEntities _db;

        public HomeController()
        {
            
            _db = DBTool.DBInstance;
        }
        // GET: Home
        public ActionResult Login()
        {
          
            return View();
        }


        [HttpPost]
        public ActionResult Login(Employee employee)
        {
           

            Employee emp = _db.Employees.FirstOrDefault(x => x.FirstName == employee.FirstName && x.LastName == employee.LastName);

            if (emp != null)
            {
                Session["emp"] = emp;
                return RedirectToAction("ListCategories", "Category"); 
            }

            ViewBag.Message = "Böyle bir kullanıcı bulunamadı";
            return View();
        }
    }
}