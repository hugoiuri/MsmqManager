using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MsmqManager.Web.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signin(FormCollection form)
        {
            var username = form["username"];
            var password = form["password"];

            //TODO: Implement authentication integration with google

            if (username == "guest" && password == "minutrade")
            {
                return RedirectToAction("Index", "QueueList");
            }
            else
            {
                return View("Index");
            }
        }

    }
}
