using MyzOo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyzOo.View
{
    public partial class CellData_Menu : Form
    {
        string userId;

        private string cellId;
        private Cell cell;

        public CellData_Menu(string id, string userID)
        {
            InitializeComponent();
            cellId = id;
            userId = userID;
        }

        private void VerCela_Menu_Load(object sender, EventArgs e)
        {
            Cellnumber_Number.Enabled = true;
            CellDescription_textbox.Enabled = true;
            Checkup_Box.Enabled = true;

            cell = Cell.GetCell(cellId);

            Cellnumber_Number.Text = cell.Number.ToString();
            CellDescription_textbox.Text = cell.Description;
            Checkup_Box.Enabled = cell.Cleaning;
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            string id = cellId;

            int number = (int)Cellnumber_Number.Value;
            string description = CellDescription_textbox.Text;
            bool checkup = Checkup_Box.Enabled;

            cell.UpdateData(id, number, checkup, description);

            CellList cellList = new CellList(userId);
            cellList.Show();
            this.Hide();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            string id = cellId;
            int number = cell.Number;

            cell.DeleteData(id);

            CellList cellList = new CellList(userId);
            cellList.Show();
            this.Hide();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            //hide this Menu and open Main Menu
            CellList cellList = new CellList(userId);
            cellList.Show();
            this.Hide();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
