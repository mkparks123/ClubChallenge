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

        [HttpPost]
        public ActionResult ClubHours(string submit, Member member)//member clocking in
        {
            if (!ModelState.IsValid)
            {
                return View("UserLogin");
            }
            if (submit.Equals("ClockIn"))
            {
                var mem = _context.Members.SingleOrDefault(c => c.PIN == member.PIN);

                var hours = new MemberClubHours();
                hours.ClockIn = DateTime.Now;
                mem.Hours.Add(hours);
                _context.SaveChanges();
                return View("ClockIn");
            }
            else if (submit.Equals("ClockOut"))
            {
                var mem = _context.Members.SingleOrDefault(c => c.PIN == member.PIN);
                var hours = new MemberClubHours();
                hours.ClockOut = DateTime.Now;
                mem.Hours.Add(hours);
                _context.SaveChanges();
                return View("ClockOut");
            }
            else
            {
                return View("AdminLogin","Login");
            }


            
        }
    }
}