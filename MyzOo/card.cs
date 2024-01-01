using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MyzOo
{
    public partial class card : UserControl
    {
        public card()
        {
            InitializeComponent();
        }

        private void card_Load(object sender, EventArgs e)
        {
           
        }

        private string _name;
        private string _id;

        [Category("Custom Props")]
        public string Id
        {
            get { return _id; }
            set { _id = value; /*Card_Id.Text = value.ToString();*/ }
        }

        [Category("Custom Props")]
        public string Name
        { 
            get { return _name; } 
            set {  _name = value; Card_Name.Text = value; } 
        }

        private void card_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.MidnightBlue;
        }

        private void card_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.SteelBlue;
        }

        private void Card_Name_Enter(object sender, EventArgs e)
        {
        }

        private void Card_Name_Leave(object sender, EventArgs e)
        {
            
        }

        private void card_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Card_Edit_Button_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Card_Delete_Button_Click(object sender, EventArgs e)
        {

        }

        private void Card_Id_Click(object sender, EventArgs e)
        {

        }

        private void Card_Name_Click(object sender, EventArgs e)
        {

        }

        private void Card_Name_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.MidnightBlue;

        }

        private void Card_Name_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.SteelBlue;
        }
    }
}
