using MyzOo.Methods;
using MyzOo.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media;

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
            /*panel1.BackColor = Color.DeepSkyBlue;
            Close_button.ForeColor = Color.DeepSkyBlue;
            label1.ForeColor = Color.White;
            textBox2.BackColor = Color.FromArgb(241, 247, 255);*/
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
                EmployeeCrud cc = new EmployeeCrud();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";

                textBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";

                textBox1.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Password")
            {
                textBox1.Text = "";

                textBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Password";

                textBox1.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
