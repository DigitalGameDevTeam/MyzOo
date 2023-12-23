using FireSharp.Response;
using MyzOo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyzOo.Methods
{
    internal class JobCrud
    {
        Firebase conn = new Firebase();

        //set datas to database
        public void SetData(int id, string role, int salary)
        {
            try
            {
                Job set = new Job()
                {
                    Role = role,
                    Salary = salary
                };
                var SetData = conn.client.Set("jobs/" + id, set);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //Update datas
        public void UpdateData(int id, string role, int salary)
        {
            try
            {
                Job set = new Job()
                {
                    Role = role,
                    Salary = salary
                };
                var SetData = conn.client.Set("jobs/" + id, set);
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
                var SetData = conn.client.Delete("jobs/" + Description);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //List of the data
        public List<Job> LoadData()
        {
            try
            {
                FirebaseResponse al = conn.client.Get("jobs");
                Dictionary<string, Job> listData = JsonConvert.DeserializeObject<Dictionary<string, Job>>(al.Body.ToString());
                List<Job> allData = new List<Job>();

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
