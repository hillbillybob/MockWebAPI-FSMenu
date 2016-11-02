using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodServicesMenu.Models
{
    public class Dish
    {
        public AllergenType AllergenType { get; set; }

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
        LowSodium = 0x05
    }
}
