using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyzOo.Classes
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
        public Food AnimalFood { get; set; }


        public Animal(int id, string name, DateTime birthday, bool checkup, Cell animalCell, Food animalFood, bool isDeceased, Gender animalGender)
        {
            Id = id;
            Name = name;
            Birthday = birthday;
            Checkup = checkup;
            AnimalCell = animalCell;
            AnimalFood = animalFood;
            IsDeceased = isDeceased;
            AnimalGender = animalGender;
        }

        public void ShowData()
        {
            Console.Write("", Id, Name, Birthday, Checkup, AnimalCell.Id, AnimalFood.Id);
        }
    }
}
