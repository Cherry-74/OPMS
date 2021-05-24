using OPMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OPMS.API.Controllers
{
    public class CityController : ApiController
    {
        private ParkmangtEntities db = new ParkmangtEntities();

        [HttpGet]
        public dynamic GetAll()
        {
            return db.Cities
                .Select(x => new
                {
                    x.CityId,
                    x.Name,
                    x.State.StateName,
                    x.State.Country.CountryName,
                    x.IsActive
                });
        }


        [HttpPost]
        public dynamic Add(dynamic postData)
        {

            var StateId = (int)postData.StateId;
            var CityName = (string)postData.CityName;

            var city = new City()
            {
                StateId = StateId,
               Name = CityName,
                IsActive = true
            };

            db.Cities.Add(city);
            var rowCount = db.SaveChanges();

            return rowCount;
        }
    }
}