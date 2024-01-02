using FireSharp.Response;
using MyzOo.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace MyzOo.Methods
{
    internal class EmployeeCrud
    {
        Firebase conn = new Firebase();

        //set datas to database
        public void SetData(string id, string name, DateTime birthday, string password, int adminLevel, int employeeJob)
        {
            try
            {
                Employee set = new Employee()
                {
                    Id = id,
                    Name = name,
                    Birthday = birthday,
                    Password = password,
                    Adminlevel = adminLevel,
                    EmployeeJob = employeeJob
                };
                var SetData = conn.client.Set("employees/" + id, set);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        public string Login(string username, string password)
        {
            List<Employee> employees = this.LoadData();
            foreach (Employee c in employees)
            {
                if (c.Name == username && c.Password == Client.encryptSHA512(password))
                    return c.Id.ToString();
            }

            return null;
        }

        //Update datas
        public void UpdateData(string id, string name, DateTime birthday, string password, int adminLevel, int employeeJob)
        {
            try
            {
                Employee set = new Employee()
                {
                    Id = id,
                    Name = name,
                    Birthday = birthday,
                    Password = password,
                    Adminlevel = adminLevel,
                    EmployeeJob = employeeJob
                };
                var SetData = conn.client.Set("employees/" + id, set);
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
                var SetData = conn.client.Delete("employees/" + id);

                MessageBox.Show($"Funcionario {name} Apagado com sucesso", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        //List of the data
        public List<Employee> LoadData()
        {
            try
            {
                FirebaseResponse al = conn.client.Get("employees");
                Dictionary<string, Employee> listData = JsonConvert.DeserializeObject<Dictionary<string, Employee>>(al.Body.ToString());
                List<Employee> allData = new List<Employee>();

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

        public Employee GetEmployee(string id)
        {
            try
            {
                var GetData = conn.client.Get("employees/" + id);

                if (GetData.Body == "null")
                {
                    Console.WriteLine($"No data found for employee with ID {id}");
                    return null;
                }

                Employee employee = JsonConvert.DeserializeObject<Employee>(GetData.Body.ToString());
                return employee;
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
                return null;
            }
        }
    }
}
