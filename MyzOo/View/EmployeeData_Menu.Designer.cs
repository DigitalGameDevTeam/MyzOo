﻿namespace MyzOo.View
{
    partial class EmployeeData_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeData_Menu));
            this.Pass_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Admin_listbox = new System.Windows.Forms.ComboBox();
            this.Func_listbox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Regist_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Birthday_Calendar = new System.Windows.Forms.DateTimePicker();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pass_textbox
            // 
            this.Pass_textbox.BackColor = System.Drawing.Color.LightGray;
            this.Pass_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pass_textbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Pass_textbox.ForeColor = System.Drawing.Color.Black;
            this.Pass_textbox.Location = new System.Drawing.Point(12, 254);
            this.Pass_textbox.Name = "Pass_textbox";
            this.Pass_textbox.Size = new System.Drawing.Size(228, 14);
            this.Pass_textbox.TabIndex = 66;
            this.Pass_textbox.TextChanged += new System.EventHandler(this.Pass_textbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(10, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 65;
            this.label5.Text = "Nova password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 368);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 64;
            this.button1.Text = "Registar funcionário";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Admin_listbox
            // 
            this.Admin_listbox.BackColor = System.Drawing.Color.LightGray;
            this.Admin_listbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Admin_listbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin_listbox.FormattingEnabled = true;
            this.Admin_listbox.Location = new System.Drawing.Point(12, 203);
            this.Admin_listbox.Name = "Admin_listbox";
            this.Admin_listbox.Size = new System.Drawing.Size(229, 21);
            this.Admin_listbox.TabIndex = 63;
            // 
            // Func_listbox
            // 
            this.Func_listbox.BackColor = System.Drawing.Color.LightGray;
            this.Func_listbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Func_listbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Func_listbox.FormattingEnabled = true;
            this.Func_listbox.Location = new System.Drawing.Point(12, 152);
            this.Func_listbox.Name = "Func_listbox";
            this.Func_listbox.Size = new System.Drawing.Size(229, 21);
            this.Func_listbox.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(10, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 15);
            this.label7.TabIndex = 59;
            this.label7.Text = "Nivel de Administração :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(10, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 57;
            this.label6.Text = "Função : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(341, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 56;
            this.label3.Text = "Data de Aniversário :";
            // 
            // Name_Box
            // 
            this.Name_Box.BackColor = System.Drawing.Color.LightGray;
            this.Name_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name_Box.Enabled = false;
            this.Name_Box.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Name_Box.ForeColor = System.Drawing.Color.Black;
            this.Name_Box.Location = new System.Drawing.Point(13, 105);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(227, 14);
            this.Name_Box.TabIndex = 55;
            this.Name_Box.TextChanged += new System.EventHandler(this.Name_Box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(10, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 54;
            this.label2.Text = "Nome do Funcionário :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.Minimize_button);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Exit_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 57);
            this.panel1.TabIndex = 53;
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
            this.Minimize_button.Location = new System.Drawing.Point(481, 0);
            this.Minimize_button.Name = "Minimize_button";
            this.Minimize_button.Size = new System.Drawing.Size(56, 57);
            this.Minimize_button.TabIndex = 49;
            this.Minimize_button.Text = "-";
            this.Minimize_button.UseVisualStyleBackColor = false;
            this.Minimize_button.Click += new System.EventHandler(this.Minimize_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(459, 60);
            this.label4.TabIndex = 2;
            this.label4.Text = "Editar Funcionário";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.Transparent;
            this.Exit_button.FlatAppearance.BorderSize = 0;
            this.Exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.ForeColor = System.Drawing.SystemColors.Window;
            this.Exit_button.Location = new System.Drawing.Point(543, 0);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(56, 57);
            this.Exit_button.TabIndex = 3;
            this.Exit_button.Text = "X";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Regist_button
            // 
            this.Regist_button.BackColor = System.Drawing.Color.SteelBlue;
            this.Regist_button.FlatAppearance.BorderSize = 0;
            this.Regist_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.Regist_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Regist_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regist_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Regist_button.ForeColor = System.Drawing.Color.White;
            this.Regist_button.Location = new System.Drawing.Point(24, 321);
            this.Regist_button.Name = "Regist_button";
            this.Regist_button.Size = new System.Drawing.Size(107, 33);
            this.Regist_button.TabIndex = 60;
            this.Regist_button.Text = "Confirmar";
            this.Regist_button.UseVisualStyleBackColor = false;
            this.Regist_button.Click += new System.EventHandler(this.Regist_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 105);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 51;
            this.button2.Text = "Registar funcionário";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Birthday_Calendar
            // 
            this.Birthday_Calendar.Location = new System.Drawing.Point(344, 89);
            this.Birthday_Calendar.Name = "Birthday_Calendar";
            this.Birthday_Calendar.Size = new System.Drawing.Size(200, 20);
            this.Birthday_Calendar.TabIndex = 72;

            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.Color.Red;
            this.Delete_Button.FlatAppearance.BorderSize = 0;
            this.Delete_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.Delete_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Delete_Button.ForeColor = System.Drawing.Color.White;
            this.Delete_Button.Location = new System.Drawing.Point(437, 321);
            this.Delete_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(107, 33);
            this.Delete_Button.TabIndex = 73;
            this.Delete_Button.Text = "Apagar";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // EmployeeData_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 390);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Birthday_Calendar);
            this.Controls.Add(this.Pass_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Admin_listbox);
            this.Controls.Add(this.Func_listbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Regist_button);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeData_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver_Employee_Menu";
            this.Load += new System.EventHandler(this.Ver_Employee_Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Pass_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Admin_listbox;
        private System.Windows.Forms.ComboBox Func_listbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Minimize_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button Regist_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker Birthday_Calendar;
        private System.Windows.Forms.Button Delete_Button;
    }
}