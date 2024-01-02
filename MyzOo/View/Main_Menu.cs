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
using System.Windows;
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
            CheckAdminLevel();
        }

        private void CheckAdminLevel()
        {
            EmployeeCrud employeeCrud = new EmployeeCrud();
            Employee employee = employeeCrud.GetEmployee(userId); // userId obtained from the Main_Menu constructor

            if (employee != null)
            {
                int adminLevel = employee.Adminlevel;
                int employeeType = employee.EmployeeJob;
                label3.Text = employee.Name;

                if (adminLevel == 1)
                {
                    label5.Text = "Gestor";
                }
                else if (employeeType == 4)
                {
                    Cell_Menu_button.Enabled = true;
                    button3.Enabled = true;
                    Food_Menu_button.Enabled = false;
                    button1.Enabled = false;
                    AnimalMenu_button.Enabled = false;
                    AnimalList_Menu_button.Enabled = false;
                    RegistarEvento.Enabled = false;
                    button4.Enabled = false;
                    button2.Enabled = false;
                    Employee_Menu_button.Enabled = false;
                    label5.Text = "Limpador De Celas";
                }

                else if (employeeType == 3)
                {
                    Cell_Menu_button.Enabled = true;
                    button3.Enabled = true;
                    Food_Menu_button.Enabled = false;
                    button1.Enabled = false;
                    AnimalMenu_button.Enabled = false;
                    AnimalList_Menu_button.Enabled = false;
                    RegistarEvento.Enabled = false;
                    button4.Enabled = false;
                    button2.Enabled = false;
                    Employee_Menu_button.Enabled = false;   
                }

                else if (employeeType == 2)
                {
                    Cell_Menu_button.Enabled = false;
                    button3.Enabled = false;
                    Food_Menu_button.Enabled = true;
                    button1.Enabled = true;
                    AnimalMenu_button.Enabled = true;
                    AnimalList_Menu_button.Enabled = true;
                    RegistarEvento.Enabled = false;
                    button4.Enabled = false;
                    button2.Enabled = false;
                    Employee_Menu_button.Enabled = false;
                }
            }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
