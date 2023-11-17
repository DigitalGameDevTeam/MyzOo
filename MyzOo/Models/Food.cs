using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyzOo.Classes
{
    internal class Food
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }

        public static List<Food> FoodList = new List<Food>();
        
        public Food (int id, string description, int stock)
        {
            Id = id;
            Description = description;
            Stock = stock;
        }
        public static bool VerifyFood(List<Food> foods)
        {
            if (foods.Count > 0)
                return true;
            else return false;
        }
    }
}
