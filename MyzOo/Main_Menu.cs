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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close Start_Menu and open Main_Menu
            Main_Menu main_Menu = new Main_Menu();
            Start_Menu start_Menu = new Start_Menu();
            main_Menu.Close();
            start_Menu.Show();
        }
    }
}
