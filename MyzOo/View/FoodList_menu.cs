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
    public partial class FoodList_menu : Form
    {
        int op = 1;
        public FoodList_menu()
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
                    label1.Text = "Editar Comida";
                    Edit_button.Text = "Inspecionar";
                    Name_Box.Enabled = true;
                    Food_desciption_textbox.Enabled = true;
                    Stock_textbox.Enabled = true;
                    Cell_listbox.Enabled = true;
                    break;
                case 2:
                    op = 1;
                    label1.Text = "Inspecionar Comida";
                    Edit_button.Text = "Editar";
                    Name_Box.Enabled = false;
                    Food_desciption_textbox.Enabled = false;
                    Stock_textbox.Enabled = false;
                    Cell_listbox.Enabled = false;
                    break;

            }
        }

        private void FoodList_menu_Load(object sender, EventArgs e)
        {
            Name_Box.Enabled = false;
            Food_desciption_textbox.Enabled = false;
            Stock_textbox.Enabled = false;
            Cell_listbox.Enabled = false;
        }

        private void Cell_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Name_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
