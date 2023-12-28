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
        public void SetData(int id, string description, int typefood, int stock)
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
                var SetData = conn.client.Set("foods/" + id, set);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //Update datas
        public void UpdateData(int id, string description, int typefood, int stock)
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
                var SetData = conn.client.Set("foods/" + id, set);
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
                var SetData = conn.client.Delete("foods/" + Description);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //List of the data
        public List<Food> LoadData()
        {
            try
            {
                FirebaseResponse al = conn.client.Get("foods");
                Dictionary<string, Food> listData = JsonConvert.DeserializeObject<Dictionary<string, Food>>(al.Body.ToString());
                List<Food> allData = new List<Food>();

                // verify
                foreach (var kvp in listData)
                {
                    allData.Add(kvp.Value);
                }
                
                return allData;
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
                return null;
            }
        }
    }
}
