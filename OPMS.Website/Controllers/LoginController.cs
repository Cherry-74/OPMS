using OPMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OPMS.Website.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult Failure()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginValidate(User objUser)
        {
            if (ModelState.IsValid)
            {
                using (ParkmangtEntities db = new ParkmangtEntities())
                {
                    var obj = db.Users.Where(a => a.UserName.Equals(objUser.UserName) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                    if (obj != null)
                    {

                        var returnController = GetDefaultPageAsPerRole(obj);
                        Session["UserID"] = obj.UserId.ToString();
                        Session["UserName"] = obj.UserName.ToString();

                        Response.Cookies.Add(new HttpCookie("userid")
                        {
                            Expires = DateTime.Now.AddHours(1),
                            Value = obj.UserId.ToString()
                        });



                        FormsAuthentication.SetAuthCookie(objUser.UserName, true);


                        return RedirectToAction("Index", returnController);
                    }
                }
            }
            return RedirectToAction("Index", "Login");
        }

        public void LogOut()
        {
            Response.Cookies.Remove("userid");
            Session.Abandon();
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }

        private string GetDefaultPageAsPerRole(User obj)
        {
            // Get Role as per User
            var RoleName = (obj.UserRoles.FirstOrDefault() != null) ? obj.UserRoles.FirstOrDefault().Role.RoleName : "NA";

            Session["RoleName"] = RoleName;
            string redirectUrl = "";

            if (RoleName == "Admin")
            {
                redirectUrl = "Admin";

            }
            else if (RoleName == "User")
            {
                redirectUrl = "User";
            }
            
            else if (RoleName == "NA")
            {
                redirectUrl = "Login";
            }

            return redirectUrl;

        }
    }
}