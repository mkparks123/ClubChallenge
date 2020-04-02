using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClubChallenge.Models;

namespace ClubChallenge.Controllers
{

    public class UserController : Controller
    {
        private DBEntities _context;

        public UserController()
        {
            _context = new DBEntities(); //creating an object from our class DBENtities called _context
        }
        public ActionResult ClockIn()//member clocking in
        {
            return View();
        }
        public ActionResult ClockOut()//member clocking out
        {
            return View();
        }
        public ActionResult ViewEvents()//member viewing events that an admin created
        {
            var events = _context.Events;
            return View(events);
        }

        public ActionResult SignUpEvent(int id)
        {
            
            var events = _context.Membereventdata.SingleOrDefault(c => c.id == id);
            return View(events);
        }

        [HttpPost]
        public ActionResult SignUp(MemberEventData memberEventData) 
        {
            _context.Membereventdata.Add(memberEventData); 
            _context.SaveChanges(); //saving our changes
            return RedirectToAction("ViewEvents", "User");
         
        }
    }
    
}