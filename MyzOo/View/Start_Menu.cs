using MyzOo.Methods;
using MyzOo.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyzOo
{
    public partial class Start_Menu : Form
    {
        private Firebase firebase;
        
        public Start_Menu()
        {
            InitializeComponent();
            firebase = new Firebase();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //set form colors
            panel1.BackColor = Color.DeepSkyBlue;
            Close_button.ForeColor = Color.DeepSkyBlue;
            label1.ForeColor = Color.White;
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            //Close the app
            Environment.Exit(0);
        }
        private void Login_button_Click(object sender, EventArgs e)
        {
            //close Start_Menu and open Main_Menu
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Hide();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                ClientCrud cc = new ClientCrud();
                string loginResult = cc.Login(email, password);

                if (loginResult != null)
                {
                    // Login successful, open Main_Menu
                    Main_Menu mainMenu = new Main_Menu();
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Errado.");
                }
            }
            else
            {
                MessageBox.Show("Escreva Email e Password");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "Username";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
