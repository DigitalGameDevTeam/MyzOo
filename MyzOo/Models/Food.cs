using FireSharp.Response;
using MyzOo.Methods;
using MyzOo.Models;
using Newtonsoft.Json;
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
        public string TypeFood { get; set; }
        public int Stock { get; set; }

        public static List<Food> FoodList = new List<Food>();

        public void SetData(int id, string description, string typeFood, int stock)
        {
            FoodCrud food = new FoodCrud();
            food.SetData(id, description, typeFood, stock);
        }

        public void UpdateData(int id, string description, string typeFood, int stock)
        {
            FoodCrud food = new FoodCrud();
            food.UpdateData(id, description, typeFood, stock);
        }

        public void DeleteData(int id, string description)
        {
            FoodCrud food = new FoodCrud();
            food.DeleteData(id, description);
        }

        public static List<Food> LoadData()
        {
            FoodCrud foodCrud = new FoodCrud();
            return foodCrud.LoadData();
        }

        public static Food GetFood(int id)
        {
            FoodCrud foodCrud = new FoodCrud();
            return foodCrud.GetFood(id);
        }
    }
}
