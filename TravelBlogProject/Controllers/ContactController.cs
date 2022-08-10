using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBlogProject.Models.Classes;

namespace TravelBlogProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        Context c = new Context();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]  
        public ActionResult Index(Iletisim p)
        {
            c.Iletisims.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}