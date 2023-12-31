using MyzOo.Methods;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyzOo.Models
{
    internal class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Password { get; set; }
        public int Adminlevel { get; set; }  
        public int EmployeeJob { get; set; }

        public static List<Employee> EmployeeList = new List<Employee>();

        public void SetData(string id, string name, DateTime birthday, string password, int adminLevel, int employeeJob)
        {
            EmployeeCrud employee = new EmployeeCrud();
            employee.SetData(id, name, birthday, password, adminLevel, employeeJob);
        }

        public static List<Employee> LoadData()
        {
            EmployeeCrud employeeCrud = new EmployeeCrud();
            return employeeCrud.LoadData();
        }
    }
}
