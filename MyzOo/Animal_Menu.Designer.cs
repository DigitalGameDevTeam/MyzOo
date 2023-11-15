namespace MyzOo
{
    partial class Animal_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animal_Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.food_list = new System.Windows.Forms.DomainUpDown();
            this.checkup_Box = new System.Windows.Forms.CheckBox();
            this.cell_list = new System.Windows.Forms.DomainUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.regist_button = new System.Windows.Forms.Button();
            this.birthday_Calendar = new System.Windows.Forms.MonthCalendar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 57);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "My zOo";
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.SystemColors.Window;
            this.exit_button.Location = new System.Drawing.Point(543, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(56, 57);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Animal >>> ";
            // 
            // name_Box
            // 
            this.name_Box.Location = new System.Drawing.Point(344, 72);
            this.name_Box.Name = "name_Box";
            this.name_Box.Size = new System.Drawing.Size(227, 20);
            this.name_Box.TabIndex = 3;
            this.name_Box.TextChanged += new System.EventHandler(this.name_Box_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data do Animal >>> ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cela do Animal >>> ";
            // 
            // food_list
            // 
            this.food_list.Items.Add("Cela 1");
            this.food_list.Items.Add("Cela 2");
            this.food_list.Items.Add("Cela 3");
            this.food_list.Items.Add("Cela 4");
            this.food_list.Location = new System.Drawing.Point(358, 281);
            this.food_list.Name = "food_list";
            this.food_list.ReadOnly = true;
            this.food_list.Size = new System.Drawing.Size(213, 20);
            this.food_list.TabIndex = 11;
            this.food_list.Text = "...";
            this.food_list.SelectedItemChanged += new System.EventHandler(this.food_list_SelectedItemChanged);
            // 
            // checkup_Box
            // 
            this.checkup_Box.AutoSize = true;
            this.checkup_Box.Location = new System.Drawing.Point(79, 273);
            this.checkup_Box.Name = "checkup_Box";
            this.checkup_Box.Size = new System.Drawing.Size(69, 17);
            this.checkup_Box.TabIndex = 12;
            this.checkup_Box.Text = "Checkup";
            this.checkup_Box.UseVisualStyleBackColor = true;
            this.checkup_Box.CheckedChanged += new System.EventHandler(this.checkup_Box_CheckedChanged);
            // 
            // cell_list
            // 
            this.cell_list.Items.Add("Frango");
            this.cell_list.Items.Add("Pizza");
            this.cell_list.Items.Add("Batatas Fritas");
            this.cell_list.Items.Add("Relva");
            this.cell_list.Items.Add("Erva");
            this.cell_list.Location = new System.Drawing.Point(358, 316);
            this.cell_list.Name = "cell_list";
            this.cell_list.ReadOnly = true;
            this.cell_list.Size = new System.Drawing.Size(213, 20);
            this.cell_list.TabIndex = 14;
            this.cell_list.Text = "...";
            this.cell_list.SelectedItemChanged += new System.EventHandler(this.cell_list_SelectedItemChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Comida do Animal >>> ";
            // 
            // regist_button
            // 
            this.regist_button.Location = new System.Drawing.Point(510, 355);
            this.regist_button.Name = "regist_button";
            this.regist_button.Size = new System.Drawing.Size(75, 23);
            this.regist_button.TabIndex = 17;
            this.regist_button.Text = "Registrar";
            this.regist_button.UseVisualStyleBackColor = true;
            this.regist_button.Click += new System.EventHandler(this.regist_button_Click);
            // 
            // birthday_Calendar
            // 
            this.birthday_Calendar.Location = new System.Drawing.Point(344, 101);
            this.birthday_Calendar.Name = "birthday_Calendar";
            this.birthday_Calendar.TabIndex = 18;
            this.birthday_Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.birthday_Calendar_DateChanged);
            // 
            // Animal_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 417);
            this.Controls.Add(this.birthday_Calendar);
            this.Controls.Add(this.regist_button);
            this.Controls.Add(this.cell_list);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkup_Box);
            this.Controls.Add(this.food_list);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Animal_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animal_Menu";
            this.Load += new System.EventHandler(this.Animal_Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DomainUpDown food_list;
        private System.Windows.Forms.CheckBox checkup_Box;
        private System.Windows.Forms.DomainUpDown cell_list;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button regist_button;
        private System.Windows.Forms.MonthCalendar birthday_Calendar;
    }
}