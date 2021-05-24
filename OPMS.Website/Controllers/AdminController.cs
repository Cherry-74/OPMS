using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OPMS.Website.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UserTable()
        {
            return View();
        }
        public ActionResult UserDetailsTable()
        {
            return View();
        }
        public ActionResult RoleDetailsTable()
        {
            return View();
        }
        public ActionResult UserRoleDetailsTable()
        {
            return View();
        }
        public ActionResult CityManagement()
        {
            return View();
        }
        public ActionResult StateManagement()
        {
            return View();
        }
        public ActionResult CountryManagement()
        {
            return View();
        }
        public ActionResult ParkingAddress()
        {
            return View();
        }
        public ActionResult ParkingFees()
        {
            return View();
        }
        public ActionResult VechileType()
        {
            return View();
        }
        public ActionResult UserParkingAddress()
        {
            return View();
        }
        public ActionResult ParkingCollection()
        {
            return View();
        }
        public ActionResult ParkingDetails()
        {
            return View();

        }
    }
}