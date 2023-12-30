using MyzOo.Methods;
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
        public int Id { get; set; }
        public int Number {  get; set; }
        public bool Cleaning { get; set; }
        public string Description { get; set; }

        public static List<Cell> CellList = new List<Cell>();

        public void SetData(int id, int number, bool cleaning, string description)
        {
            CellCrud cell = new CellCrud();
            cell.SetData(id, number, cleaning, description);
        }

        public void UpdateData(int id, int number, bool cleaning, string description)
        {
            CellCrud cell = new CellCrud();
            cell.UpdateData(id, number, cleaning, description);
        }

        public void DeleteData(int id)
        {
            CellCrud cell = new CellCrud();
            cell.DeleteData(id);
        }

        public static List<Cell> LoadData()
        {
            CellCrud cellCrud = new CellCrud();
            return cellCrud.LoadData();
        }

        public static Cell GetCell(int id)
        {
            CellCrud cellCrud = new CellCrud();
            return cellCrud.GetCell(id);
        }
    }
}
