using OPMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OPMS.API.Controllers
{
    public class ParkingCollectionController : ApiController
    {
        private ParkmangtEntities db = new ParkmangtEntities();

        [HttpGet]
        public dynamic GetAll()
        {
            return db.ParkingCollections
                .Select(x => new
                {
                    x.ParkingCollectionId,
                    x.ParkingAddress.Address1,
                    x.ParkingAddress.City.Name,
                    x.ParkingDate,
                    x.VechileRegNo,
                    x.ParkingDetail.VechileType.TypeName,
                    x.InTime,
                    x.OutTime,
                    //x.ParkingDetail.VechileType.ParkingFee.Fees,
                    x.IsActive
                });
        }


        [HttpPost]
        public dynamic Add(dynamic postData)
        {
            var ParkingAddressId = (int)postData.Address1;
            //var Name = (string)postData.CityName;
            var ParkingDate = (DateTime)postData.ParkingDate;
            var VechileRegNo = (string)postData.VechileRegNo;
            var VechileType = (int)postData.TypeName;
            var InTime = (DateTime)postData.InTime;
            var OutTime = (DateTime)postData.OutTime;
            //var Fees = (decimal)postData.Fees;
            var parkingCollections = new ParkingCollection()
            {
                ParkingAddressId = ParkingAddressId,
                ParkingDate = ParkingDate,
                VechileRegNo = VechileRegNo,
                VechileTypeId = VechileType,
                InTime = InTime,
                OutTime = OutTime,
                IsActive = true
            };

            db.ParkingCollections.Add(parkingCollections);
            var rowCount = db.SaveChanges();

            return rowCount;
        }
    }
}