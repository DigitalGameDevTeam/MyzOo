using MyzOo.Methods;
using MyzOo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyzOo.View
{
    public partial class Employee_Menu : Form
    {
        private DateTime birthDateEmployee;

        public Employee_Menu()
        {
            InitializeComponent();
            this.FillEmployeeFunctionListBox();
            this.FillEmployeeAdminLevelListBox();
        }

        // Fills employee function list box
        private void FillEmployeeFunctionListBox()
        {
            List<EmployeeFunction> allEmployeeFunction = EmployeeFunction.LoadData();
            foreach (EmployeeFunction function in allEmployeeFunction)
            {
                if (function != null)
                    Cell_listbox.Items.Add(function.description);
            }
        }

        // Fills employee admin list box
        private void FillEmployeeAdminLevelListBox()
        {
            List<EmployeeAdminLevel> allEmployeeFunction = EmployeeAdminLevel.LoadData();
            foreach (EmployeeAdminLevel admin in allEmployeeFunction)
            {
                if (admin != null)
                    Food_listbox.Items.Add(admin.description);
            }
        }


        private void Minimize_button_Click(object sender, EventArgs e)
        {
            //minimize the form
            this.WindowState = FormWindowState.Minimized;
        }
        private void Exit_button_Click(object sender, EventArgs e)
        { 
            //Hide this Menu and open Main_Men
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Hide();
        }

        private void Regist_button_Click(object sender, EventArgs e)
        {
            EmployeeCrud employeeCrud = new EmployeeCrud();
            EmployeeAdminLevelCrud al = new EmployeeAdminLevelCrud();
            EmployeeFunctionCrud fc = new EmployeeFunctionCrud();
            employeeCrud.SetData(
                Guid.NewGuid().ToString(),
                Name_Box.Text,
                this.birthDateEmployee,
                Client.encryptSHA512(textBox2.Text),
                Int32.Parse(al.getIdByDescription(Food_listbox.SelectedItem.ToString())),
                Int32.Parse(fc.getIdByDescription(Cell_listbox.SelectedItem.ToString()))
                );
            MessageBox.Show("Empregado registado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Employee_Menu_Load(object sender, EventArgs e)
        {
             
        }
        private void Name_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Checkup_Box_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Birthday_Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.birthDateEmployee = e.Start;
        }



        private void profilePicture_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}


