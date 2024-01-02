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
        public void SetData(string id, string descrition, DateTime hourBegin, DateTime date, int duration, int numAttendees, string location, List<int> animalId)
        {
            try
            {
                Event set = new Event()
                {
                    Id = id,
                    Description = descrition,
                    HourBegin = hourBegin,
                    Date = date,
                    Duration = duration,
                    NumAttendees = numAttendees,
                    Location = location,
                    AnimalId = animalId
                };

                var SetData = conn.client.Set("events/" + id, set);

                MessageBox.Show($"Evento {descrition} Registado com sucesso", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //Update datas
        public void UpdateData(string id, string descrition, DateTime hourBegin, DateTime date, int duration, int numAttendees, string location, List<int> animalId)
        {
            try
            {
                Event set = new Event()
                {
                    Id = id,
                    Description = descrition,
                    HourBegin = hourBegin,
                    Date = date,
                    Duration = duration,
                    NumAttendees = numAttendees,
                    Location = location,
                    AnimalId = animalId
                };
                var SetData = conn.client.Update("events/" + id, set);

                MessageBox.Show($"Evento {descrition} Atualizado com sucesso", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //Delete datas
        public void DeleteData(string id, string description)
        {
            try
            {
                var SetData = conn.client.Delete("events/" + id);

                MessageBox.Show($"Evento {description} Apagado com sucesso", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //List of the datas
        public List<Event> LoadData()
        {
            try
            {
                FirebaseResponse al = conn.client.Get("events");
                Dictionary<string, Event> listData = JsonConvert.DeserializeObject<Dictionary<string, Event>>(al.Body.ToString());
                List<Event> allData = new List<Event>();

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

        // Get Event info by Id
        public Event GetEvent(string id, string description)
        {
            try
            {
                var GetData = conn.client.Get("events/" + id);

                if (GetData.Body == "null")
                {
                    Console.WriteLine($"Não foi encontrado nenhum Evento com a descrição {description}");
                    return null;
                }

                Event events = JsonConvert.DeserializeObject<Event>(GetData.Body.ToString());
                return events;
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
                return null;
            }
        }
    }

}
