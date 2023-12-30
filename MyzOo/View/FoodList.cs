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
    public partial class FoodList : Form
    {
        public FoodList()
        {
            InitializeComponent();
        }

        private void Food_List_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void populateItems()
        {
            card[] cardList = new card[1000];

            int count = 0;

            flowLayoutPanel1.Controls.Clear();

            foreach (var food in Food.LoadData())
            {

                cardList[count] = new card();
                cardList[count].Id = food.Id;
                cardList[count].Name = food.Description;

                flowLayoutPanel1.Controls.Add(cardList[count]);

                cardList[count].Click += Card_Click;

            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            if (sender is card clickedCard)
            {
                int animalID = clickedCard.Id;

                FoodData_Menu see_Food_Menu = new FoodData_Menu(animalID);
                see_Food_Menu.Show();
                this.Hide();
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu();
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

        private void card1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
