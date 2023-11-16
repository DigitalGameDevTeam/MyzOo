using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MyzOo.Classes
{
    internal class Cell
    {
        public int Id {  get; set; }
        public bool Cleaning { get; set; }
        public int Numero {  get; set; }
        public Cell (int id,bool cleaning, int numero)
        {
            Id = id;
            Cleaning = cleaning;
            Numero = numero;
        }

    }
}
