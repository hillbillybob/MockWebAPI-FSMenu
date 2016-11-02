using System;
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
            List<Dish> MorningDishes = new List<Dish>();
            List<Dish> DayDishes = new List<Dish>();
            List<Dish> EveDishes = new List<Dish>();
            List<Meal> Meals = new List<Meal>();
            
            MorningDishes.Add(new Models.Dish { Name = "Sausage & Egg skillet", Description = "Ground Sausage, eggs, bell pepers, onions, and shredded Colby Jack cheese", AllergenType = AllergenType.Gluten });
            MorningDishes.Add(new Models.Dish { Name = "Fruit Oatmeal", Description = "Seel cut oats with fresh apple and mango.", AllergenType = AllergenType.Vegetarian });
            DayDishes.Add(new Models.Dish { Name = "Ceasar Salad", Description = "Iceberg lettus with cesar dressing", AllergenType = AllergenType.Vegan });
            DayDishes.Add(new Models.Dish { Name = "Chicken Fajitas", Description = "Marinated Chicken strips grilled with onions and bell peppers served with warm corn tortillas", AllergenType = AllergenType.Halal });
            EveDishes.Add(new Models.Dish { Name = "Bierocks", Description = "German style bierocks with cabbage, sausage, and spices", AllergenType = AllergenType.LowSodium });
            EveDishes.Add(new Models.Dish { Name = "Red Beans and Rice", Description = "Red beans, white rice, corn, jalepenos, spices", AllergenType = AllergenType.Vegan });

            Meals.Add(new Meal { Dishes = MorningDishes, MealType = MealType.Breakfast });
            Meals.Add(new Meal { Dishes = DayDishes, MealType = MealType.Lunch });
            Meals.Add(new Meal { Dishes = EveDishes, MealType = MealType.Dinner });

            Week.Add(new Day { Date = DateTime.Now, Meals = Meals, Comments = "Today", Id  = 1 });
            Week.Add(new Day { Date = DateTime.Now.AddDays(1), Meals = Meals, Comments = "Today + 1", Id = 2});
            Week.Add(new Day { Date = DateTime.Now.AddDays(2), Meals = Meals, Comments = "Today + 2", Id = 3 });
            Week.Add(new Day { Date = DateTime.Now.AddDays(3), Meals = Meals, Comments = "Today + 3", Id = 4 });
            Week.Add(new Day { Date = DateTime.Now.AddDays(4), Meals = Meals, Comments = "Today + 4", Id = 5 });
            Week.Add(new Day { Date = DateTime.Now.AddDays(5), Meals = Meals, Comments = "Today + 5", Id=6 });
            Week.Add(new Day { Date = DateTime.Now.AddDays(6), Meals = Meals, Comments = "Today + 6", Id=7 });

        }
        // GET: api/Menu
        public IEnumerable<Day> Get()
        {
            return Week;
        }

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
