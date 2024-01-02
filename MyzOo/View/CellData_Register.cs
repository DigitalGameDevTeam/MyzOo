using MyzOo.Methods;
using System;
using System.Windows.Forms;

namespace MyzOo.View
{
    public partial class CellData_Register : Form
    {
        string userId;
        public CellData_Register(string userID)
        {
            InitializeComponent();
            userId = userID;
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            //hide this Menu and open Main Menu
            Main_Menu main_Menu = new Main_Menu(userId);
            main_Menu.Show();
            this.Hide();
        }

        private void Regist_button_Click(object sender, EventArgs e)
        {
            // Generate a random ID with 4 numbers
            string id = Guid.NewGuid().ToString();
            
            int number = (int)Cell_Number.Value;
            bool cleaning = Checkup_Box.Checked;
            string description = CellDescription_textbox.Text;

            CellCrud cell = new CellCrud();
            cell.SetData(id, number, cleaning, description);

            Main_Menu main_Menu = new Main_Menu(userId);
            main_Menu.Show();

            this.Hide();
        }

        private void Cell_Menu_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Animallist_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cellnumber_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
