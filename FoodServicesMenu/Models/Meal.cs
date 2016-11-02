using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace FoodServicesMenu.Models
{
    public class Meal
    {
        [IgnoreDataMember]
        [JsonIgnore]
        public MealType MealType { get; set; }
        public string MealTiming { get { return MealType.GetName(typeof(MealType), MealType); } }
        public List<Dish> Dishes { get; set; }
    }
    public enum MealType
    {
        Breakfast,
        Lunch,
        Dinner,
        Snack,
        Other
    }
    
}
