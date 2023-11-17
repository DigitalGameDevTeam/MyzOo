using FireSharp.Response;
using MyzOo.Classes;
using MyzOo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static MyzOo.Classes.Animal;

namespace MyzOo.Methods
{
    internal class AnimalCrud
    {
        Firebase conn = new Firebase();

        //set datas to database
        public void SetData(int id, string name, DateTime birthday, bool checkup, int animalCell, int animalFood, bool isDeceased, Gender animalGender)
        {
            try
            {
                Animal set = new Animal()
                {
                    Id = id,
                    Name = name,
                    Birthday = birthday,
                    Checkup = checkup,
                    AnimalCell = animalCell,
                    AnimalFood = animalFood,
                    IsDeceased = isDeceased,
                    AnimalGender = animalGender
                };
                var SetData = conn.client.Set("animals/" + name, set);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //Update datas
        public void UpdateData(int id, string name, DateTime birthday, bool checkup, int animalCell, int animalFood, bool isDeceased, Gender animalGender)
        {
            try
            {
                Animal set = new Animal()
                {
                    Id = id,
                    Name = name,
                    Birthday = birthday,
                    Checkup = checkup,
                    AnimalCell = animalCell,
                    AnimalFood = animalFood,
                    IsDeceased = isDeceased,
                    AnimalGender = animalGender
                };
                var SetData = conn.client.Set("animals/" + name, set);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //Delete datas
        public void DeleteTeam(string Name)
        {
            try
            {
                var SetData = conn.client.Delete("people/" + Name);
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
                FirebaseResponse al = conn.client.Get("people");
                Dictionary<string, Animal> ListData = JsonConvert.DeserializeObject<Dictionary<string, Animal>>(al.Body.ToString());
                return ListData;
            }
            catch (Exception)
            {
                Console.WriteLine("bir hata ile karşılaşıldı");
                return null;
            }
        }
    }
}
