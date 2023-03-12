using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class FirstController : Controller
    {
        // GET: Fist
        public ActionResult Index()
        {
            return View();
        }
    }
}