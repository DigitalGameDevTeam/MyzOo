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

        private string employeeID;
        private Employee employee;

        public EmployeeData_Menu(string employeeId)
        {
            InitializeComponent();
            employeeID = employeeId;
        }
        
        private void Edit_button_Click(object sender, EventArgs e)
        {
           switch (op)
            {
                case 1:
                    op = 2;
                    label4.Text = "Editar Funcionário";
                    Name_Box.Enabled = true;
                    Birthday_Calendar.Enabled = true;
                    Func_listbox.Enabled = true;
                    Admin_listbox.Enabled = true;
                    Pass_textbox.Enabled = true;
                    Delete_Button.Enabled = true;
                    break;
                case 2:
                    op = 1;
                    label4.Text = "Ver Funcionário";
                    Name_Box.Enabled = false;
                    Birthday_Calendar.Enabled = false;
                    Func_listbox.Enabled = false;
                    Admin_listbox.Enabled = false;
                    Pass_textbox.Enabled = false;
                    Delete_Button.Enabled = false;

                    break;




            }
        }
        private void Ver_Employee_Menu_Load(object sender, EventArgs e)
        {
            Name_Box.Enabled = false;
            Birthday_Calendar.Enabled = false;
            Func_listbox.Enabled = false;
            Admin_listbox.Enabled = false;
            Pass_textbox.Enabled = false;
            Delete_Button.Enabled = false;

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
    }
}
