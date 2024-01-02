using MyzOo.Models;
using MyzOo.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyzOo
{
    public partial class EventList : Form
    {
        string userId;
        public EventList(string userID)
        {
            InitializeComponent();
            this.userId = userID;
        }

        private void Minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void EventList_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            //Hide this Menu and open Main_Men
            Main_Menu main_Menu = new Main_Menu(userId);
            main_Menu.Show();
            this.Hide();
        }

        private void populateItems()
        {
            card[] cardList = new card[1000];

            int count = 0;

            flowLayoutPanel1.Controls.Clear();

            foreach (var events in Event.LoadData())
            {
                if (events != null)
                {
                    cardList[count] = new card();
                    cardList[count].Id = events.Id;
                    cardList[count].Name = events.Description;

                    flowLayoutPanel1.Controls.Add(cardList[count]);

                    cardList[count].Click += Card_Click;
                }
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            if (sender is card clickedCard)
            {
                string eventID = clickedCard.Id;

                Event_Menu event_Menu = new Event_Menu(eventID);
                event_Menu.Show();
                this.Hide();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void card1_Load(object sender, EventArgs e)
        {

        }
    }
}
