using MyzOo.Methods;
using MyzOo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyzOo.Models.Animal;

namespace MyzOo.Models
{
    internal class Food
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public TypeFood TypeFood { get; set; }
        public int Stock { get; set; }

        public static List<Food> FoodList = new List<Food>();

        // Save animal data
        public void SetData(int Id, string Description, TypeFood typeFood, int Stock)
        {
            FoodCrud food = new FoodCrud();
            food.SetData(Id, Description, typeFood, Stock);

        }
    }
}
