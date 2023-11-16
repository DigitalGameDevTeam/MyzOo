using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyzOo.Classes
{
    internal class Food
    {
        public int Id { get; set; }
        public string Typefood { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public Food (int id, string typefood, string description)
        {
            Id = id;
            Typefood = typefood;
            Description = description;
            Stock = Stock;

        }
    }
}
