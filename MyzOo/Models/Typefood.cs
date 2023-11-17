using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyzOo.Models
{
    internal class Typefood
    {
        public int Id { get; set; }
        public string Type { get; set; }

    public Typefood (int id, string type)
        {
            Id = id;
            Type = type;
        }
    }
}
