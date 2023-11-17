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
    public partial class Ver_Animal_Menu : Form
    {
        int op = 1;//variable used to alternate between "Inspecionar" and "Editar"
        public Ver_Animal_Menu()
        {
            InitializeComponent();
        }
        private void Ver_Animal_Menu_Load(object sender, EventArgs e)
        {
            //prevents user from interact with objects when open the form
            Name_Box.Enabled = false;
            Birthday_Calendar.Enabled = false;
            Cell_listbox.Enabled = false;
            Food_listbox.Enabled = false;
            Checkup_Box.Enabled = false;
        }
        private void Edit_button_Click(object sender, EventArgs e)
        {
           
            switch (op)
            {
                //change Menu to Editar
                case 1:
                    op = 2;
                    label1.Text = "Editar Animal";
                    Edit_button.Text = "Inspecionar";
                    Name_Box.Enabled = true;
                    Birthday_Calendar.Enabled = true;
                    Cell_listbox.Enabled = true;
                    Food_listbox.Enabled = true;
                    Checkup_Box.Enabled = true;
                    break;
                //change Menu to Inspecionar
                case 2:
                    op = 1;
                    label1.Text = "Inspecionar Animal";
                    Edit_button.Text = "Editar";
                    Name_Box.Enabled = false;
                    Birthday_Calendar.Enabled = false;
                    Cell_listbox.Enabled = false;
                    Food_listbox.Enabled = false;
                    Checkup_Box.Enabled = false;
                    break;
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            //hide this menu 
            this.Hide();
        }

        private void Regist_button_Click(object sender, EventArgs e)
        {

        }
    }
}
