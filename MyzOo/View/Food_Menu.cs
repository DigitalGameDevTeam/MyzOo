using MyzOo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace MyzOo.View
{
    public partial class Food_Menu : Form
    {
        public Food_Menu()
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            //hide this Menu
            this.Hide();
        }

        private void Food_desciption_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Stock_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Regist_button_Click(object sender, EventArgs e)
        {
            string name = Name_Box.Text;
            string description = Food_desciption_textbox.Text;
            int stock = Convert.ToInt32(Stock_textbox.Text);

            // Create an instance of the Random class
            Random random = new Random();

            // Generate a random ID with 4 numbers
            int id = random.Next(1000, 10000);

            Food food = new Food(id, name, description, stock);
            Food.FoodList.Add(food);

            MessageBox.Show($"Registo realizado com sucesso '{name} {description}' ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
        }
    }
}
