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
        public EmployeeData_Menu()
        {
            InitializeComponent();
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
                    Checkup_Box.Enabled = true;
                    Admin_listbox.Enabled = true;
                    Pass_textbox.Enabled = true;
                    Cell_listbox.Enabled = true;
                    break;
                case 2:
                    op = 1;
                    label4.Text = "Ver Funcionário";
                    Name_Box.Enabled = false;
                    Birthday_Calendar.Enabled = false;
                    Func_listbox.Enabled = false;
                    Checkup_Box.Enabled = false;
                    Admin_listbox.Enabled = false;
                    Pass_textbox.Enabled = false;
                    Cell_listbox.Enabled = false;


                    break;




            }
        }
        private void Ver_Employee_Menu_Load(object sender, EventArgs e)
        {
            Name_Box.Enabled = false;
            Birthday_Calendar.Enabled = false;
            Func_listbox.Enabled = false;
            Checkup_Box.Enabled = false;
            Admin_listbox.Enabled = false;
            Pass_textbox.Enabled = false;
            Cell_listbox.Enabled = false;
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
    }
}
