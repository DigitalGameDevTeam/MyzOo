using MyzOo.Methods;
using MyzOo.Models;
using MyzOo.View;
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


            Environment.Exit(0);
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
                    CurrentUser currentUser = new CurrentUser();
                    currentUser.Id = loginResult;

                    // Open the Main_Menu form and set the current user
                    Main_Menu mainMenuForm = new Main_Menu();
                    mainMenuForm.Show();
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
