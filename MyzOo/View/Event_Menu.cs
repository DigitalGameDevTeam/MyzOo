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
    public partial class Event_Menu : Form
    {
        private string eventId;
        private Event events;
        private List<Event> eventAnimals;

        string userId;
        public Event_Menu(string userID)
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu(userId);
            main_Menu.Show();
            this.Hide();
        }

        private void Event_Menu_Load(object sender, EventArgs e)
        {
            //eventAnimals = Event.GetEvent(eventId);

            foreach (var animal in Animal.LoadData())
            {

                AnimalCheckedListBox.Items.Add(animal.Name);

            }

            /*foreach (var animal in eventAnimals)
            {
                int index = AnimalCheckedListBox.FindString(animal.Name);
                if (index != -1)
                {
                    AnimalCheckedListBox.SetItemChecked(index, true);
                }
            }*/

            Description.Text = events.Description;
            textBox1.Text = events.NumAttendees.ToString();
            Duration.Text = events.Duration.ToString();
            textBox2.Text = events.Location;
            Date.Value = events.Date;
            Hour.Value = events.HourBegin;
        }
    }
}
