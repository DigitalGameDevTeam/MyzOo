using MyzOo.Methods;
using MyzOo.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyzOo.Models.Animal;

namespace MyzOo.Models
{
    internal class TypeFood
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public static List<TypeFood> TypeFoodList = new List<TypeFood>();

        public void SetData(int id, string type)
        {
            TypeFoodCrud typeFoodCrud = new TypeFoodCrud();
            typeFoodCrud.SetData(id, type);
        }
        public static List<TypeFood> LoadData()
        {
            TypeFoodCrud typeFoodCrud = new TypeFoodCrud();
            return typeFoodCrud.LoadData();
        }
    }
}
