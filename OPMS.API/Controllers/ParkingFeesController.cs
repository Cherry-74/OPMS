using OPMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OPMS.API.Controllers
{
    public class ParkingFeesController : ApiController
    {
        private ParkmangtEntities db = new ParkmangtEntities();

        [HttpGet]
        public dynamic GetAll()
        {
            return db.ParkingFees
                .Select(x => new
                {
                    x.ParkingFeesId,
                    x.Fees,
                    x.IsActive
                });
        }


        [HttpPost]
        public dynamic Add(dynamic postData)
        {
           
            var Fees = (int)postData.Fees;
            var parkingFees = new ParkingFee()
            {
                Fees = Fees,
                IsActive = true
            };

            db.ParkingFees.Add(parkingFees);
            var rowCount = db.SaveChanges();

            return rowCount;
        }
    }
    
}