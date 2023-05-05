using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTrip.Models.Classes;

namespace TravelTrip.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin adm)
        {
            var info=c.Admins.FirstOrDefault(x=>x.User == adm.User && x.Password ==adm.Password);

            if (info != null)
            {
                FormsAuthentication.SetAuthCookie(info.User,false);
                Session["User"]=info.User.ToString();
                return RedirectToAction("Index","Admin");
            }
            else 
            { 
                return View(); 
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}