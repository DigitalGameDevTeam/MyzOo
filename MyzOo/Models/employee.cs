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
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public bool Checkup { get; set; }
        public string Password { get; set; }
        public int Adminlevel { get; set; }  
        public string EmployeeJob { get; set; }

        public static List<Employee> EmployeeList = new List<Employee>();

        public void SetData(int id, string name, DateTime birthday, bool checkup, string password, int adminLevel, string employeeJob)
        {
            EmployeeCrud employee = new EmployeeCrud();
            employee.SetData(id, name, birthday, checkup, password, adminLevel, employeeJob);
        }

        public static List<Employee> LoadData()
        {
            EmployeeCrud employeeCrud = new EmployeeCrud();
            return employeeCrud.LoadData();
        }
    }
}
