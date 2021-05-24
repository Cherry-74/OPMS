using OPMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OPMS.API.Controllers
{
    public class UserParkingController : ApiController
    {
        private ParkmangtEntities db = new ParkmangtEntities();

        [HttpGet]
        public dynamic GetAll()
        {
            return db.UserParkingAddresses
                .Select(x => new
                {
                    x.UserParkingAddressId,
                    x.User.UserName,
                    x.ParkingAddress.Address1,
                    x.ParkingAddress.City.Name,
                    x.IsActive
                });
        }


        [HttpPost]
        public dynamic Add(dynamic postData)
        {
            var UserId = (int)postData.UserId;
            var ParkingAddressId = (int)postData.ParkingAddressId;
            var City=(string)postData.Name;
            var userParkingAddress = new UserParkingAddress()
            {
                UserId = UserId,
                ParkingAddressId = ParkingAddressId,
                IsActive = true
            };

            db.UserParkingAddresses.Add(userParkingAddress);
            var rowCount = db.SaveChanges();

            return rowCount;
        }
    }
}