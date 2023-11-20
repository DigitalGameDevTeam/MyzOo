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
    public partial class VerCela_Menu : Form
    {
        int op = 1;
        public VerCela_Menu()
        {
            InitializeComponent();
        }
        private void Exit_button_Click(object sender, EventArgs e)
        {
            //hide this Menu and open Main Menu
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Hide();
        }
        private void Edit_button_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case 1:
                    op = 2;
                    label1.Text = "Editar Cela";
                    Edit_button.Text = "Inspecionar";
                    Cellnumber_Box.Enabled = true;
                    CellDescription_textbox.Enabled = true;
                    Checkup_Box.Enabled = true;
                    break;
                case 2:
                    op = 1;
                    label1.Text = "Inspecionar Cela";
                    Edit_button.Text = "Editar";
                    Cellnumber_Box.Enabled = false;
                    CellDescription_textbox.Enabled = false;
                    Checkup_Box.Enabled = false;
                    break;

            }
        }

        private void VerCela_Menu_Load(object sender, EventArgs e)
        {
            Cellnumber_Box.Enabled = false;
            CellDescription_textbox.Enabled = false;
            Checkup_Box.Enabled = false; 
        }
    }
}
