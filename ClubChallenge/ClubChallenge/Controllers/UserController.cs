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
            Event events = new Event(); //create object of event class
            events = _context.Events.SingleOrDefault(c => c.Id == Vmodel.Events.Id); //find event associated with ID
            Member MemberinDB = _context.Members.SingleOrDefault(c => c.PIN == Vmodel.Member.PIN); //find member asociated with PIN

            events.Members.Add(MemberinDB);//add member to the event 
            
            
            _context.Events.Add(events);//add to table
            _context.SaveChanges();//save changes


            return RedirectToAction("ViewEvents", "User");//return the member back to the events view
         
        }

        public ActionResult ViewVolunteerEvents()
        {
            var Vevents = _context.Volunteerevents;
            return View(Vevents);
        }

        public ActionResult SignUpVolunteerEvent(int id)
        {
            var Vevent = new VolunteerEventViewModel()
            {
                Vevents = _context.Volunteerevents.FirstOrDefault(e => e.Id == id),
            };

            return View(Vevent);
        }
         [HttpPost]
         public ActionResult VolunteerSignUp(VolunteerEventViewModel Vevent)
        {
            VolunteerEvents Volunteerevent = new VolunteerEvents();
            Volunteerevent = _context.Volunteerevents.SingleOrDefault(c => c.Id == Vevent.Vevents.Id);
            Member MemberinDB = _context.Members.SingleOrDefault(c => c.PIN == Vevent.member.PIN);
            Volunteerevent.Members.Add(MemberinDB);
            _context.Volunteerevents.Add(Volunteerevent);//add to table
            _context.SaveChanges();
            return RedirectToAction("ViewVolunteerEvents", "User");
        }
    }
    
}