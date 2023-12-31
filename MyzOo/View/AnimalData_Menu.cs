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
    public partial class AnimalData_Menu : Form
    {
        private int animalId;
        private Animal animal;

        public AnimalData_Menu(int id)
        {
            InitializeComponent();
            animalId = id;
        }
        private void Ver_Animal_Menu_Load(object sender, EventArgs e)
        {
            Name_Box.Enabled = true;
            Birthday_Calendar.Enabled = true;
            Cell_listbox.Enabled = true;
            Food_listbox.Enabled = true;

            animal = Animal.GetAnimal(this.animalId);

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
            Food_listbox.Text = animal.AnimalFood.ToString();
            Decease_Box.Checked = animal.IsDeceased;
            Gender_listbox.Text = animal.AnimalGender;
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {

            int id = animalId;

            // Animal Info
            string name = Name_Box.Text;
            DateTime date = Birthday_Calendar.SelectionRange.Start;
            bool isDeceased = Decease_Box.Checked;

            string gender = Gender_listbox.Text;

            // Retrieve selected cell and food values
            // Food
            string foodName = Food_listbox.Text;
            Food animalFood = Food.LoadData().FirstOrDefault(tf => tf.Description == foodName);

            // Cell
            int callDescription = Convert.ToInt32(Cell_listbox.Text);
            Cell animalCell = Cell.LoadData().FirstOrDefault(tf => tf.Number == callDescription);

            animal.UpdateData(id, name, date, isDeceased, gender, animalCell.Number, animalFood.Description);

            AnimalList animalList_Menu = new AnimalList();
            animalList_Menu.Show();
            this.Hide();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            int id = animalId;
            string name = Name_Box.Text;

            animal.DeleteData(id, name);

            AnimalList animalList_Menu = new AnimalList();
            animalList_Menu.Show();
            this.Hide();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            //hide this menu 
            AnimalList animalList_Menu = new AnimalList();
            animalList_Menu.Show();
            this.Hide();
        }

        private void Food_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
        }

    }
}
