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
        public void SetData(int number, bool cleaning)
        {
            try
            {
                Cell set = new Cell()
                {
                    Number = number,
                    Cleaning = cleaning
                };
                var SetData = conn.client.Set("cells/" + number, set);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //Update datas
        public void UpdateData(int number, bool cleaning)
        {
            try
            {
                Cell set = new Cell()
                {
                    Number = number,
                    Cleaning = cleaning
                };
                var SetData = conn.client.Set("cells/" + number, set);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //Delete datas
        public void DeleteTeam(string Description)
        {
            try
            {
                var SetData = conn.client.Delete("cells/" + Description);
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
