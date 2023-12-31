namespace MyzOo.View
{
    partial class CellData_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CellData_Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Checkup_Box = new System.Windows.Forms.CheckBox();
            this.CellDescription_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Cellnumber_Number = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cellnumber_Number)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inspecionar Cela";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exit_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 57);
            this.panel1.TabIndex = 44;
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
            // Checkup_Box
            // 
            this.Checkup_Box.AutoSize = true;
            this.Checkup_Box.BackColor = System.Drawing.Color.Transparent;
            this.Checkup_Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Checkup_Box.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Checkup_Box.Location = new System.Drawing.Point(12, 127);
            this.Checkup_Box.Name = "Checkup_Box";
            this.Checkup_Box.Size = new System.Drawing.Size(70, 19);
            this.Checkup_Box.TabIndex = 51;
            this.Checkup_Box.Text = "Limpeza";
            this.Checkup_Box.UseVisualStyleBackColor = false;
            // 
            // CellDescription_textbox
            // 
            this.CellDescription_textbox.BackColor = System.Drawing.Color.LightGray;
            this.CellDescription_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CellDescription_textbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.CellDescription_textbox.ForeColor = System.Drawing.Color.Black;
            this.CellDescription_textbox.Location = new System.Drawing.Point(225, 93);
            this.CellDescription_textbox.Multiline = true;
            this.CellDescription_textbox.Name = "CellDescription_textbox";
            this.CellDescription_textbox.Size = new System.Drawing.Size(355, 121);
            this.CellDescription_textbox.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(222, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "Descrição da Cela:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "Número da Cela :";
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
            this.Delete_Button.Location = new System.Drawing.Point(486, 317);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(94, 33);
            this.Delete_Button.TabIndex = 63;
            this.Delete_Button.Text = "Apagar";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.Update_Button.FlatAppearance.BorderSize = 0;
            this.Update_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.Update_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Update_Button.ForeColor = System.Drawing.Color.White;
            this.Update_Button.Location = new System.Drawing.Point(12, 323);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(107, 33);
            this.Update_Button.TabIndex = 62;
            this.Update_Button.Text = "Atualizar";
            this.Update_Button.UseVisualStyleBackColor = false;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Cellnumber_Number
            // 
            this.Cellnumber_Number.Location = new System.Drawing.Point(12, 89);
            this.Cellnumber_Number.Name = "Cellnumber_Number";
            this.Cellnumber_Number.Size = new System.Drawing.Size(197, 20);
            this.Cellnumber_Number.TabIndex = 64;
            // 
            // CellData_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 368);
            this.Controls.Add(this.Cellnumber_Number);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Checkup_Box);
            this.Controls.Add(this.CellDescription_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CellData_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerCela_Menu";
            this.Load += new System.EventHandler(this.VerCela_Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cellnumber_Number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.CheckBox Checkup_Box;
        private System.Windows.Forms.TextBox CellDescription_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.NumericUpDown Cellnumber_Number;
    }
}