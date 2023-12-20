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
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public bool Checkup { get; set; }
        public bool IsDeceased { get; set; }

        internal enum Gender
        {
            Male,
            Female,
        }
        public Gender AnimalGender { get; set; }

        // Reference to Cell and Food
        public Cell AnimalCell { get; set; }
        public string AnimalFood { get; set; }
        

        public static List<Animal> AnimalList = new List<Animal>();

        // Save animal data
        public void SetData(int Id, string Name, DateTime Date, bool Checkup, bool IsDecease, Gender gender, Cell cell, string food)
        {
            AnimalCrud animal = new AnimalCrud();
            animal.SetData(Id, Name, Date, Checkup, IsDecease, gender, cell, food);

        }
    }
}
