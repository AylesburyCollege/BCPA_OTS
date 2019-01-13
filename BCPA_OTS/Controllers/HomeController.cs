using BCPA_OTS.DAL;
using BCPA_OTS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BCPA_OTS.Controllers
{
    public class HomeController : Controller
    {
        private OTS_Context db = new OTS_Context();

        public ActionResult Index()
        {
            return View(db.Events.ToList());
        }

        public ActionResult EventDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Event @event = db.Events.Find(id);

            if (@event == null)
            {
                return HttpNotFound();
            }

            return View(@event);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}