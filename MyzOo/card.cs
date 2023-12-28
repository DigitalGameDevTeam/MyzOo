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
    public partial class card : UserControl
    {
        public card()
        {
            InitializeComponent();
        }

        private string _name;
        private Image _profileImage;
        private int _id;

        [Category("Custom Props")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Custom Props")]
        public string Name
        { 
            get { return _name; } 
            set {  _name = value; Card_Name.Text = value; } 
        }

        [Category("Custom Props")]
        public Image profileImage
        {
            get { return _profileImage; }
            set { _profileImage = value; Card_pictureBox.Image = value; }
        }



        private void card_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void card_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void card_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
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
    }
}
