using OPMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

    namespace OPMS.API.Controllers
    {
        public class RoleController : ApiController
        {
            private ParkmangtEntities db = new ParkmangtEntities();

            [HttpGet]
            public dynamic GetAll()
            {
                return db.Roles
                    .Select(x => new
                    {
                        x.RoleId,
                        x.RoleName,
                        x.IsActive
                    });

            }
            //ADD USER TO DATABASE DATA COMING FROM WEBSITE
            [HttpPost]
            public dynamic Add(dynamic postData)
            {
                var RoleName = (string)postData.RoleName;
                var role = new Role()
                {
                    RoleName = RoleName,
                    IsActive = true
                };

                db.Roles.Add(role);
                var rowCount = db.SaveChanges();

                return rowCount;

            }
        }
    }
