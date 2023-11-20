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
            List<Food> food = MyzOo.Models.Food.FoodList;

            /*if (food != null)
            {
                foreach (Food foods in food)
                {
                    Food_listbox.Items.Add(foods.Id);
                }
            }
            else
            {
                MessageBox.Show("Vazio", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/

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
            Firebase conn = new Firebase();
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
            Animal.Gender gender;
            Enum.TryParse(Gender_listbox.Text, out gender);

            // Retrieve selected cell and food values

            int selectedCellNumber = Convert.ToInt32(Cell_listbox.SelectedItem);
            Cell selectedCell = Cell.CellList.FirstOrDefault(cell => cell.Number == selectedCellNumber);

            // Assuming Food has an 'Id' property
            int selectedFoodId = Convert.ToInt32(Food_listbox.SelectedItem);
            Food selectedFood = Food.FoodList.FirstOrDefault(food => food.Id == selectedFoodId);


            animal.SetData(Id, Name, Date, Checkup, IsDeceased, gender, selectedCell, selectedFood);

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
    }
}
