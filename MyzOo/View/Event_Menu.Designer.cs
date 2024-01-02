using System.Windows.Forms;

namespace MyzOo.View
{
    partial class Event_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Event_Menu));
            this.Exit_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Birthday_Calendar = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.Duration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Hour = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.card1 = new MyzOo.card();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exit_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 57);
            this.panel1.TabIndex = 22;
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
            this.label1.Text = "Inspecionar Evento";
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
            this.Delete_Button.Location = new System.Drawing.Point(486, 366);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(94, 39);
            this.Delete_Button.TabIndex = 38;
            this.Delete_Button.Text = "Apagar";
            this.Delete_Button.UseVisualStyleBackColor = false;
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
            this.Update_Button.Location = new System.Drawing.Point(12, 366);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(124, 39);
            this.Update_Button.TabIndex = 37;
            this.Update_Button.Text = "Atualizar";
            this.Update_Button.UseVisualStyleBackColor = false;
            // 
            // Birthday_Calendar
            // 
            this.Birthday_Calendar.Location = new System.Drawing.Point(367, 103);
            this.Birthday_Calendar.Name = "Birthday_Calendar";
            this.Birthday_Calendar.Size = new System.Drawing.Size(200, 20);
            this.Birthday_Calendar.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(364, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "Data do Evento :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "Descrição do Evento :";
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.LightGray;
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description.Enabled = false;
            this.Description.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Description.ForeColor = System.Drawing.Color.Black;
            this.Description.Location = new System.Drawing.Point(13, 97);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(287, 92);
            this.Description.TabIndex = 44;
            // 
            // Duration
            // 
            this.Duration.BackColor = System.Drawing.Color.LightGray;
            this.Duration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Duration.Enabled = false;
            this.Duration.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Duration.ForeColor = System.Drawing.Color.Black;
            this.Duration.Location = new System.Drawing.Point(13, 275);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(227, 14);
            this.Duration.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(10, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Duração Prevista para o Evento :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(364, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 47;
            this.label6.Text = "Hora do Evento :";
            // 
            // Hour
            // 
            this.Hour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Hour.Location = new System.Drawing.Point(367, 158);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(200, 20);
            this.Hour.TabIndex = 48;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(15, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 14);
            this.textBox1.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Limite de Pessoas para o Evento :";
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.SteelBlue;
            this.card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.card1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.card1.Id = "";
            this.card1.Location = new System.Drawing.Point(362, 200);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(218, 40);
            this.card1.TabIndex = 51;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(362, 200);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 143);
            this.flowLayoutPanel1.TabIndex = 52;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(15, 329);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 14);
            this.textBox2.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(12, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 53;
            this.label7.Text = "Localização :";
            // 
            // Event_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 417);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Birthday_Calendar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Event_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event_Menu";
            this.Load += new System.EventHandler(this.Event_Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.DateTimePicker Birthday_Calendar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Hour;
        private TextBox textBox1;
        private Label label2;
        private card card1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox2;
        private Label label7;
    }
}