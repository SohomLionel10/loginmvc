using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApplication.Controllers
{
    public class ActionController : Controller
    {
        // GET: Action
        public ActionResult Login()
        {
            return View();
        }
    }

}