namespace MyzOo.View
{
    partial class Ver_Animal_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ver_Animal_Menu));
            this.Food_listbox = new System.Windows.Forms.ComboBox();
            this.Cell_listbox = new System.Windows.Forms.ComboBox();
            this.Birthday_Calendar = new System.Windows.Forms.MonthCalendar();
            this.Regist_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Checkup_Box = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Gender_listbox = new System.Windows.Forms.ComboBox();
            this.Decease_Box = new System.Windows.Forms.CheckBox();
            this.Delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Food_listbox
            // 
            this.Food_listbox.BackColor = System.Drawing.Color.LightGray;
            this.Food_listbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Food_listbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Food_listbox.FormattingEnabled = true;
            this.Food_listbox.Location = new System.Drawing.Point(354, 308);
            this.Food_listbox.Name = "Food_listbox";
            this.Food_listbox.Size = new System.Drawing.Size(224, 21);
            this.Food_listbox.TabIndex = 32;
            this.Food_listbox.SelectedIndexChanged += new System.EventHandler(this.Food_listbox_SelectedIndexChanged);
            // 
            // Cell_listbox
            // 
            this.Cell_listbox.BackColor = System.Drawing.Color.LightGray;
            this.Cell_listbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cell_listbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cell_listbox.FormattingEnabled = true;
            this.Cell_listbox.Location = new System.Drawing.Point(354, 275);
            this.Cell_listbox.Name = "Cell_listbox";
            this.Cell_listbox.Size = new System.Drawing.Size(224, 21);
            this.Cell_listbox.TabIndex = 31;
            // 
            // Birthday_Calendar
            // 
            this.Birthday_Calendar.BackColor = System.Drawing.Color.LightGray;
            this.Birthday_Calendar.Location = new System.Drawing.Point(354, 101);
            this.Birthday_Calendar.Name = "Birthday_Calendar";
            this.Birthday_Calendar.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2023, 11, 15, 0, 0, 0, 0), new System.DateTime(2023, 11, 21, 0, 0, 0, 0));
            this.Birthday_Calendar.ShowToday = false;
            this.Birthday_Calendar.TabIndex = 30;
            // 
            // Regist_button
            // 
            this.Regist_button.BackColor = System.Drawing.Color.Lime;
            this.Regist_button.FlatAppearance.BorderSize = 0;
            this.Regist_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.Regist_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Regist_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regist_button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.Regist_button.ForeColor = System.Drawing.Color.Black;
            this.Regist_button.Location = new System.Drawing.Point(454, 370);
            this.Regist_button.Name = "Regist_button";
            this.Regist_button.Size = new System.Drawing.Size(124, 39);
            this.Regist_button.TabIndex = 29;
            this.Regist_button.Text = "Atualizar";
            this.Regist_button.UseVisualStyleBackColor = false;
            this.Regist_button.Click += new System.EventHandler(this.Regist_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(229, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Comida do Animal :";
            // 
            // Checkup_Box
            // 
            this.Checkup_Box.AutoSize = true;
            this.Checkup_Box.BackColor = System.Drawing.Color.Transparent;
            this.Checkup_Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Checkup_Box.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Checkup_Box.Location = new System.Drawing.Point(72, 288);
            this.Checkup_Box.Name = "Checkup_Box";
            this.Checkup_Box.Size = new System.Drawing.Size(73, 19);
            this.Checkup_Box.TabIndex = 27;
            this.Checkup_Box.Text = "Checkup";
            this.Checkup_Box.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(248, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cela do Animal :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(240, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Data do Animal :";
            // 
            // Name_Box
            // 
            this.Name_Box.BackColor = System.Drawing.Color.LightGray;
            this.Name_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name_Box.Enabled = false;
            this.Name_Box.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Name_Box.ForeColor = System.Drawing.Color.Black;
            this.Name_Box.Location = new System.Drawing.Point(354, 71);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(227, 14);
            this.Name_Box.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(240, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nome do Animal :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exit_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 57);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inspecionar Animal";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(282, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Genero : ";
            // 
            // Gender_listbox
            // 
            this.Gender_listbox.BackColor = System.Drawing.Color.LightGray;
            this.Gender_listbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender_listbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gender_listbox.FormattingEnabled = true;
            this.Gender_listbox.Location = new System.Drawing.Point(354, 341);
            this.Gender_listbox.Name = "Gender_listbox";
            this.Gender_listbox.Size = new System.Drawing.Size(224, 21);
            this.Gender_listbox.TabIndex = 33;
            // 
            // Decease_Box
            // 
            this.Decease_Box.AutoSize = true;
            this.Decease_Box.BackColor = System.Drawing.Color.Transparent;
            this.Decease_Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decease_Box.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Decease_Box.Location = new System.Drawing.Point(72, 313);
            this.Decease_Box.Name = "Decease_Box";
            this.Decease_Box.Size = new System.Drawing.Size(64, 19);
            this.Decease_Box.TabIndex = 35;
            this.Decease_Box.Text = "Doente";
            this.Decease_Box.UseVisualStyleBackColor = false;
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.Red;
            this.Delete_button.FlatAppearance.BorderSize = 0;
            this.Delete_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.Delete_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.ForeColor = System.Drawing.Color.White;
            this.Delete_button.Location = new System.Drawing.Point(354, 370);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(94, 39);
            this.Delete_button.TabIndex = 36;
            this.Delete_button.Text = "Apagar";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Ver_Animal_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 417);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Decease_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Gender_listbox);
            this.Controls.Add(this.Food_listbox);
            this.Controls.Add(this.Cell_listbox);
            this.Controls.Add(this.Birthday_Calendar);
            this.Controls.Add(this.Regist_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Checkup_Box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ver_Animal_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver_Animal_Menu";
            this.Load += new System.EventHandler(this.Ver_Animal_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Food_listbox;
        private System.Windows.Forms.ComboBox Cell_listbox;
        private System.Windows.Forms.MonthCalendar Birthday_Calendar;
        private System.Windows.Forms.Button Regist_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox Checkup_Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Gender_listbox;
        private System.Windows.Forms.CheckBox Decease_Box;
        private System.Windows.Forms.Button Delete_button;
    }
}