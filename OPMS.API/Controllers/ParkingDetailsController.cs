using OPMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OPMS.API.Controllers
{
    public class ParkingDetailsController : ApiController
    {
        private ParkmangtEntities db = new ParkmangtEntities();

        [HttpGet]
        public dynamic GetAll()
        {
            return db.ParkingDetails
                .Select(x => new
                {
                    x.ParkingdetailId,
                    x.ParkingAddress.Address1,
                    x.VechileType.TypeName,
                    x.MaxSlot,
                    x.IsActive
                });
        }


        [HttpPost]
        public dynamic Add(dynamic postData)
        {
            var ParkingAddressId = (int)postData.Address1;
            var VechileTypeId = (int)postData.VehicleTypeId;
            var MaxSlot = (int)postData.MaxSlot;
            var parkingDetails = new ParkingDetail()
            {
                ParkingAddressId = ParkingAddressId,
                VechileTypeId = VechileTypeId,
                MaxSlot = MaxSlot,
                IsActive = true
            };

            db.ParkingDetails.Add(parkingDetails);
            var rowCount = db.SaveChanges();

            return rowCount;
        }
    }
}