﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FoodServicesMenu.Models;

namespace FoodServicesMenu.Controllers
{
    public class MenuController : ApiController
    {
        List<Day> Week = new List<Day>();
        public MenuController()
        {
            Week = DataMock.GetData();
        }

        /// <summary>
        /// Get's a collection of Days
        /// </summary>
        // GET: api/Menu
        public IEnumerable<Day> Get()
        {
            return Week;
        }

        /// <summary>
        /// Gets a specific day
        /// </summary>
        /// <param name="id">the Id of the day</param>
        /// <returns></returns>
        // GET: api/Menu/5
        public Day Get(int id)
        {
            return Week[id];
        }

        // POST: api/Menu
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Menu/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Menu/5
        public void Delete(int id)
        {
        }
    }
}
