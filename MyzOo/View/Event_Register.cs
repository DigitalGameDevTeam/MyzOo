using MyzOo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace MyzOo.View
{
    public partial class Event_Register : Form
    {

        private List<int> selectedAnimalIds = new List<int>();

        public Event_Register()
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Hide();
        }

        private void Regist_button_Click(object sender, EventArgs e)
        {
            Event events = new Event();

            // Generate a random ID with 4 numbers
            string id = Guid.NewGuid().ToString();

            // Animal Info
            string description = Description.Text;

            DateTime hourBegin = Event_Date.Value;
            DateTime date = Event_Time.Value;

            int duration = (int)Convert.ToInt64(Duration.Text);

            int numAttendees = (int)Convert.ToInt64(NumAttendees.Text);


            //string gender = Gender_listbox.Text;
            // Retrieve selected cell and food values
            // Food
            //string foodName = Food_listbox.Text;
            //Food animalFood = Food.LoadData().FirstOrDefault(tf => tf.Description == foodName);

            events.SetData(id, description, hourBegin, date, duration, numAttendees, location, selectedAnimalIds)
            this.Close();
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Hide();

        }

        private void populateAnimals()
        {
            card[] cardList = new card[1000];

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
                int animalID = Convert.ToInt32(clickedCard.Id);
                selectedAnimalIds.Add(animalID);
            }
        }

        private void Event_Register_Load(object sender, EventArgs e)
        {

        }
    }
}
