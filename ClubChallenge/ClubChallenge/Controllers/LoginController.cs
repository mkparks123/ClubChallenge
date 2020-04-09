using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClubChallenge.Models;

namespace ClubChallenge.Controllers
{
    public class LoginController : Controller
    {
        private DBEntities _context;

        public LoginController()
        {
            _context = new DBEntities(); //creating an object from our class DBENtities called _context
        }

        public ActionResult AdminLogin()//admin login page
        {
            return View();
        }

        public ActionResult CreateAdminPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveAdmin(Admin admin)
        {
             _context.Admin.Add(admin); //adding admin to our dbEntities
             _context.SaveChanges(); //saving our changes
            return RedirectToAction("AdminLogin", "Login");


        }

        public ActionResult UserLogin()//user login page
        {
            return View();
        }
        public ActionResult ClockIn()//member clocking in
        {

            return View();
        }
        public ActionResult ClockOut()//member clocking out
        {
            return View();
        }
    }
}