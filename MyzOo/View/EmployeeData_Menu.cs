using MyzOo.Methods;
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
    public partial class EmployeeData_Menu : Form
    {
        int op = 1;

        public string employeeID;
        private Employee employee;

        public EmployeeData_Menu(string employeeId)
        {
            InitializeComponent();
            employeeID = employeeId;
            EmployeeCrud employeecrud = new EmployeeCrud();

            employee = employeecrud.GetEmployee(employeeID);

        }
        

        private void Ver_Employee_Menu_Load(object sender, EventArgs e)
        {
            Name_Box.Text = employee.Name;
        }
        private void Exit_button_Click(object sender, EventArgs e)
        {
            //Hide this Menu and open Main_Men
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Hide();
        }

        private void Minimize_button_Click(object sender, EventArgs e)
        {
            //minimize the form
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Pass_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            string id = employeeID;
            string name = Name_Box.Text;

            if (name != null || id != null)
            {
                employee.DeleteData(id, name);
            }
 
            EmployeeList EmployeeList_Menu = new EmployeeList();
            EmployeeList_Menu.Show();
            this.Hide();
        }
    }
}
