using OPMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OPMS.API.Controllers
{
    public class CountryController : ApiController
    {

        private ParkmangtEntities db = new ParkmangtEntities();

        [HttpGet]
        public dynamic GetAll()
        {
            return db.Countries
                .Select(x => new
                {
                    x.CountryId,
                    x.CountryName,
                    x.IsActive
                });
        }


        [HttpPost]
        public dynamic Add(dynamic postData)
        {
            var CountryName = (string)postData.CountryName;
            var country = new Country()
            {
                CountryName = CountryName,
                IsActive = true
            };

            db.Countries.Add(country);
            var rowCount = db.SaveChanges();

            return rowCount;
        }
    }
}