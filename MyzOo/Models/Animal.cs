using MyzOo.Methods;
using MyzOo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyzOo.Models
{
    internal class Animal
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsDeceased { get; set; }

        internal enum Gender
        {
            Male,
            Female,
        }
        public string AnimalGender { get; set; }

        public int AnimalCell { get; set; }
        public string AnimalFood { get; set; }
        

        public static List<Animal> AnimalList = new List<Animal>();

        
        AnimalCrud animal = new AnimalCrud();

        // Save animal data
        public void SetData(string Id, string Name, DateTime Date, bool IsDecease, string gender, int cell, string food)
        {
            
            animal.SetData(Id, Name, Date, IsDecease, gender, cell, food);

        }

        public void UpdateData(string Id, string Name, DateTime Date, bool IsDecease, string gender, int cell, string food)
        {

            animal.UpdateData(Id, Name, Date, IsDecease, gender, cell, food);

        }

        public void DeleteData(string Id, string Name)
        {

            animal.DeleteData(Id, Name);

        }

        public static List<Animal> LoadData()
        {
            AnimalCrud animalCrud = new AnimalCrud();
            return animalCrud.LoadData();
        }

        public static Animal GetAnimal(string id) 
        {
            AnimalCrud animalCrud = new AnimalCrud();
            return animalCrud.GetAnimal(id);
        }

    }
}
