using LoginApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace LoginApplication.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Registerpage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registerpage(Register log)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Welcome",log);
            }
            else
            {
                return View(log);
            }
        }

        public ActionResult Welcome(Register log)
        {
            return View(log);
        }
    }
}