using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClubChallenge.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult AdminLogin()//admin login page
        {
            return View();
        }

        public ActionResult UserLogin()//user login page
        {
            return View();
        }
    }
}