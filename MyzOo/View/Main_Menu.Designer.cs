namespace MyzOo
{
    partial class Main_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Perfil_image_picture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.Ver_Menu_Button = new System.Windows.Forms.Button();
            this.AnimalList_Menu_button = new System.Windows.Forms.Button();
            this.Employee_Menu_button = new System.Windows.Forms.Button();
            this.AnimalMenu_button = new System.Windows.Forms.Button();
            this.Food_Menu_button = new System.Windows.Forms.Button();
            this.Cell_Menu_button = new System.Windows.Forms.Button();
            this.VerComida_button = new System.Windows.Forms.Button();
            this.VerEmployee_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Perfil_image_picture)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.Minimize_button);
            this.panel1.Controls.Add(this.Exit_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Minimize_button
            // 
            this.Minimize_button.BackColor = System.Drawing.Color.Transparent;
            this.Minimize_button.FlatAppearance.BorderSize = 0;
            this.Minimize_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.Minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize_button.ForeColor = System.Drawing.SystemColors.Window;
            this.Minimize_button.Location = new System.Drawing.Point(688, 0);
            this.Minimize_button.Name = "Minimize_button";
            this.Minimize_button.Size = new System.Drawing.Size(56, 57);
            this.Minimize_button.TabIndex = 3;
            this.Minimize_button.Text = "-";
            this.Minimize_button.UseVisualStyleBackColor = false;
            this.Minimize_button.Click += new System.EventHandler(this.Minimize_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.Transparent;
            this.Exit_button.FlatAppearance.BorderSize = 0;
            this.Exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.ForeColor = System.Drawing.SystemColors.Window;
            this.Exit_button.Location = new System.Drawing.Point(744, 0);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(56, 57);
            this.Exit_button.TabIndex = 2;
            this.Exit_button.Text = "X";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(3, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "My zOo";
            // 
            // Perfil_image_picture
            // 
            this.Perfil_image_picture.Image = ((System.Drawing.Image)(resources.GetObject("Perfil_image_picture.Image")));
            this.Perfil_image_picture.Location = new System.Drawing.Point(13, 6);
            this.Perfil_image_picture.Name = "Perfil_image_picture";
            this.Perfil_image_picture.Size = new System.Drawing.Size(166, 159);
            this.Perfil_image_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Perfil_image_picture.TabIndex = 6;
            this.Perfil_image_picture.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Name_Box);
            this.panel2.Controls.Add(this.Perfil_image_picture);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 393);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nome: ";
            // 
            // Name_Box
            // 
            this.Name_Box.BackColor = System.Drawing.Color.Gray;
            this.Name_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name_Box.Enabled = false;
            this.Name_Box.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Name_Box.ForeColor = System.Drawing.Color.White;
            this.Name_Box.Location = new System.Drawing.Point(12, 193);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(167, 14);
            this.Name_Box.TabIndex = 25;
            // 
            // Ver_Menu_Button
            // 
            this.Ver_Menu_Button.AutoSize = true;
            this.Ver_Menu_Button.BackColor = System.Drawing.Color.Silver;
            this.Ver_Menu_Button.FlatAppearance.BorderSize = 0;
            this.Ver_Menu_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Ver_Menu_Button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Ver_Menu_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ver_Menu_Button.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ver_Menu_Button.ForeColor = System.Drawing.Color.Black;
            this.Ver_Menu_Button.Location = new System.Drawing.Point(664, 277);
            this.Ver_Menu_Button.Name = "Ver_Menu_Button";
            this.Ver_Menu_Button.Size = new System.Drawing.Size(124, 36);
            this.Ver_Menu_Button.TabIndex = 8;
            this.Ver_Menu_Button.Text = "Ver Celas";
            this.Ver_Menu_Button.UseVisualStyleBackColor = false;
            this.Ver_Menu_Button.Click += new System.EventHandler(this.Ver_Menu_Button_Click);
            // 
            // AnimalList_Menu_button
            // 
            this.AnimalList_Menu_button.AutoSize = true;
            this.AnimalList_Menu_button.BackColor = System.Drawing.Color.Silver;
            this.AnimalList_Menu_button.FlatAppearance.BorderSize = 0;
            this.AnimalList_Menu_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AnimalList_Menu_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AnimalList_Menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnimalList_Menu_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimalList_Menu_button.ForeColor = System.Drawing.Color.Black;
            this.AnimalList_Menu_button.Location = new System.Drawing.Point(264, 105);
            this.AnimalList_Menu_button.Name = "AnimalList_Menu_button";
            this.AnimalList_Menu_button.Size = new System.Drawing.Size(158, 36);
            this.AnimalList_Menu_button.TabIndex = 7;
            this.AnimalList_Menu_button.Text = "Lista Animal";
            this.AnimalList_Menu_button.UseVisualStyleBackColor = false;
            this.AnimalList_Menu_button.Click += new System.EventHandler(this.AnimalList_Menu_button_Click);
            // 
            // Employee_Menu_button
            // 
            this.Employee_Menu_button.AutoSize = true;
            this.Employee_Menu_button.BackColor = System.Drawing.Color.Silver;
            this.Employee_Menu_button.FlatAppearance.BorderSize = 0;
            this.Employee_Menu_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Employee_Menu_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Employee_Menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Employee_Menu_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_Menu_button.ForeColor = System.Drawing.Color.Black;
            this.Employee_Menu_button.Location = new System.Drawing.Point(631, 323);
            this.Employee_Menu_button.Name = "Employee_Menu_button";
            this.Employee_Menu_button.Size = new System.Drawing.Size(161, 36);
            this.Employee_Menu_button.TabIndex = 6;
            this.Employee_Menu_button.Text = "Menu Funcionário";
            this.Employee_Menu_button.UseVisualStyleBackColor = false;
            this.Employee_Menu_button.Click += new System.EventHandler(this.Employee_Menu_button_Click);
            // 
            // AnimalMenu_button
            // 
            this.AnimalMenu_button.AutoSize = true;
            this.AnimalMenu_button.BackColor = System.Drawing.Color.Silver;
            this.AnimalMenu_button.FlatAppearance.BorderSize = 0;
            this.AnimalMenu_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AnimalMenu_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AnimalMenu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnimalMenu_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimalMenu_button.ForeColor = System.Drawing.Color.Black;
            this.AnimalMenu_button.Location = new System.Drawing.Point(664, 63);
            this.AnimalMenu_button.Name = "AnimalMenu_button";
            this.AnimalMenu_button.Size = new System.Drawing.Size(129, 36);
            this.AnimalMenu_button.TabIndex = 5;
            this.AnimalMenu_button.Text = "Menu Animal";
            this.AnimalMenu_button.UseVisualStyleBackColor = false;
            this.AnimalMenu_button.Click += new System.EventHandler(this.AnimalMenu_button_Click);
            // 
            // Food_Menu_button
            // 
            this.Food_Menu_button.AutoSize = true;
            this.Food_Menu_button.BackColor = System.Drawing.Color.Silver;
            this.Food_Menu_button.FlatAppearance.BorderSize = 0;
            this.Food_Menu_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Food_Menu_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Food_Menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Food_Menu_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food_Menu_button.ForeColor = System.Drawing.Color.Black;
            this.Food_Menu_button.Location = new System.Drawing.Point(664, 144);
            this.Food_Menu_button.Name = "Food_Menu_button";
            this.Food_Menu_button.Size = new System.Drawing.Size(129, 36);
            this.Food_Menu_button.TabIndex = 6;
            this.Food_Menu_button.Text = "Menu Comida";
            this.Food_Menu_button.UseVisualStyleBackColor = false;
            this.Food_Menu_button.Click += new System.EventHandler(this.Food_Menu_button_Click);
            // 
            // Cell_Menu_button
            // 
            this.Cell_Menu_button.AutoSize = true;
            this.Cell_Menu_button.BackColor = System.Drawing.Color.Silver;
            this.Cell_Menu_button.FlatAppearance.BorderSize = 0;
            this.Cell_Menu_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Cell_Menu_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Cell_Menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cell_Menu_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cell_Menu_button.ForeColor = System.Drawing.Color.Black;
            this.Cell_Menu_button.Location = new System.Drawing.Point(664, 235);
            this.Cell_Menu_button.Name = "Cell_Menu_button";
            this.Cell_Menu_button.Size = new System.Drawing.Size(124, 36);
            this.Cell_Menu_button.TabIndex = 7;
            this.Cell_Menu_button.Text = "Menu Celas";
            this.Cell_Menu_button.UseVisualStyleBackColor = false;
            this.Cell_Menu_button.Click += new System.EventHandler(this.Cell_Menu_button_Click);
            // 
            // VerComida_button
            // 
            this.VerComida_button.AutoSize = true;
            this.VerComida_button.BackColor = System.Drawing.Color.Silver;
            this.VerComida_button.FlatAppearance.BorderSize = 0;
            this.VerComida_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.VerComida_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.VerComida_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerComida_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerComida_button.ForeColor = System.Drawing.Color.Black;
            this.VerComida_button.Location = new System.Drawing.Point(664, 186);
            this.VerComida_button.Name = "VerComida_button";
            this.VerComida_button.Size = new System.Drawing.Size(129, 36);
            this.VerComida_button.TabIndex = 9;
            this.VerComida_button.Text = "Ver Comida";
            this.VerComida_button.UseVisualStyleBackColor = false;
            this.VerComida_button.Click += new System.EventHandler(this.VerComida_button_Click);
            // 
            // VerEmployee_button
            // 
            this.VerEmployee_button.AutoSize = true;
            this.VerEmployee_button.BackColor = System.Drawing.Color.Silver;
            this.VerEmployee_button.FlatAppearance.BorderSize = 0;
            this.VerEmployee_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.VerEmployee_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.VerEmployee_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerEmployee_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerEmployee_button.ForeColor = System.Drawing.Color.Black;
            this.VerEmployee_button.Location = new System.Drawing.Point(631, 365);
            this.VerEmployee_button.Name = "VerEmployee_button";
            this.VerEmployee_button.Size = new System.Drawing.Size(161, 33);
            this.VerEmployee_button.TabIndex = 10;
            this.VerEmployee_button.Text = "Ver Funcionário";
            this.VerEmployee_button.UseVisualStyleBackColor = false;
            this.VerEmployee_button.Click += new System.EventHandler(this.VerEmployee_button_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(264, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Lista Comida";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(264, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Lista Funcionário";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(264, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 36);
            this.button3.TabIndex = 13;
            this.button3.Text = "Lista Celas";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Employee_Menu_button);
            this.Controls.Add(this.Ver_Menu_Button);
            this.Controls.Add(this.VerEmployee_button);
            this.Controls.Add(this.AnimalList_Menu_button);
            this.Controls.Add(this.VerComida_button);
            this.Controls.Add(this.Cell_Menu_button);
            this.Controls.Add(this.Food_Menu_button);
            this.Controls.Add(this.AnimalMenu_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Menu";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Perfil_image_picture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button Minimize_button;
        private System.Windows.Forms.Button AnimalMenu_button;
        private System.Windows.Forms.PictureBox Perfil_image_picture;
        private System.Windows.Forms.Button Food_Menu_button;
        private System.Windows.Forms.Button Cell_Menu_button;
        private System.Windows.Forms.Button Employee_Menu_button;
        private System.Windows.Forms.Button AnimalList_Menu_button;
        private System.Windows.Forms.Button Ver_Menu_Button;
        private System.Windows.Forms.Button VerComida_button;
        private System.Windows.Forms.Button VerEmployee_button;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}