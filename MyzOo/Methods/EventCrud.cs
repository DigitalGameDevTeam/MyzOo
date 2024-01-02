using FireSharp.Response;
using MyzOo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyzOo.Methods
{
    internal class EventCrud
    {
        Firebase conn = new Firebase();

        //set datas to database
        public void SetData(string id, string name, DateTime birthday, bool isDeceased, string animalGender, int animalCell, string animalFood)
        {
            try
            {
                Event set = new Event()
                {
                    Id = id,
                    Name = name,
                    Birthday = birthday,
                    IsDeceased = isDeceased,
                    AnimalGender = animalGender,
                    AnimalCell = animalCell,
                    AnimalFood = animalFood
                };
                var SetData = conn.client.Set("animals/" + id, set);

                MessageBox.Show($"Evento {description} Registado com sucesso", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //Update datas
        public void UpdateData(string id, string name, DateTime birthday, bool isDeceased, string animalGender, int animalCell, string animalFood)
        {
            try
            {
                Animal set = new Animal()
                {
                    Id = id,
                    Name = name,
                    Birthday = birthday,
                    AnimalCell = animalCell,
                    AnimalFood = animalFood,
                    IsDeceased = isDeceased,
                    AnimalGender = animalGender
                };
                var SetData = conn.client.Update("animals/" + id, set);

                MessageBox.Show($"Animal {name} Atualizado com sucesso", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //Delete datas
        public void DeleteData(string id, string name)
        {
            try
            {
                var SetData = conn.client.Delete("animals/" + id);

                MessageBox.Show($"Animal {name} Apagado com sucesso", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
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

        public Animal GetAnimal(string id)
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
