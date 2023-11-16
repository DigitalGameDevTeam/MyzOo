using MyzOo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyzOo
{
    public partial class Start_Menu : Form
    {
        
        public Start_Menu()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //set form colors
            panel1.BackColor = Color.DeepSkyBlue;
            Login_button.ForeColor = Color.DeepSkyBlue;
            Seila_button.ForeColor = Color.DeepSkyBlue;
            Close_button.ForeColor = Color.DeepSkyBlue;
            label1.ForeColor = Color.White;
        }
        private void Seila_button_Click(object sender, EventArgs e)
        {

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            //Close the app
            Environment.Exit(0);
        }
        private void Login_button_Click(object sender, EventArgs e)
        {
            //close Start_Menu and open Main_Menu
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Hide();
        }
    }
}
