using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyzOo.Models
{
    internal class Job
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public int Salary { get; set; }

    public Job (int id, string role, int salary)
        {
            Id = id;
            Role = role;
            Salary = salary;
        }
    }
}
