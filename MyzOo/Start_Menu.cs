using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
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

        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //Close the app
            Environment.Exit(0);
        }
        private void label1_Click(object sender, EventArgs e)
        {
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //close Start_Menu and open Main_Menu
            Main_Menu main_Menu = new Main_Menu();
            Start_Menu start_Menu = new Start_Menu();
            main_Menu.Show();
            start_Menu.Close();
        }
    }
}
