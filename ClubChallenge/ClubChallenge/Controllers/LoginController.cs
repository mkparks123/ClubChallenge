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
        public ActionResult SaveAdmin(Admin admin) //need to pass Register admin viewmodel here so we can confirm password
        {
            if(admin.FirstName == null)
            {
                ModelState.AddModelError("FirstName", "Enter First Name");
                return View("CreateAdminPage");
            }
            else if(admin.LastName == null)
            {
                ModelState.AddModelError("LastName", "Enter Last Name");
                return View("CreateAdminPage");
            }
            else if(admin.Password == null)
            {
                ModelState.AddModelError("Passowrd", "Enter Password");
                return View("CreateAdminPage");
            }
            else
            {
                _context.Admin.Add(admin); //adding admin to our dbEntities
                _context.SaveChanges(); //saving our changes
                return RedirectToAction("AdminLogin", "Login");
            }
            


        }

        public ActionResult UserLogin()//user login page
        {
            return View();
        }

        [HttpPost]
        public ActionResult ClubHours(string submit, Member member)//member clocking in
        {

            if (submit.Equals("ClockIn"))
            {
                var mem = _context.Members.SingleOrDefault(c => c.PIN == member.PIN);

                if (mem == null) //validating events fields
                {
                    ModelState.AddModelError("PIN", "Invalid PIN");
                    return View("UserLogin");
                }
                else
                {

                    var hours = new MemberClubHours();
                    hours.ClockIn = DateTime.Now;
                    mem.Hours.Add(hours);
                    _context.SaveChanges();
                    return View("ClockIn");
                }

            }
            else if (submit.Equals("ClockOut"))
            {
                var mem = _context.Members.SingleOrDefault(c => c.PIN == member.PIN);
                if (mem == null) //validating events fields
                {
                    ModelState.AddModelError("PIN", "Invalid PIN");
                    return View("UserLogin");
                }
                else
                {
                    
                    var hours = new MemberClubHours();
                    hours.ClockOut = DateTime.Now;
                    mem.Hours.Add(hours);
                    _context.SaveChanges();
                    return View("ClockOut");
                }

            }
            else
            {
                return View("UserLogin","Login");
            }
        

        }

        [HttpPost]
        public ActionResult ValidateAdmin(Admin admin)
        {
           
            var ad = _context.Admin.SingleOrDefault(c => c.Password == admin.Password);
            if(ad == null)
            {
                ModelState.AddModelError("Password", "Invalid Password");
                return View("AdminLogin");

            }
            else
            {
                return RedirectToAction("Index", "Admin");
            }
            
        }
    }
}