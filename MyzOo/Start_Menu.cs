using MyzOo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyzOo
{
    public partial class Start_Menu : Form
    {
        
        public Start_Menu()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2015, 10, 12);

            // Cell
            Cell cellInstance = new Cell
            {
                Id = 1,
                Cleaning = true
            };

            // Food
            Food foodInstance = new Food
            {
                Id = 1,
                Typefood = "Carnivore",
                Description = "Meat-based diet",
                Stock = 10
            };

            // animal
            Animal animal = new Animal(1, "Leão", DateTime.Now, false, cellInstance, foodInstance);

            string nome = animal.Name;

            button2.Text = nome;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //Close the app
            Environment.Exit(0);
        }
        private void label1_Click(object sender, EventArgs e)
        {
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //close Start_Menu and open Main_Menu
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Hide();
        }
    }
}
