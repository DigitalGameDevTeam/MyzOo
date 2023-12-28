using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyzOo.Models;
using MyzOo.View;

namespace MyzOo.View
{
    
    public partial class AnimalList_Menu : Form
    {
        
        public AnimalList_Menu()
        {
            InitializeComponent();
        }

        private void AnimalList_Menu_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void populateItems()
        {
            card[] cardList = new card[20];

            int count = 0;

            flowLayoutPanel1.Controls.Clear();

            foreach (var animal in Animal.LoadData())
            {

                cardList[count] = new card();
                cardList[count].Id = animal.Id;
                cardList[count].Name = animal.Name;

                flowLayoutPanel1.Controls.Add(cardList[count]);

                cardList[count].Click += Card_Click;
                    
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            if (sender is card clickedCard)
            {
                int animalID = clickedCard.Id;
                // Now, you have the animalID for the clicked card
                // Do something with the animalID
                MessageBox.Show($"Animal ID: {animalID}");
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            //Hide this Menu and open Main_Men
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Hide();

        }

        private void Minimize_button_Click(object sender, EventArgs e)
        {
            //minimize the form
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void card1_Load(object sender, EventArgs e)
        {

        }

        private void card1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
