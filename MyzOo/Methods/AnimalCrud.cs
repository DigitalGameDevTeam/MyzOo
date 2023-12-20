using FireSharp.Response;
using MyzOo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using static MyzOo.Models.Animal;

namespace MyzOo.Methods
{
    internal class AnimalCrud
    {
        Firebase conn = new Firebase();

        //set datas to database
        public void SetData(int id, string name, DateTime birthday, bool checkup, bool isDeceased, Gender animalGender, Cell animalCell, string animalFood)
        {
            try
            {
                Animal set = new Animal()
                {
                    //Id = id,
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
        public void UpdateData(int id, string name, DateTime birthday, bool checkup, bool isDeceased, Gender animalGender, Cell animalCell, string animalFood)
        {
            try
            {
                Animal set = new Animal()
                {
                    //Id = id,
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
        public void DeleteData(string id)
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
        public Dictionary<string, Animal> LoadData()
        {
            try
            {
                FirebaseResponse al = conn.client.Get("animals");
                Dictionary<string, Animal> ListData = JsonConvert.DeserializeObject<Dictionary<string, Animal>>(al.Body.ToString());
                return ListData;
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
