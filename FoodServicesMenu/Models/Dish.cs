using System;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace FoodServicesMenu.Models
{
    public class Dish
    {
        [IgnoreDataMember]
        [JsonIgnore]
        public AllergenType AllergenType { get; set; }
        public string Allergen { get { return AllergenType.GetName(typeof(AllergenType), AllergenType); } }

        public string Name { get; set; }
        public string Description { get; set; }
    }
    [Flags]
    public enum AllergenType
    {
        Vegan = 0x01,
        Gluten = 0x02,
        Halal = 0x03,
        Vegetarian = 0x04,
        LowSodium = 0x05,
        None = 0x00
    }
}
