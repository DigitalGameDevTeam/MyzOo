using MyzOo.Methods;
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

        public static List<Job> JobList = new List<Job>();

        public void SetData(int id, string Role, int Salary)
        {
            JobCrud job = new JobCrud();
            job.SetData(id, Role, Salary);
        }

        public static List<Job> LoadData()
        {
            JobCrud jobCrud = new JobCrud();
            return jobCrud.LoadData();
        }
    }
}
