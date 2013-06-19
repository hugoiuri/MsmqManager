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
        public ActionResult Index()
        {
            List<QueueModel> model = new List<QueueModel>();

            model.Add(new QueueModel("adsaj kj hsldaighkf A", 1000000));
            model.Add(new QueueModel("bSAD SHG KAG SFKSBF SA CCasf nkjbvs fm", 100));
            model.Add(new QueueModel("dfgsjkgbsdkfj çkb", 1000));
            model.Add(new QueueModel("dfgsjkgbsdkfj çkb", 999));
            model.Add(new QueueModel("alksfjsabfgal çkb", 999));
            model.Add(new QueueModel("keflawinfclaisg shld abv ", 0));
            model.Add(new QueueModel("dfgsjkgbsdkfj çkb", 34));
            model.Add(new QueueModel("dfgsjkgbsdkfj çkb", 13));
            model.Add(new QueueModel("dfgsjkgbsdkfj çkb", 25));
            model.Add(new QueueModel("bnmbnmbnmbnmnb çkb", 10));
            model.Add(new QueueModel("cdecde çkb", 10));
            model.Add(new QueueModel("cdecde çkb", 0));
            model.Add(new QueueModel("asdadasdass çkb", 10));
            model.Add(new QueueModel("dfgsjkgbsdkfj çkb", 10));
            model.Add(new QueueModel("dfgsjkgbsdkfj çkb", 47));
            model.Add(new QueueModel("dfgsjkgbsdkfj çkb", 53));
            model.Add(new QueueModel("dfgsjkgbsdkfj çkb", 21));
            model.Add(new QueueModel("dfgsjkgbsdkfj çkb", 78));
            model.Add(new QueueModel("dfgsjkgbsdkfj çkb", 0));

            return View(model);
        }

        public ActionResult Details(string name)
        {

            return View();
        }
    }
}
