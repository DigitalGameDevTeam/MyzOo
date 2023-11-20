using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MyzOo.Models
{
    internal class Cell
    {
        public int Number {  get; set; }
        public bool Cleaning { get; set; }


        public static List<Cell> CellList = new List<Cell>();
        public Cell (int number, bool cleaning)
        {
            Number = number;
            Cleaning = cleaning;
        }

        public static bool VerifyCell(List<Cell> cells)
        {
            if (cells.Count > 0)
                return true;
            else return false;
        }
    }
}
