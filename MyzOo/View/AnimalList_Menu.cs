using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            for (int i = 0; i < cardList.Length; i++)
            {

                cardList[i] = new card();
                cardList[i].Name = "Teste";

                //if(flowLayoutPanel1.Controls.Count > 0)
                //{
                //    flowLayoutPanel1.Controls.Clear();
                //}
                //else
                flowLayoutPanel1.Controls.Add(cardList[i]);
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
    }
}
