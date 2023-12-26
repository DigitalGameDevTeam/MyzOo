using MyzOo.Models;
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
        int st = 1;
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

            TypeFood typeFood = new TypeFood();
            typeFood.SetData(1, "carne");
            typeFood.SetData(2, "peixe");
        }

        private void AnimalMenu_button_Click(object sender, EventArgs e)
        {
            //open Animal_Menu

            List<Animal> animal = Animal.AnimalList;
            List<Food> food = Food.FoodList;
            List<Cell> cell = Cell.CellList;

            Animal_Menu animal_Menu = new Animal_Menu();
            animal_Menu.Show();
            this.Hide();

        }

        private void Food_Menu_button_Click(object sender, EventArgs e)
        {
            //open Food_Menu
            Food_Menu food_Menu = new Food_Menu();
            food_Menu.Show();
            this.Hide();
        }

        private void Cell_Menu_button_Click(object sender, EventArgs e)
        {
            //open Cell_Menu
            Cell_Menu cell_Menu = new Cell_Menu();
            cell_Menu.Show();
            this.Hide();
        }

        private void Ver_Animal_Menu_button_Click(object sender, EventArgs e)
        {
            //open Ver_Animal_Menu
            Ver_Animal_Menu ver_Animal_Menu = new Ver_Animal_Menu();
            ver_Animal_Menu.Show();
            this.Hide();
        }

        private void Maximize_button_Click(object sender, EventArgs e)
        {
            switch (st)
            {
                case 1: //Set form to Mazimize Size
                    st = 2;
                    this.WindowState = FormWindowState.Maximized;

                break;
                case 2: //Set form to Normal Size
                    st = 1;
                    this.WindowState = FormWindowState.Normal;

                break;
            }
        }
        private void Employee_Menu_button_Click(object sender, EventArgs e)
        {
            //Open Employee_Menu
            Employee_Menu employee_Menu = new Employee_Menu();
            employee_Menu.Show();
            this.Hide();
            
        }

        private void AnimalList_Menu_button_Click(object sender, EventArgs e)
        {
            //open animallist_menu
            AnimalList_Menu animalList_Menu = new AnimalList_Menu();
            animalList_Menu.Show();
            this.Hide();
        }

        private void VerComida_button_Click(object sender, EventArgs e)
        {
            FoodList_menu foodList_Menu = new FoodList_menu();
            foodList_Menu.Show();
            this.Hide();
        }

        private void Ver_Menu_Button_Click(object sender, EventArgs e)
        {
            VerCela_Menu verCela_menu = new VerCela_Menu(); 
            verCela_menu.Show();
            this.Hide();
        }

        private void VerEmployee_button_Click(object sender, EventArgs e)
        {
            Ver_Employee_Menu ver_Employee_Menu = new Ver_Employee_Menu();
            ver_Employee_Menu.Show();
            this.Hide();
        }
    }
}
