using MyzOo.Models;
using MyzOo.Methods;
using MyzOo.Models;
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
using System.Xml.Linq;

namespace MyzOo.View
{
    public partial class Food_Menu : Form
    {
        string userId;
        public Food_Menu(string userID)
        {
            InitializeComponent();
            userId = userID;
        }
        private void Food_Menu_Load(object sender, EventArgs e)
        {
            foreach (var data in TypeFood.LoadData())
            {
                TypeFood_listbox.Items.Add(data.Type);
            }
        }
        private void Exit_button_Click(object sender, EventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu(userId);
            main_Menu.Show();
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
            string description = Food_desciption_textbox.Text;

            // Instead of TypeFood_listbox.SelectedItem.ToString(), use TypeFood_listbox.Text
            string typeName = TypeFood_listbox.Text;
            TypeFood typeFood = TypeFood.LoadData().FirstOrDefault(tf => tf.Type == typeName);
            //TypeFood typeFood = TypeFood.TypeFoodList.FirstOrDefault(tf => tf.Type == typeName);   

            int stock = (int)Stock_Number.Value;

            // Create an instance of the Random class
            Random random = new Random();
            
            // - Guid.NewGuid();
            // TODO
            string id = Guid.NewGuid().ToString();

            FoodCrud food = new FoodCrud();
            food.SetData(id, description, typeFood.Type, stock);

            Main_Menu main_Menu = new Main_Menu(userId);
            main_Menu.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TypeFood_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TypeFood_listbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
