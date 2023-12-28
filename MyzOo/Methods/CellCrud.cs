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
    internal class CellCrud
    {
        Firebase conn = new Firebase();

        //set datas to database
        public void SetData(int id, int number, bool cleaning, string description)
        {
            try
            {
                Cell set = new Cell()
                {
                    Id = id,
                    Number = number,
                    Cleaning = cleaning,
                    Description = description
                };
                var SetData = conn.client.Set("cells/" + id, set);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //Update datas
        public void UpdateData(int id, int number, bool cleaning, string description)
        {
            try
            {
                Cell set = new Cell()
                {
                    Id = id,
                    Number = number,
                    Cleaning = cleaning,
                    Description = description
                };
                var SetData = conn.client.Set("cells/" + id, set);
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
                var SetData = conn.client.Delete("cells/" + id);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //List of the data
        public List<Cell> LoadData()
        {
            try
            {
                FirebaseResponse al = conn.client.Get("cells");
                Dictionary<string, Cell> listData = JsonConvert.DeserializeObject<Dictionary<string, Cell>>(al.Body.ToString());
                List<Cell> allData = new List<Cell>();

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
    }
}
