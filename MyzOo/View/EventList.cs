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
    public partial class EventList : Form
    {
        string userId;
        public EventList(string userID)
        {
            InitializeComponent();
            this.userId = userID;
        }

        private void Minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            //Hide this Menu and open Main_Men
            Main_Menu main_Menu = new Main_Menu(userId);
            main_Menu.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
