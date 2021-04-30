using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewCompany.Controllers
{
    public class EmplyeeController : Controller
    {
        // GET: Emplyee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EmployeeView()
        {
            return View();

        }
    }
}