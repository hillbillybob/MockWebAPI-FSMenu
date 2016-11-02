using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace FoodServicesMenu.Models
{
    public class Day
    {
        public int Id { get; set; }
        [IgnoreDataMember]
        [JsonIgnore]
        public DateTime Date { get; set; }
        public string ShortDate { get { return Date.ToShortDateString(); } }
        public List<Meal> Meals { get; set; }
        public string Comments { get; set; }
    }
    
}
