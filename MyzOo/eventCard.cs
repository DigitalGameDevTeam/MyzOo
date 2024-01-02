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
    public partial class eventCard : UserControl
    {
        public eventCard()
        {
            InitializeComponent();
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
            set { _name = value; Card_Name.Text = value; }
        }

        private void card1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.MidnightBlue;
        }

        private void card1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.SteelBlue;
        }

        private void card1_Load(object sender, EventArgs e)
        {

        }

        private void Card_Description_Click(object sender, EventArgs e)
        {

        }

        private void Card_Description_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.MidnightBlue;
        }

        private void Card_Description_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.SteelBlue;
        }
    }
}
