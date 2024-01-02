using MyzOo.Methods;
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

        string userId;

        public Main_Menu(string userID)
        {
            InitializeComponent();
            userId = userID;
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

        }

        private void AnimalMenu_button_Click(object sender, EventArgs e)
        {
            //open Animal_Menu

            List<Animal> animal = Animal.AnimalList;
            List<Food> food = Food.FoodList;
            List<Cell> cell = Cell.CellList;

            
            AnimalData_Register animal_Menu = new AnimalData_Register(userId);
            this.Hide();
            animal_Menu.Show();
            this.Dispose();
            this.Close();
        }

        private void Food_Menu_button_Click(object sender, EventArgs e)
        {
            //open Food_Menu
            Food_Menu food_Menu = new Food_Menu(userId);
            food_Menu.Show();
            this.Hide();
        }

        private void Cell_Menu_button_Click(object sender, EventArgs e)
        {
            //open Cell_Menu
            CellData_Register cell_Menu = new CellData_Register(userId);
            cell_Menu.Show();
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
            EmployeeData_Register employee_Menu = new EmployeeData_Register(userId);
            employee_Menu.Show();
            this.Hide();
            
        }

        private void AnimalList_Menu_button_Click(object sender, EventArgs e)
        {
            //open animallist_menu
            AnimalList animalList_Menu = new AnimalList(userId);
            animalList_Menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FoodList food_List = new FoodList(userId);
            food_List.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeList employeeList_Menu = new EmployeeList(userId);
            employeeList_Menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CellList cell_List = new CellList(userId);
            cell_List.Show();
            this.Hide();
        }
        private void RegistarEvento_Click_1(object sender, EventArgs e)
        {
            Event_Register event_Register = new Event_Register(userId);
            event_Register.Show();
            this.Hide();
        }

        private void ListaEvento_Click_1(object sender, EventArgs e)
        {
            EventList eventList = new EventList(userId);
            eventList.Show();
            this.Hide();
        }
    }
}
