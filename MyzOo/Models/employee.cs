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
        public Job EmployeeJob { get; set; }
        public Employee(int id, string name, DateTime birthday, bool checkup,string password, int adminlevel)
        {
            Id = id;
            Name = name;
            Birthday = birthday;
            Checkup = checkup;
            Password = password;
            Adminlevel = adminlevel;
        }
    }
}
