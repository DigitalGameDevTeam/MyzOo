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
        private DateTime birthDateEmployee;
        public string employeeID;
        private Employee employee;
        string userId;
        public EmployeeData_Menu(string employeeId, string userID)
        {
            InitializeComponent();
            employeeID = employeeId;
            EmployeeCrud employeecrud = new EmployeeCrud();

            employee = employeecrud.GetEmployee(employeeID);

            this.FillEmployeeFunctionListBox();
            this.FillEmployeeAdminLevelListBox();
            userId = userID;
        }
        

        private void Ver_Employee_Menu_Load(object sender, EventArgs e)
        {
            Name_Box.Text = employee.Name;
            Name_Box.Enabled = true;

        }

        private void FillEmployeeFunctionListBox()
        {
            List<EmployeeFunction> allEmployeeFunction = EmployeeFunction.LoadData();
            foreach (EmployeeFunction function in allEmployeeFunction)
            {
                if (function != null)
                    Func_listbox.Items.Add(function.description);
            }
        }

        // Fills employee admin list box
        private void FillEmployeeAdminLevelListBox()
        {
            List<EmployeeAdminLevel> allEmployeeFunction = EmployeeAdminLevel.LoadData();
            foreach (EmployeeAdminLevel admin in allEmployeeFunction)
            {
                if (admin != null)
                    Admin_listbox.Items.Add(admin.description);
            }
        }
        private void Exit_button_Click(object sender, EventArgs e)
        {
            //Hide this Menu and open Main_Men
            Main_Menu main_Menu = new Main_Menu(userId);
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
 
            EmployeeList EmployeeList_Menu = new EmployeeList(userId);
            EmployeeList_Menu.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Regist_button_Click(object sender, EventArgs e)
        {
            EmployeeCrud employeeCrud = new EmployeeCrud();
            EmployeeAdminLevelCrud al = new EmployeeAdminLevelCrud();
            EmployeeFunctionCrud fc = new EmployeeFunctionCrud();
            employeeCrud.UpdateData(
                employeeID,
                Name_Box.Text,
                this.birthDateEmployee,
                Client.encryptSHA512(Pass_textbox.Text),
                Int32.Parse(al.getIdByDescription(Admin_listbox.SelectedItem.ToString())),
                Int32.Parse(fc.getIdByDescription(Func_listbox.SelectedItem.ToString()))
                );
            MessageBox.Show("Empregado alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Name_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Birthday_Calendar_ValueChanged(object sender, DateRangeEventArgs e)
        {
            this.birthDateEmployee = e.Start;
        }
    }
}
