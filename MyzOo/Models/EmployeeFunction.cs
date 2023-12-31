using MyzOo.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyzOo.Models
{
    internal class EmployeeFunction
    {
        public string id { get; set; }
        public string description {  get; set; }

        public void SetData(string id, string description)
        {
            EmployeeFunctionCrud obj = new EmployeeFunctionCrud();
            obj.SetData(id, description);
        }

        public static List<EmployeeFunction> LoadData()
        {
            EmployeeFunctionCrud employeeCrud = new EmployeeFunctionCrud();
            return employeeCrud.LoadData();
        }

    }
}
