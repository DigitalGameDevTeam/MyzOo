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
    public partial class AnimalList_Menu : Form
    {
        public AnimalList_Menu()
        {
            InitializeComponent();
        }

        private void Animal_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
