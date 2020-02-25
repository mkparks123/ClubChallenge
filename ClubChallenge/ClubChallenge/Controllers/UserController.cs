using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClubChallenge.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Home()
        {
            return View();
        }
    }
}