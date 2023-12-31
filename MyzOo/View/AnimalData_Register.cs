﻿using MyzOo.Models;
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
    public partial class AnimalData_Register : Form
    {
        string userId;
        public AnimalData_Register(string userID)
        {
            InitializeComponent();
            userId = userID;
        }
        private void Animal_Menu_Load(object sender, EventArgs e)
        {
            this.FillAnimalFoodListBox();
            this.FillAnimalCellListBox();
            this.FillAnimalGenderListBox();
          
        }

        private void FillAnimalFoodListBox()
        {
            foreach (var food in Food.LoadData())
            {
                Food_listbox.Items.Add(food.Description);
            }
        }

        private void FillAnimalCellListBox()
        {
            foreach (var cell in Cell.LoadData())
            {
                Cell_listbox.Items.Add(cell.Number);
            }
        }

        private void FillAnimalGenderListBox()
        {
            Animal.Gender[] genders = (Animal.Gender[])Enum.GetValues(typeof(Animal.Gender));

            foreach (var gender in genders)
            {
                Gender_listbox.Items.Add(gender);
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            //hide this Menu
            
            Main_Menu main_Menu = new Main_Menu(userId);
            main_Menu.Show();
            this.Hide();
            this.Dispose();
            this.Close();
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

            // Generate a random ID with 4 numbers
            string id = Guid.NewGuid().ToString();

            // Animal Info
            string name = Name_box.Text;
            DateTime date = Birthday_Calendar.Value;
            bool isDeceased = Decease_Box.Checked;

            string gender = Gender_listbox.Text;
            // Retrieve selected cell and food values
            // Food
            string foodName = Food_listbox.Text;
            Food animalFood = Food.LoadData().FirstOrDefault(tf => tf.Description == foodName);

            // Cell
            int callDescription = Convert.ToInt32(Cell_listbox.Text);
            Cell animalCell = Cell.LoadData().FirstOrDefault(tf => tf.Number == callDescription);

            animal.SetData(id, name, date, isDeceased, gender, animalCell.Number, animalFood.Description);

            this.Close();
            Main_Menu main_Menu = new Main_Menu(userId);
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

        private void Name_box_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Food_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
