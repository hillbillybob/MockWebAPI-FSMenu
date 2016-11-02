using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FoodServicesMenu.Models;

namespace FoodServicesMenu.Controllers
{    
    public class DishController : ApiController
    {
        List<Day> Week = new List<Day>();
        public DishController()
        {
            Week = DataMock.GetData();
        }

        /// <summary>
        /// Get's a collection of Dishes
        /// </summary>
        /// <returns></returns>
        // GET: api/Dish
        public IEnumerable<Dish> Get()
        {
            var result = from theDays in Week
                         from theMeals in theDays.Meals
                         from theDishes in theMeals.Dishes
                         select theDishes;
            return result;
        }

        /// <summary>
        /// Not yet implemented
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Dish/5
        public string Get(int id)
        {
            return "Not Implemented Yet";
        }

        // POST: api/Dish
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Dish/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Dish/5
        public void Delete(int id)
        {
        }
    }
}
