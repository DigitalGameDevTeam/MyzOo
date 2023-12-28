using MyzOo.Models;
using MyzOo.Methods;
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

namespace MyzOo
{
    public partial class Animal_Menu : Form
    {
        public Animal_Menu()
        {
            InitializeComponent();
        }
        private void Animal_Menu_Load(object sender, EventArgs e)
        {
            foreach (var food in Food.LoadData())
            {
                Food_listbox.Items.Add(food.Description);
            }

            foreach (var cell in Cell.LoadData())
            {
                Cell_listbox.Items.Add(cell.Number);
            }
        
            Animal.Gender[] genders = (Animal.Gender[])Enum.GetValues(typeof(Animal.Gender));

            foreach (var gender in genders)
            {
                Gender_listbox.Items.Add(gender);
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            //hide this Menu
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Hide();
        }
        private void Food_list_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Checkup_Box_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Name_Box_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void Birthday_Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Cell_list_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Regist_button_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();

            // Create an instance of the Random class
            Random random = new Random();

            // Generate a random ID with 4 numbers
            int Id = random.Next(1000, 10000);

            // Animal Info
            string Name = Name_Box.Text;
            DateTime Date = Birthday_Calendar.SelectionRange.Start;
            bool Checkup = Checkup_Box.Checked;
            bool IsDeceased = Decease_Box.Checked;

            string gender = Gender_listbox.Text;
            //Animal.Gender gender;
            //Enum.TryParse(Gender_listbox.Text, out gender);

            // Retrieve selected cell and food values
            // Food
            string foodName = Food_listbox.Text;
            Food animalFood = Food.LoadData().FirstOrDefault(tf => tf.Description == foodName);

            // Cell
            int callDescription = Convert.ToInt32(Cell_listbox.Text);
            Cell animalCell = Cell.LoadData().FirstOrDefault(tf => tf.Number == callDescription);


            

            animal.SetData(Id, Name, Date, Checkup, IsDeceased, gender, animalCell.Number, animalFood.Description);


            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Hide();
        }

        private void Cell_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
