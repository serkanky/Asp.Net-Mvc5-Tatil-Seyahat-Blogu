using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Classes;
namespace TravelTrip.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
       Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        [Authorize]
        public ActionResult InsertBlog() 
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public ActionResult InsertBlog(Blog blog)
        {
            c.Blogs.Add(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult RemoveBlog(int id)
        {
            var values = c.Blogs.Find(id);
            c.Blogs.Remove(values);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult GetBlog(int id)
        {
            var blog = c.Blogs.Find(id);
            return View("GetBlog",blog);
        }
        [Authorize]
        public ActionResult UpdateBlog(Blog b)
        {
            var blogs = c.Blogs.Find(b.ID);
            blogs.Title = b.Title;
            blogs.Description = b.Description;
            blogs.ImageUrl = b.ImageUrl;
            blogs.Date = b.Date;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult CommentList()
        {
            var comment=c.Comments.ToList();
            return View(comment);
        }
        [Authorize]
        public ActionResult RemoveComment(int id)
        {
            var values = c.Comments.Find(id);
            c.Comments.Remove(values);
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
        [Authorize]
        public ActionResult GetComment(int id)
        {
            var comnt = c.Comments.Find(id);
            return View("GetComment", comnt);
        }
        [Authorize]
        public ActionResult UpdateComment(Comment cm)
        {
            var comnt = c.Comments.Find(cm.ID);
            comnt.UserName = cm.UserName;
            comnt.Email = cm.Email;
            comnt.Comments = cm.Comments;
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
        [Authorize]
        public ActionResult ContactList()
        {
            var contact = c.Contacts.ToList();
            return View(contact);
        }
        [Authorize]
        public ActionResult RemoveContact(int id)
        {
            var values = c.Contacts.Find(id);
            c.Contacts.Remove(values);
            c.SaveChanges();
            return RedirectToAction("ContactList");
        }
        [Authorize]
        public ActionResult GetContact(int id)
        {
            var contct = c.Contacts.Find(id);
            return View("GetContact", contct);
        }
        [Authorize]
        public ActionResult UpdateContact(Contact cntc)
        {
            var cntact = c.Contacts.Find(cntc.ID);
            cntact.NameSurname = cntc.NameSurname;
            cntact.Email = cntc.Email;
            cntact.Subject = cntc.Subject;
            cntact.Message = cntc.Message;
            c.SaveChanges();
            return RedirectToAction("ContactList");
        }
        [Authorize]
        public ActionResult AboutList()
        {
            var about = c.Abouts.ToList();
            return View(about);
        }
        [Authorize]
        public ActionResult RemoveAbout(int id)
        {
            var values = c.Abouts.Find(id);
            c.Abouts.Remove(values);
            c.SaveChanges();
            return RedirectToAction("AboutList");
        }
        [Authorize]
        public ActionResult GetAbout(int id)
        {
            var abts = c.Abouts.Find(id);
            return View("GetAbout", abts);
        }
        [Authorize]
        public ActionResult UpdateAbout(About abt)
        {
            var abts = c.Abouts.Find(abt.ID);
            abts.ImageUrl = abt.ImageUrl;
            abts.Description = abt.Description;
            c.SaveChanges();
            return RedirectToAction("AboutList");
        }
        [HttpGet]
        [Authorize]
        public ActionResult InsertAbout()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public ActionResult InsertAbout(About about)
        {
            c.Abouts.Add(about);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}