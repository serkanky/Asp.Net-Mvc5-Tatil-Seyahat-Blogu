using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Classes;

namespace TravelTrip.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogComment comment = new BlogComment();
        public ActionResult Index()
        {
            //var values = c.Blogs.ToList();
            comment.Value1 = c.Blogs.ToList();
            comment.Value3= c.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
            comment.Value4= c.Comments.OrderByDescending(x=>x.ID).Take(3).ToList();
            return View(comment);
        }

        
        public ActionResult BlogDetail(int id)
        {
            //var values = c.Blogs.Where(x=>x.ID==id).ToList();
            comment.Value1=c.Blogs.Where(x=>x.ID == id).ToList();
            comment.Value2=c.Comments.Where(x=>x.ID == id).ToList();
            return View(comment);
        }
        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.values = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddComment(Comment y)
        {
            c.Comments.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}