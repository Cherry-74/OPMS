using OPMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OPMS.API.Controllers
{
    public class StateController : ApiController
    {
        private ParkmangtEntities db = new ParkmangtEntities();

        [HttpGet]
        public dynamic GetAll1()
        {
            return db.States
                .Select(x => new
                {
                    x.StateId,
                    x.StateName,
                    x.Country.CountryName,
                    x.IsActive
                });
        }




        [HttpPost]
        public dynamic Add(dynamic postData)
        {
            var CountryId = (int)postData.CountryId;
            var StateName = (string)postData.StateName;

            var state = new State()
            {
                CountryId = CountryId,
                StateName = StateName,
                IsActive = true
            };

            db.States.Add(state);
            var rowCount = db.SaveChanges();

            return rowCount;

        }
        [HttpGet]
        public dynamic GetStateByCountry(string id)
        {
            if (id == null || id == "undefined")
            {
                return null;
            }

            var countryid = Convert.ToInt32(id);
            return db.States.Where(x => x.CountryId == countryid)
                .Select(x => new
                {
                    x.StateId,
                    x.StateName


                });

        }

    }
}