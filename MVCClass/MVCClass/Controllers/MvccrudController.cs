using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCClass.Models;

namespace MVCClass.Controllers
{
    public class MvccrudController : Controller
    {
        //
        // GET: /Mvccrud/

        private static Users userList = new Users();

        public ActionResult Index()
        {
            return View(userList.userList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserModel user)
        {
            userList.CreateUser(user);
            return RedirectToAction("Index");
        }
    }
}
