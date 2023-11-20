using FireSharp.Response;
using MyzOo.Models;
using MyzOo.Models;
using MyzOo.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MyzOo.Methods
{
    internal class FoodCrud
    {
        Firebase conn = new Firebase();

        //set datas to database
        public void SetData(int id, string description, TypeFood typefood, int stock)
        {
            try
            {
                Food set = new Food()
                {
                    Id = id,               
                    Description = description,
                    TypeFood = typefood,
                    Stock = stock
                };
                var SetData = conn.client.Set("foods/" + description, set);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //Update datas
        public void UpdateData(int id, string description, TypeFood typefood, int stock)
        {
            try
            {
                Food set = new Food()
                {
                    Id = id,
                    Description = description,
                    TypeFood = typefood,
                    Stock= stock
                };
                var SetData = conn.client.Set("foods/" + description, set);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //Delete datas
        public void DeleteTeam(string Description)
        {
            try
            {
                var SetData = conn.client.Delete("food/" + Description);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //List of the datas
        public Dictionary<string, Food> LoadData()
        {
            try
            {
                FirebaseResponse al = conn.client.Get("foods");
                Dictionary<string, Food> ListData = JsonConvert.DeserializeObject<Dictionary<string, Food>>(al.Body.ToString());
                return ListData;
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
                return null;
            }
        }
    }
}
