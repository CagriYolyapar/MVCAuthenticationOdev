using MVCAuthentication_0.AuthClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuthentication_0.Controllers
{
    [EmployeeAuthentication]
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult ListCategories()
        {
            return View();
        }
    }
}