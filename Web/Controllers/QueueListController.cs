using MsmqManager.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MsmqManager.Web.Controllers
{
    public class QueueListController : Controller
    {
        //
        // GET: /QueueList/

        public ActionResult Index()
        {
            List<QueueModel> model = new List<QueueModel>();

            model.Add(new QueueModel("a", 1000000));
            model.Add(new QueueModel("b", 100));
            model.Add(new QueueModel("c", 1000));

            return View(model);
        }
    }
}
