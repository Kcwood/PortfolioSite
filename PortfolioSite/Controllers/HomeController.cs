using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioSite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        // GET: /Home/About
        public ActionResult About()
        {
            return View();
        }

        // GET: /Home/Work
        public ActionResult Work()
        {
            return View();
        }

        // GET: /Home/Contact 
        [HttpGet]
        public ActionResult Contact()
        {
            //Create a new contact form object
            // pass to our view
            Models.ContactForm cf = new Models.ContactForm();
            return View(cf);
        }

        // POST: /Home/Contact
        [HttpPost]
        public ActionResult Contact(Models.ContactForm cf)
        {
            //Create a new connection to our database
            Models.ContactFormEntities db = new Models.ContactFormEntities();
            //Add the contact info to the database
            db.ContactForms.Add(cf);
            //save changes to the database
            db.SaveChanges();
            //Redirect user to the thank you page
            return RedirectToAction("ThankYou");
        }

        // GET: /Home/ThankYou
        public ActionResult ThankYou()
        {
            return View();
        }
    }
}
