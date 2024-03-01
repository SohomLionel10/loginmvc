using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApplication.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult formpage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult formpage(string email, string password)
        {

            return View();
        }

    }
}