using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginApplication.Models;

namespace LoginApplication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Loginpage()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Loginpage(loginmodel log)
        {
            if(ModelState.IsValid)
            {
                if (log.Email.ToLower() == "sohomb3@gmail.com" && log.Password == "Hello")
                {
                    return RedirectToAction("Welcome", new {email=log.Email});
                }
                else
                {
                    ViewBag.Error = "Enter Valid Email and Password";
                }              
            }
            return View(log);
        }
        public ActionResult Welcome(string email)
        {
            ViewBag.Email = email;
            return View();
        }
    }
}