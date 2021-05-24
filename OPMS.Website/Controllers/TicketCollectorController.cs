using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OPMS.Website.Controllers
{
    public class TicketCollectorController : Controller
    {
        // GET: TicketCollector
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FeeCollection()
        {
            return View();
        }
        public ActionResult GenerateParkingSlot()
        {
            return View();
        }
    }
}