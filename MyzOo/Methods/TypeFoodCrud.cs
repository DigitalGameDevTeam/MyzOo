using FireSharp.Response;
using MyzOo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyzOo.Methods
{
    internal class TypeFoodCrud
    {
        Firebase conn = new Firebase();

        //set data to database
        public void SetData(int id, string type)
        {
            try
            {
                TypeFood set = new TypeFood()
                {             
                    Type = type
                };
                var SetData = conn.client.Set("typefood/" + id, set);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
        //Update data
        public void UpdateData(int id, string type)
        {
            try
            {
                TypeFood set = new TypeFood()
                {
                    Type = type
                };
                var UpdateData = conn.client.Update("typefood/" + id, set);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //Delete data
        public void DeleteTeam(int id)
        {
            try
            {
                var SetData = conn.client.Delete("typefood/" + id);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //List of the data
        public List<TypeFood> LoadData()
        {
            try
            {
                FirebaseResponse al = conn.client.Get("typefood");
                Dictionary<string, TypeFood> listData = JsonConvert.DeserializeObject<Dictionary<string, TypeFood>>(al.Body.ToString());
                List<TypeFood> allData = new List<TypeFood>();

                foreach (var kvp in listData)
                {
                    int id = Convert.ToInt32(kvp.Key);
                    kvp.Value.Id = id;

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
