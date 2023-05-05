using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Classes;
namespace TravelTrip.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Blogs.Take(4).ToList();
            return View(values);
        }
       public PartialViewResult Partial1()
        {
            var values = c.Blogs.OrderByDescending(x=>x.ID).Take(2).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial2()
        {
            var values=c.Blogs.Where(x=>x.ID==6).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial3()
        {
            var values = c.Blogs.Take(10).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial4()
        {
            var values = c.Blogs.Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial5()
        {
            var values = c.Blogs.Take(3).OrderByDescending(x=>x.ID).ToList();
            return PartialView(values);
        }
    }
}