using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FoodServicesMenu.Models;

namespace FoodServicesMenu.Controllers
{
    public class DayController : ApiController
    {
        List<Day> Week = new List<Day>();

        public DayController()
        {
            Week = DataMock.GetData();
        }

        /// <summary>
        /// Gets a collection of Days, 7 days out
        /// </summary>
        // GET: api/Day
        public IEnumerable<Day> Get()
        {
            return Week;
        }

        /// <summary>
        /// Gets a specific day
        /// </summary>
        /// <param name="id">The id of the day</param>
        /// <returns></returns>
        // GET: api/Day/5
        public Day Get(int id)
        {
            return Week[id];
        }

        // POST: api/Day
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Day/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Day/5
        public void Delete(int id)
        {
        }
    }
}
