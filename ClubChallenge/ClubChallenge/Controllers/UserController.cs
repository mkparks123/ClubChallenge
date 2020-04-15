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

        public ActionResult ViewEvents()//member viewing events that an admin created
        {
            var events = _context.Events;
            return View(events);
        }

        public ActionResult SignUpEvent(int id)
        {
            
            var events = _context.Members.SingleOrDefault(c => c.Id == id);
            return View(events);
        }

        [HttpPost]
        public ActionResult SignUp(int id, string Pin) 
        {
            var mem = _context.Members.SingleOrDefault(c => c.PIN == Pin);
            var events = _context.Events.SingleOrDefault(c => c.Id == id);

            return View();
         
        }
    }
    
}