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
        string userId;
        private List<string> selectedAnimalIds = new List<string>();

        public Event_Register(string userID)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu(userId);
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

            string location = Location.Text;


            events.SetData(id, description, hourBegin, date, duration, numAttendees, location, selectedAnimalIds);


            Main_Menu main_Menu = new Main_Menu(userId);
            main_Menu.Show();
            this.Hide();

        }

        private void populateAnimals()
        {
            checkedListBox1.Items.Clear();

            foreach (var animal in Animal.LoadData())
            {
                checkedListBox1.Items.Add(animal, false);
            }

            checkedListBox1.DisplayMember = "Name";
            checkedListBox1.ValueMember = "Id";

            checkedListBox1.ItemCheck += CheckedListBox_ItemCheck;
        }

        private void Card_Click(object sender, EventArgs e)
        {
            if (sender is card clickedCard)
            {
                string animalID = clickedCard.Id;
                selectedAnimalIds.Add(animalID);
            }
        }

        private void CheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = (CheckedListBox)sender;

            if (checkedListBox1.SelectedItem is Animal selectedAnimal)
            {
                string animalID = selectedAnimal.Id;

                if (e.NewValue == CheckState.Checked)
                {
                    selectedAnimalIds.Add(animalID);
                }
                else if (e.NewValue == CheckState.Unchecked)
                {
                    selectedAnimalIds.Remove(animalID);
                }
            }
        }


        private void Event_Register_Load(object sender, EventArgs e)
        {
            this.populateAnimals();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
