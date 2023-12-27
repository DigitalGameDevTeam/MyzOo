using FireSharp.Response;
using MyzOo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MyzOo.Methods
{
    internal class AnimalCrud
    {
        Firebase conn = new Firebase();

        //set datas to database
        public void SetData(int id, string name, DateTime birthday, bool checkup, bool isDeceased, string animalGender, int animalCell, string animalFood)
        {
            try
            {
                Animal set = new Animal()
                {
                    Name = name,
                    Birthday = birthday,
                    Checkup = checkup,
                    IsDeceased = isDeceased,
                    AnimalGender = animalGender,
                    AnimalCell = animalCell,
                    AnimalFood = animalFood
                };
                var SetData = conn.client.Set("animals/" + id, set);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //Update datas
        public void UpdateData(int id, string name, DateTime birthday, bool checkup, bool isDeceased, string animalGender, int animalCell, string animalFood)
        {
            try
            {
                Animal set = new Animal()
                {
                    Name = name,
                    Birthday = birthday,
                    Checkup = checkup,
                    AnimalCell = animalCell,
                    AnimalFood = animalFood,
                    IsDeceased = isDeceased,
                    AnimalGender = animalGender
                };
                var SetData = conn.client.Set("animals/" + id, set);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //Delete datas
        public void DeleteData(int id)
        {
            try
            {
                var SetData = conn.client.Delete("animals/" + id);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //List of the datas
        public List<Animal> LoadData()
        {
            try
            {
                FirebaseResponse al = conn.client.Get("animals");
                Dictionary<string, Animal> listData = JsonConvert.DeserializeObject<Dictionary<string, Animal>>(al.Body.ToString());
                List<Animal> allData = new List<Animal>();

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

        public Animal GetAnimal(int id)
        {
            try
            {
                var GetData = conn.client.Get("animals/" + id);

                if (GetData.Body == "null")
                {
                    Console.WriteLine($"No data found for animal with ID {id}");
                    return null;
                }

                Animal animal = JsonConvert.DeserializeObject<Animal>(GetData.Body.ToString());
                return animal;
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
                return null;
            }
        }
    }
}
