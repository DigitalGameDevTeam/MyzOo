using MyzOo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace MyzOo.View
{
    public partial class FoodData_Menu : Form
    {

        private string foodID;
        private Food food;
        string userId;
        public FoodData_Menu(string foodId, string userId)
        {
            InitializeComponent();
            foodID = foodId;
            this.userId = userId;
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            FoodList foodList = new FoodList(userId);
            foodList.Show();
            this.Hide();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
          
        }

        private void FoodList_menu_Load(object sender, EventArgs e)
        {
            Food_desciption_textbox.Enabled = true;
            Stock_Number.Enabled = true;
            TypeFood_listbox.Enabled = true;

            food = Food.GetFood(foodID);

            foreach (var typeFood in TypeFood.LoadData())
            {
                TypeFood_listbox.Items.Add(typeFood.Type);
            }

            Food_desciption_textbox.Text = food.Description;
            Stock_Number.Text = food.Stock.ToString();
            TypeFood_listbox.Text = food.TypeFood;
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            string id = foodID;

            // Food Info
            string description = Food_desciption_textbox.Text;
            string typeFodd = TypeFood_listbox.Text;
            int stock = (int)Stock_Number.Value;


            // Retrieve selected food values
            // Food
            string typeFood = TypeFood_listbox.Text;
            Food foodTypeFood = Food.LoadData().FirstOrDefault(tf => tf.Description == typeFood);

            food.UpdateData(id, description, typeFood, stock);

            FoodList foodList = new FoodList(userId);
            foodList.Show();
            this.Hide();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            string id = foodID;
            string description = Food_desciption_textbox.Text;

            food.DeleteData(id, description);

            FoodList foodList = new FoodList(userId);
            foodList.Show();
            this.Hide();
        }

        private void Cell_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Name_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Stock_Number_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
