using MyzOo.Methods;
using System;
using System.Windows.Forms;

namespace MyzOo.View
{
    public partial class CellData_Register : Form
    {
        public CellData_Register()
        {
            InitializeComponent();
        }

        private void Animallist_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cellnumber_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            //hide this Menu and open Main Menu
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Hide();
        }

        private void Regist_button_Click(object sender, EventArgs e)
        {
            // Create an instance of the Random class
            Random random = new Random();

            // Generate a random ID with 4 numbers
            int id = random.Next(1000, 10000);
            
            int number = Convert.ToInt32(Cellnumber_Box.Text);
            bool cleaning = Checkup_Box.Checked;
            string description = CellDescription_textbox.Text;

            CellCrud cell = new CellCrud();
            cell.SetData(id, number, cleaning, description);


            MessageBox.Show("Registo realizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
        }

        private void Cell_Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
