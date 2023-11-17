using MyzOo.Classes;
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
    public partial class Animal_Menu : Form
    {
        public Animal_Menu()
        {
            InitializeComponent();
        }
        private void Animal_Menu_Load(object sender, EventArgs e)
        {
            List<Cell> cell = Cell.CellList;
            List<Food> food = MyzOo.Classes.Food.FoodList;

            if (food != null)
            {
                foreach (Food foods in food)
                {
                    Food_listbox.Items.Add(foods.Typefood);
                }
            }
            else
            {
                MessageBox.Show("Vazio", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Add cell
            foreach (Cell cells in cell)
            {
                Cell_listbox.Items.Add(cells.Number);
            }


            //Animal animal = new Animal();
        }
        private void Exit_button_Click(object sender, EventArgs e)
        {
            //hide this Menu
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
            // Create an instance of the Random class
            Random random = new Random();

            // Generate a random ID with 4 numbers
            int id = random.Next(1000, 10000);

            // Animal Info
            string name = Name_Box.Text;
            DateTime date = Birthday_Calendar.SelectionRange.Start; 

            if (Name_Box != null)
            {
                Animal animal = new Animal(id, name, date, false, 1, 1, false, Animal.Gender.Male);
            }

            this.Hide();
        }

        private void Cell_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
