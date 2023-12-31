using FireSharp.Response;
using MyzOo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MyzOo.Methods
{
    internal class EmployeeFunctionCrud
    {
        private readonly Firebase conn = new Firebase();

        // Register new Employee function
        public void SetData(string id, string description)
        {
            try
            {
                EmployeeFunction set = new EmployeeFunction()
                {
                    id = id,
                    description = description
                };
                var SetData = conn.client.Set("employee_function/" + id, set);
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
                var data = EmployeeFunction.LoadData();
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
                Console.WriteLine("Could not find employee function");
            }

            return "";
        }

        // Load data into a List instance
        public List<EmployeeFunction> LoadData()
        {
            try
            {
                FirebaseResponse al = conn.client.Get("employee_function/");
                List<EmployeeFunction> listData = JsonConvert.DeserializeObject<List<EmployeeFunction>>(al.Body.ToString());
                if (listData == null || listData.Count == 0)
                    return null;

                List<EmployeeFunction> allData = new List<EmployeeFunction>();
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
