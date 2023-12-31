using MyzOo.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyzOo.Models
{
    internal class EmployeeAdminLevel
    {
        public string id { get; set; }
        public string description { get; set; }

        public void SetData(string id, string description)
        {
            EmployeeAdminLevelCrud obj = new EmployeeAdminLevelCrud();
            obj.SetData(id, description);
        }

        public static List<EmployeeAdminLevel> LoadData()
        {
            EmployeeAdminLevelCrud adminLevelCrud = new EmployeeAdminLevelCrud();
            return adminLevelCrud.LoadData();
        }
    }
}
