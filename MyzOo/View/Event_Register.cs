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
            string description = Name_box.Text;

            //string gender = Gender_listbox.Text;
            // Retrieve selected cell and food values
            // Food
            //string foodName = Food_listbox.Text;
            //Food animalFood = Food.LoadData().FirstOrDefault(tf => tf.Description == foodName);

            events.SetData(id, description, hourBegin, duration, numAttendees, location, animalId);

            this.Close();
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Hide();

        }
    }
}
