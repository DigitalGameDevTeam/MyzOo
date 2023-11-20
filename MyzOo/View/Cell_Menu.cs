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

namespace MyzOo.View
{
    public partial class Cell_Menu : Form
    {
        public Cell_Menu()
        {
            InitializeComponent();
        }

        private void Animallist_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cellnumber_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            //hide this Menu and open Main Menu
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Hide();
        }

        private void Regist_button_Click(object sender, EventArgs e)
        {

            int number = Convert.ToInt32(Cellnumber_Box.Text);
            bool cleaning = Checkup_Box.Checked;

            Cell cell= new Cell(number, cleaning);

            MessageBox.Show("Registo realizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
        }

        private void Cell_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
