using OPMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OPMS.API.Controllers
{
    public class ParkingAddressController : ApiController
    {

        private ParkmangtEntities db = new ParkmangtEntities();

        [HttpGet]
        public dynamic GetAll()
        {
            return db.ParkingAddresses
                .Select(x => new
                {
                    x.ParkingAddressId,
                    x.Address1,
                    x.Address2,
                    x.City.Name,
                    x.IsActive
                });
        }


        [HttpPost]
        public dynamic Add(dynamic postData)
        {
            var Address1 = (string)postData.Address1;
            var Address2 = (string)postData.Address2;
            var CityId = (Int32)postData.CityId;
            var parkingaddress = new ParkingAddress()
            {
                Address1 = Address1,
                Address2 = Address2,
                CityId = CityId,
                IsActive = true
            };

            db.ParkingAddresses.Add(parkingaddress);
            var rowCount = db.SaveChanges();

            return rowCount;
        }
    }
}