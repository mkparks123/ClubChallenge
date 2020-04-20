using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClubChallenge.Models;
using ClubChallenge.ViewModels;

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
            
            var Vmodel = new MemberEventViewModel()
            {
               Events = _context.Events.FirstOrDefault(e => e.Id == id),
               

            };
            return View(Vmodel);
        }

        [HttpPost]
        public ActionResult SignUp(MemberEventViewModel Vmodel) //signup action
        {
            

            var MemberinDB = _context.Members.Where(c => c.PIN == Vmodel.Member.PIN);
           
            var EventinDB = _context.Events.Where(c => c.Id == Vmodel.Events.Id);
            _context.Members.Add(EventinDB);
            _context.SaveChanges();


            return View("Test", Vmodel);
         
        }
    }
    
}