using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodServicesMenu.Models
{
    public class Meal
    {
        public MealType MealType { get; set; }
        
        public List<Dish> Dishes { get; set; }
    }
    public enum MealType
    {
        Breakfast,
        Lunch,
        Dinner,
        Snack
    }
    
}
