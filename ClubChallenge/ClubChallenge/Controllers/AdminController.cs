using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClubChallenge.Models;

namespace ClubChallenge.Controllers
{

    public class AdminController : Controller
    {

        private DBEntities _context;

        public AdminController()
        {
            _context = new DBEntities(); //creating an object from our class DBENtities called _context
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Events()//events view
        {
            var events = _context.Events; //DBEntities.Events
        
            
            return View(events);
        }
        public ActionResult Members()//members view
        {
            var members = _context.Members; //DBEntities.Members
            return View(members);
        }


        public ActionResult AddMember()//add member page
        {
            return View();
        }
        public ActionResult AddEvent()//add event page
        {
            return View();
        }
        public ActionResult MemberDetails(int id)//member details page
        {
            var member = _context.Members.SingleOrDefault(c => c.Id == id);

            return View(member);
        }

        public ActionResult MemberEdit(int id)//member edit page
        {
            var member = _context.Members.SingleOrDefault(c => c.Id == id);
            return View(member);
        }

        public ActionResult EventDetails(int id)//Event Details page
        {
            var events = _context.Events.SingleOrDefault(c => c.Id == id);

            return View(events);
        }

        public ActionResult EventEdit(int id)//event edit page, passing id
        {
            var events = _context.Events.SingleOrDefault(c => c.Id == id);

            return View(events);
        }

        public ActionResult Reports()//reports page
        {
            return View();
        }

        [HttpPost]
        public ActionResult createMember(Member member)//admin creating a member
        {
            _context.Members.Add(member); //adding member to our dbEntities
            _context.SaveChanges(); //saving our changes
            return RedirectToAction("Members" ,"Admin");
        }

        [HttpPost]
        public ActionResult createEvent(Event events)//admin creating an even
        {
            
            _context.Events.Add(events);
            _context.SaveChanges();
            return RedirectToAction("Events", "Admin");

        }

        [HttpPost]
        public ActionResult deleteEvent(int id)//passing id to delete event controller
        {
            var deletedEvent = _context.Events.Where(c => c.Id == id).FirstOrDefault();//storing the event we wish to delete in var
            _context.Events.Remove(deletedEvent);
            _context.SaveChanges();
            return RedirectToAction("Events", "Admin");
        }

        [HttpPost]
        public ActionResult deleteMember(int id)//passing the Member ID 
        {
            var deletedMember = _context.Members.Where(c => c.Id == id).FirstOrDefault();//storing the member we wish to delete in a var

            _context.Members.Remove(deletedMember);
            _context.SaveChanges();
            return RedirectToAction("Members", "Admin");
        }
        public ActionResult Logout()
        {
            return RedirectToAction("UserLogin", "Login");
        }


    }
}