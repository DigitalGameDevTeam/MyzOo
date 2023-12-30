namespace MyzOo.View
{
    partial class FoodData_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodData_Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeFood_listbox = new System.Windows.Forms.ComboBox();
            this.Food_desciption_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Stock_Number = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stock_Number)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inspecionar Comida";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exit_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 57);
            this.panel1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(230, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 56;
            this.label4.Text = "Comida :";
            // 
            // TypeFood_listbox
            // 
            this.TypeFood_listbox.BackColor = System.Drawing.Color.LightGray;
            this.TypeFood_listbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeFood_listbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeFood_listbox.FormattingEnabled = true;
            this.TypeFood_listbox.Location = new System.Drawing.Point(296, 79);
            this.TypeFood_listbox.Name = "TypeFood_listbox";
            this.TypeFood_listbox.Size = new System.Drawing.Size(291, 21);
            this.TypeFood_listbox.TabIndex = 55;
            this.TypeFood_listbox.SelectedIndexChanged += new System.EventHandler(this.Cell_listbox_SelectedIndexChanged);
            // 
            // Food_desciption_textbox
            // 
            this.Food_desciption_textbox.BackColor = System.Drawing.Color.LightGray;
            this.Food_desciption_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Food_desciption_textbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Food_desciption_textbox.ForeColor = System.Drawing.Color.Black;
            this.Food_desciption_textbox.Location = new System.Drawing.Point(233, 130);
            this.Food_desciption_textbox.Multiline = true;
            this.Food_desciption_textbox.Name = "Food_desciption_textbox";
            this.Food_desciption_textbox.Size = new System.Drawing.Size(354, 121);
            this.Food_desciption_textbox.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(417, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 51;
            this.label6.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(230, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 50;
            this.label3.Text = "Descrição da Comida:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.Color.Red;
            this.Delete_Button.FlatAppearance.BorderSize = 0;
            this.Delete_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.Delete_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.ForeColor = System.Drawing.Color.White;
            this.Delete_Button.Location = new System.Drawing.Point(363, 308);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(94, 39);
            this.Delete_Button.TabIndex = 58;
            this.Delete_Button.Text = "Apagar";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.BackColor = System.Drawing.Color.Lime;
            this.Update_Button.FlatAppearance.BorderSize = 0;
            this.Update_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.Update_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.Update_Button.ForeColor = System.Drawing.Color.Black;
            this.Update_Button.Location = new System.Drawing.Point(463, 308);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(124, 39);
            this.Update_Button.TabIndex = 57;
            this.Update_Button.Text = "Atualizar";
            this.Update_Button.UseVisualStyleBackColor = false;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Stock_Number
            // 
            this.Stock_Number.Location = new System.Drawing.Point(467, 273);
            this.Stock_Number.Name = "Stock_Number";
            this.Stock_Number.Size = new System.Drawing.Size(120, 20);
            this.Stock_Number.TabIndex = 59;
            this.Stock_Number.ValueChanged += new System.EventHandler(this.Stock_Number_ValueChanged);
            // 
            // FoodData_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 359);
            this.Controls.Add(this.Stock_Number);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TypeFood_listbox);
            this.Controls.Add(this.Food_desciption_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FoodData_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodList_menu";
            this.Load += new System.EventHandler(this.FoodList_menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stock_Number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TypeFood_listbox;
        private System.Windows.Forms.TextBox Food_desciption_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.NumericUpDown Stock_Number;
    }
}