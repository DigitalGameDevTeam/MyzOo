using MyzOo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyzOo
{
    public partial class Animal_Menu : Form
    {
        public Animal_Menu()
        {
            InitializeComponent();
        }
        private void Animal_Menu_Load(object sender, EventArgs e)
        {
            //Animal animal = new Animal();
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            //hide this Menu
            this.Hide();
        }
        private void food_list_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void checkup_Box_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void name_Box_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void id_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthday_Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void cell_list_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void regist_button_Click(object sender, EventArgs e)
        {

        }
    }
}
