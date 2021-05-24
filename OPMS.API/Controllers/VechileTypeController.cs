using OPMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OPMS.API.Controllers
{
    public class VechileTypeController : ApiController
    {
        private ParkmangtEntities db = new ParkmangtEntities();

        [HttpGet]
        public dynamic GetAll()
        {
            return db.VechileTypes
                .Select(x => new
                {
                    x.VechileTypeId,
                    x.TypeName,
                    x.ParkingFee.Fees,
                    x.IsActive
                });
        }


        [HttpPost]
        public dynamic Add(dynamic postData)
        {
            var TypeName = (string)postData.TypeName;
            var Fees = (int)postData.Fees;
            var vechileType = new VechileType()
            {
                TypeName = TypeName,
                ParkingFeesId = Fees,
                IsActive = true
            };

            db.VechileTypes.Add(vechileType);
            var rowCount = db.SaveChanges();

            return rowCount;
        }
    }
}