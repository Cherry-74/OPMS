using OPMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OPMS.API.Controllers
{
    public class UserRoleController : ApiController
    {
        private ParkmangtEntities db = new ParkmangtEntities();

        [HttpGet]
        public dynamic GetAll()
        {
            return db.UserRoles
                .Select(x => new
                {
                    x.UserRoleId,
                    x.User.UserName,
                    x.Role.RoleName,
                    x.IsActive
                });

        }
        //ADD USER TO DATABASE DATA COMING FROM WEBSITE
        [HttpPost]
        public dynamic Add(dynamic postData)
        {
            var UserId = (Int32)postData.UserId;
            var RoleId = (Int32)postData.RoleId;

            var userRole = new UserRole()
            {
                UserId = UserId,
                RoleId = RoleId,
                IsActive = true
            };

            db.UserRoles.Add(userRole);
            var rowCount = db.SaveChanges();

            return rowCount;
        }
    }
}