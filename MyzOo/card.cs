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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private string _name;
        private Image _profileImage;

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
    }
}
