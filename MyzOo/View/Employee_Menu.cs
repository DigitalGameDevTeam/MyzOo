using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyzOo.View
{
    public partial class Employee_Menu : Form
    {
        public Employee_Menu()
        {
            InitializeComponent();
        }
        private void Minimize_button_Click(object sender, EventArgs e)
        {
            //minimize the form
            this.WindowState = FormWindowState.Minimized;
        }
        private void Exit_button_Click(object sender, EventArgs e)
        { //Hide this Menu and open Main_Men
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Hide();

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

        }
    }
}

