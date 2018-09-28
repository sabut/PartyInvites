using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index() {
        //return View();
        //}
        // 2GET: Home
        //public string Index ()
        //{
        //    return "Hello Word";
        //}
        // 3GET: Home
        //public ViewResult Index()
        //{
        //    return View();
        //}
//Верхня частина заготоки

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
        //звернення  до URL RsvpForm
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                // TODO: Email response to the party organizer
                return View("Thanks", guestResponse);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }



    }
}