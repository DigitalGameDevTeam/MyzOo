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
    public partial class CellList : Form
    {
        string userId;
        public CellList(string userID)
        {
            InitializeComponent();
            userId = userID;
        }

        private void CellList_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void populateItems()
        {
            card[] cardList = new card[1000];

            int count = 0;

            flowLayoutPanel1.Controls.Clear();

            foreach (var cell in Cell.LoadData())
            {

                cardList[count] = new card();
                cardList[count].Id = cell.Id;
                cardList[count].Name = cell.Number.ToString();

                flowLayoutPanel1.Controls.Add(cardList[count]);

                cardList[count].Click += Card_Click;

            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            if (sender is card clickedCard)
            {
                string cellId = clickedCard.Id;

                CellData_Menu cellData = new CellData_Menu(cellId, userId);
                cellData.Show();
                this.Hide();
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            //Hide this Menu and open Main_Men
            Main_Menu main_Menu = new Main_Menu(userId);
            main_Menu.Show();
            this.Hide();

        }

        private void Minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
