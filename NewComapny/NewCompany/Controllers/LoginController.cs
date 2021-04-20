using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewCompany.Models;

namespace NewComapany.Controllers
{
    public class LoginController : Controller
    {
        // GET: Aniket
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public JsonResult LoginView(Login login)
        {
          
            bool Result;
            if (login.UserName == "user" && login.Password == "pass")
               
                Result = true;

            else
                Result = false;

            return Json(Result, JsonRequestBehavior.AllowGet);

        }
        public ActionResult LoginView()
        {
            return View();

        }
    }
}