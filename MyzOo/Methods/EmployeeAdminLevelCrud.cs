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
    internal class EmployeeAdminLevelCrud
    {
        private readonly Firebase conn = new Firebase();

        // Register new Employee function
        public void SetData(string id, string description)
        {
            try
            {
                EmployeeAdminLevel set = new EmployeeAdminLevel()
                {
                    id = id,
                    description = description
                };
                var SetData = conn.client.Set("employee_admin_level/" + id, set);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        // Get function by name
        public string getIdByDescription(string description)
        {
            try
            {
                var data = EmployeeAdminLevel.LoadData();
                foreach (var element in data)
                {
                    if (element == null)
                        continue;

                    if (element.description == description)
                        return element.id;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Could not find employee admin level");
            }

            return "";
        }

        // Load data into a List instance
        public List<EmployeeAdminLevel> LoadData()
        {
            try
            {
                FirebaseResponse al = conn.client.Get("employee_admin_level/");
                List<EmployeeAdminLevel> listData = JsonConvert.DeserializeObject<List<EmployeeAdminLevel>>(al.Body.ToString());
                if (listData == null || listData.Count == 0)
                    return null;

                List<EmployeeAdminLevel> allData = new List<EmployeeAdminLevel>();
                foreach (var kvp in listData)
                {
                    allData.Add(kvp);
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
