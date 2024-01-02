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
    public partial class EmployeeList : Form
    {
        string userId;
        public EmployeeList(string userID)
        {
            InitializeComponent();
            userId = userID;
        }
        private void Employee_list_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void populateItems()
        {
            card[] cardList = new card[1000];

            int count = 0;

            flowLayoutPanel1.Controls.Clear();

            foreach (var employee in Employee.LoadData())
            {

                cardList[count] = new card();
                cardList[count].Name = employee.Name;
                cardList[count].Id = employee.Id;

                flowLayoutPanel1.Controls.Add(cardList[count]);

                cardList[count].Click += Card_Click;
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            if (sender is card clickedCard)
            {
                string employeeID = clickedCard.Id;

                EmployeeData_Menu see_Employee_Menu = new EmployeeData_Menu(employeeID, userId);
                see_Employee_Menu.Show();
                this.Hide();
            }
        }


        private void Exit_button_Click(object sender, EventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu(userId);
            main_Menu.Show();
            this.Hide();
        }

        private void Minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void List_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
