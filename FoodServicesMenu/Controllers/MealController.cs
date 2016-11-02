using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FoodServicesMenu.Models;

namespace FoodServicesMenu.Controllers
{
    public class MealController : ApiController
    {
        List<Day> Week = new List<Day>();
        public MealController()
        {
            Week = DataMock.GetData();
        }

        /// <summary>
        /// Get's a collection of Meals
        /// </summary>
        // GET: api/Meal
        public IEnumerable<Meal> Get()
        {
            var results = from theDays in Week
                          from theMeals in theDays.Meals
                          select theMeals;
            return results;
        }

        /// <summary>
        /// Not yet implemented
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Meal/5
        public string Get(int id)
        {
            return "Not Implemented Yet";
        }

        // POST: api/Meal
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Meal/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Meal/5
        public void Delete(int id)
        {
        }
    }
}
