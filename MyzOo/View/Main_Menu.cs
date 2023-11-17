using MyzOo.Classes;
using MyzOo.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyzOo
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            //close Start_Menu and open Main_Menu
            Start_Menu start_Menu = new Start_Menu();
            this.Hide();
            start_Menu.Show();
        }

        private void Minimize_button_Click(object sender, EventArgs e)
        {
            //minimize the form
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            //set Menu Colors
            panel1.BackColor = Color.DeepSkyBlue;
            label1.ForeColor = Color.White;
        }

        private void AnimalMenu_button_Click(object sender, EventArgs e)
        {
            //open Animal_Menu

            List<Animal> animal = Animal.AnimalList;
            List<Food> food = Food.FoodList;
            List<Cell> cell = Cell.CellList;

            bool verifyFood = Food.VerifyFood(food);
            bool verifyCell = Cell.VerifyCell(cell);

            Animal_Menu animal_Menu = new Animal_Menu();
            animal_Menu.Show();

            /* Verification
            if (verifyFood)
            {
                if (verifyCell)
                {
                    Animal_Menu animal_Menu = new Animal_Menu();
                    animal_Menu.Show();

                }
                else MessageBox.Show("Tens que adicionar uma Cela", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Tens que adicionar Comida", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); */

        }

        private void Food_Menu_button_Click(object sender, EventArgs e)
        {
            //open Food_Menu
            Food_Menu food_Menu = new Food_Menu();
            food_Menu.Show();
        }

        private void Cell_Menu_button_Click(object sender, EventArgs e)
        {
            //open Cell_Menu
            Cell_Menu cell_Menu = new Cell_Menu();
            cell_Menu.Show();
        }

        private void Ver_Animal_Menu_button_Click(object sender, EventArgs e)
        {
            //open Ver_Animal_Menu
            Ver_Animal_Menu ver_Animal_Menu = new Ver_Animal_Menu();
            ver_Animal_Menu.Show();
        }
    }
}

