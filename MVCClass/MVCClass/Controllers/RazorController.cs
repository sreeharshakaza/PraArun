using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCClass.Controllers
{
    public class RazorController : Controller
    {
        //
        // GET: /Razor/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HtmlHelper()
        {
            return View();
        }
    }
}
