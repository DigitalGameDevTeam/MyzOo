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
           
            //switch (op)
            //{
            //    //change Menu to Editar
            //    case 1:
            //        op = 2;
            //        label1.Text = "Editar Animal";
            //        Edit_button.Text = "Inspecionar";
            //        Name_Box.Enabled = true;
            //        Birthday_Calendar.Enabled = true;
            //        Cell_listbox.Enabled = true;
            //        Food_listbox.Enabled = true;
            //        Checkup_Box.Enabled = true;
            //        break;
            //    //change Menu to Inspecionar
            //    case 2:
            //        op = 1;
            //        label1.Text = "Inspecionar Animal";
            //        Edit_button.Text = "Editar";
            //        Name_Box.Enabled = false;
            //        Birthday_Calendar.Enabled = false;
            //        Cell_listbox.Enabled = false;
            //        Food_listbox.Enabled = false;
            //        Checkup_Box.Enabled = false;
            //        break;
            //}
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

        }

        private void Food_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
