namespace MyzOo.View
{
    partial class Employee_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Menu));
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Food_listbox = new System.Windows.Forms.ComboBox();
            this.Cell_listbox = new System.Windows.Forms.ComboBox();
            this.Birthday_Calendar = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.Checkup_Box = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Regist_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 95);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 1;
            this.button2.Text = "Registar funcionário";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Food_listbox
            // 
            this.Food_listbox.BackColor = System.Drawing.Color.LightGray;
            this.Food_listbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Food_listbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Food_listbox.FormattingEnabled = true;
            this.Food_listbox.Location = new System.Drawing.Point(361, 325);
            this.Food_listbox.Name = "Food_listbox";
            this.Food_listbox.Size = new System.Drawing.Size(210, 21);
            this.Food_listbox.TabIndex = 45;
            // 
            // Cell_listbox
            // 
            this.Cell_listbox.BackColor = System.Drawing.Color.LightGray;
            this.Cell_listbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cell_listbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cell_listbox.FormattingEnabled = true;
            this.Cell_listbox.Location = new System.Drawing.Point(347, 300);
            this.Cell_listbox.Name = "Cell_listbox";
            this.Cell_listbox.Size = new System.Drawing.Size(224, 21);
            this.Cell_listbox.TabIndex = 44;
            // 
            // Birthday_Calendar
            // 
            this.Birthday_Calendar.BackColor = System.Drawing.Color.LightGray;
            this.Birthday_Calendar.Location = new System.Drawing.Point(344, 120);
            this.Birthday_Calendar.Name = "Birthday_Calendar";
            this.Birthday_Calendar.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2023, 11, 15, 0, 0, 0, 0), new System.DateTime(2023, 11, 21, 0, 0, 0, 0));
            this.Birthday_Calendar.ShowToday = false;
            this.Birthday_Calendar.TabIndex = 43;
            this.Birthday_Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Birthday_Calendar_DateChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(218, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 15);
            this.label7.TabIndex = 41;
            this.label7.Text = "Nivel de Administração :";
            // 
            // Checkup_Box
            // 
            this.Checkup_Box.AutoSize = true;
            this.Checkup_Box.BackColor = System.Drawing.Color.Transparent;
            this.Checkup_Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Checkup_Box.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Checkup_Box.Location = new System.Drawing.Point(12, 297);
            this.Checkup_Box.Name = "Checkup_Box";
            this.Checkup_Box.Size = new System.Drawing.Size(73, 19);
            this.Checkup_Box.TabIndex = 40;
            this.Checkup_Box.Text = "Checkup";
            this.Checkup_Box.UseVisualStyleBackColor = false;
            this.Checkup_Box.CheckedChanged += new System.EventHandler(this.Checkup_Box_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(298, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Função: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(230, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Data do Funcionário :";
            // 
            // Name_Box
            // 
            this.Name_Box.BackColor = System.Drawing.Color.LightGray;
            this.Name_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name_Box.Enabled = false;
            this.Name_Box.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Name_Box.ForeColor = System.Drawing.Color.Black;
            this.Name_Box.Location = new System.Drawing.Point(344, 90);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(227, 14);
            this.Name_Box.TabIndex = 37;
            this.Name_Box.TextChanged += new System.EventHandler(this.Name_Box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(218, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nome do Funcionário :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.Minimize_button);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Exit_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 57);
            this.panel1.TabIndex = 34;
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
            this.label4.Location = new System.Drawing.Point(12, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 60);
            this.label4.TabIndex = 2;
            this.label4.Text = "Funcionário";
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
            this.Regist_button.BackColor = System.Drawing.Color.Transparent;
            this.Regist_button.FlatAppearance.BorderSize = 0;
            this.Regist_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.Regist_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Regist_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regist_button.ForeColor = System.Drawing.Color.Black;
            this.Regist_button.Location = new System.Drawing.Point(510, 374);
            this.Regist_button.Name = "Regist_button";
            this.Regist_button.Size = new System.Drawing.Size(75, 23);
            this.Regist_button.TabIndex = 42;
            this.Regist_button.Text = "Registrar";
            this.Regist_button.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(347, 353);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 14);
            this.textBox1.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(260, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "Palavra Passe:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 358);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 46;
            this.button1.Text = "Registar funcionário";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Employee_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 417);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Food_listbox);
            this.Controls.Add(this.Cell_listbox);
            this.Controls.Add(this.Birthday_Calendar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Checkup_Box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Regist_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Employee_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Menu";
            this.Load += new System.EventHandler(this.Employee_Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Food_listbox;
        private System.Windows.Forms.ComboBox Cell_listbox;
        private System.Windows.Forms.MonthCalendar Birthday_Calendar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox Checkup_Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button Regist_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Minimize_button;
    }
}