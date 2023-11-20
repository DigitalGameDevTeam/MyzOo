using MyzOo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyzOo.Models
{
    internal class TypeFood
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public static List<TypeFood> TypeFoodList = new List<TypeFood>();

        public TypeFood ()
        {
            Id = 1;
            Type = "carne";
        }
    }
}
