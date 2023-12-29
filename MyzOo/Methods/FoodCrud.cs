using FireSharp.Response;
using MyzOo.Models;
using MyzOo.Models;
using MyzOo.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Xml.Linq;

namespace MyzOo.Methods

{
    internal class FoodCrud
    {
        Firebase conn = new Firebase();

        //set datas to database
        public void SetData(int id, string description, string typefood, int stock)
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

                MessageBox.Show($"Comida {description} Registada com sucesso", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //Update datas
        public void UpdateData(int id, string description, string typefood, int stock)
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
                var SetData = conn.client.Update("foods/" + id, set);

                MessageBox.Show($"Comida {description} Atualizada com sucesso", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //Delete datas
        public void DeleteData(int id, string description)
        {
            try
            {
                var SetData = conn.client.Delete("foods/" + id);

                MessageBox.Show($"Comida {description} Apagado com sucesso", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);

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

                if (listData != null)
                {
                    // verify
                    foreach (var kvp in listData)
                    {
                        allData.Add(kvp.Value);
                    }
                }
                else
                {
                    MessageBox.Show("Vazio", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

                return allData;
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
                return null;
            }
        }

        public Food GetFood(int id)
        {
            try
            {
                var GetData = conn.client.Get("foods/" + id);

                if (GetData.Body == "null")
                {
                    Console.WriteLine($"No data found for foods with ID {id}");
                    return null;
                }

                Food food = JsonConvert.DeserializeObject<Food>(GetData.Body.ToString());
                return food;
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
                return null;
            }
        }
    }
}
