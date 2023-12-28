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
using static MyzOo.Models.Animal;

namespace MyzOo.View
{
    public partial class Ver_Animal_Menu : Form
    {
        int op = 1;
        private int animalID;
        private Animal animal;
        private Cell cell;
        private Food food;

        public Ver_Animal_Menu(int animalID)
        {
            InitializeComponent();
            this.animalID = animalID;
        }
        private void Ver_Animal_Menu_Load(object sender, EventArgs e)
        {
            //prevents user from interact with objects when open the form
            Name_Box.Enabled = true;
            Birthday_Calendar.Enabled = true;
            Cell_listbox.Enabled = true;
            Food_listbox.Enabled = true;
            Checkup_Box.Enabled = true;

            animal = Animal.GetAnimal(this.animalID);

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

            Name_Box.Text = animal.Name;
            Birthday_Calendar.SelectionStart = animal.Birthday;
            Cell_listbox.Text = animal.AnimalCell.ToString();
            Food_listbox.Text = animal.AnimalFood;
            Checkup_Box.Checked = animal.Checkup;
            Gender_listbox.Text = animal.AnimalGender;
        }
        private void Edit_button_Click(object sender, EventArgs e)
        {
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            //hide this menu 
            AnimalList_Menu animalList_Menu = new AnimalList_Menu();
            animalList_Menu.Show();
            this.Hide();
        }

        private void Regist_button_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();

            int Id = animalID;

            // Animal Info
            string Name = Name_Box.Text;
            DateTime Date = Birthday_Calendar.SelectionRange.Start;
            bool Checkup = Checkup_Box.Checked;
            bool IsDeceased = Decease_Box.Checked;

            string gender = Gender_listbox.Text;

            // Retrieve selected cell and food values
            // Food
            string foodName = Food_listbox.Text;
            Food animalFood = Food.LoadData().FirstOrDefault(tf => tf.Description == foodName);

            // Cell
            int callDescription = Convert.ToInt32(Cell_listbox.Text);
            Cell animalCell = Cell.LoadData().FirstOrDefault(tf => tf.Number == callDescription);

            animal.UpdateData(Id, Name, Date, Checkup, IsDeceased, gender, animalCell.Number, animalFood.Description);

            AnimalList_Menu animalList_Menu = new AnimalList_Menu();
            animalList_Menu.Show();
            this.Hide();
        }

        private void Food_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            int Id = animalID;
            string Name = Name_Box.Text;

            animal.DeleteData(Id, Name);

            AnimalList_Menu animalList_Menu = new AnimalList_Menu();
            animalList_Menu.Show();
            this.Hide();

        }
    }
}
