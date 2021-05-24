using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OPMS.Data;

namespace OPMS.API.Controllers
{
    public class UserController : ApiController
    {
        private ParkmangtEntities db = new ParkmangtEntities();

        [HttpGet]
        public dynamic GetAll()
        {
            return db.Users
                .Select(x => new
                {
                    x.UserId,
                    x.UserName,
                    x.Password,
                    x.ContactNo,
                    x.Email,
                    x.IsActive
                });
       
        }

        [HttpPost]
        public dynamic Validate(dynamic postData)
        {
            var username = (string)postData.UserName;
            var password = (string)postData.Password;


            var validUser = db.Users
                .Where(x => x.UserName == username && x.Password == password)
                .Select(x => new
                {
                    x.UserName,
                    x.Password  
                })
                .FirstOrDefault();

            return validUser;

        }
        //ADD USER TO DATABASE DATA COMING FROM WEBSITE
        [HttpPost]
        public dynamic Add(dynamic postData)
        {
            var UserName = (string)postData.Name;
            var Password = (string)postData.Password;
            var phoneNo = (string)postData.phoneNo;
            var email = (string)postData.email;

            var user = new User()
            {
                UserName = UserName,
                Password = Password,
                ContactNo = phoneNo,
                Email = email,
                IsActive = true
            };

            db.Users.Add(user);
            var rowCount = db.SaveChanges();

            return rowCount;

        }
    }
}