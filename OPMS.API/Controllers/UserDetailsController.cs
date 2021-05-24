using OPMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OPMS.API.Controllers
{
    public class UserDetailsController : ApiController
    {
        private ParkmangtEntities db = new ParkmangtEntities();

        [HttpGet]
        public dynamic GetAll()
        {
            return db.UserDetails
                .Select(x => new
                {
                    x.UserDetailsId,
                    x.User.UserName,
                    x.Address1,
                    x.Address2,
                    x.City.Name,
                    x.IsActive
                });

        }
        //ADD USER TO DATABASE DATA COMING FROM WEBSITE
        [HttpPost]
        public dynamic Add(dynamic postData)
        {

            var UserId = (int)postData.UserId;
            var CityId = (int)postData.CityId;
            var Add1 = (string)postData.Add1;
            var Add2 = (string)postData.Add2;
            

            var userdetail = db.UserDetails.Where(x => x.UserId == UserId).FirstOrDefault();
            if (userdetail == null)
            {
                userdetail = new UserDetail()
                {
                    UserId = UserId,
                    CityId = CityId,
                    Address1 = Add1,
                    Address2 = Add2,
                    
                };

                db.UserDetails.Add(userdetail);
            }
            else
            {
                userdetail.CityId = CityId;
                userdetail.Address1 = Add1;
                userdetail.Address2 = Add2;
               
                db.Entry(userdetail).State = System.Data.Entity.EntityState.Modified;
            }
            var rowCount = db.SaveChanges();

            return rowCount;

        }
        [HttpPost]
        public dynamic GetDetailsByUserId(string id)
        {

            if (!String.IsNullOrEmpty(id))
            {
                var userid = Convert.ToInt32(id);
                return db.UserDetails.Where(x => x.UserId == userid)
                    .Select(x => new
                    {
                        x.UserId,
                        x.User.UserName,
                        x.Address1,
                        x.Address2
                    });
            }
            else
            {
                return null;
            }
        }
    }
}
