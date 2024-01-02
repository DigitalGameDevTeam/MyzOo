using System.Windows.Forms;

namespace MyzOo.View
{
    partial class Event_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Event_Register));
            this.Event_Date = new System.Windows.Forms.DateTimePicker();
            this.Regist_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Event_Time = new System.Windows.Forms.DateTimePicker();
            this.NumAttendees = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Location = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.card1 = new MyzOo.card();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Event_Date
            // 
            this.Event_Date.Location = new System.Drawing.Point(344, 87);
            this.Event_Date.Name = "Event_Date";
            this.Event_Date.Size = new System.Drawing.Size(200, 20);
            this.Event_Date.TabIndex = 38;
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
            this.Regist_button.Location = new System.Drawing.Point(12, 360);
            this.Regist_button.Name = "Regist_button";
            this.Regist_button.Size = new System.Drawing.Size(107, 33);
            this.Regist_button.TabIndex = 31;
            this.Regist_button.Text = "Registrar";
            this.Regist_button.UseVisualStyleBackColor = false;
            this.Regist_button.Click += new System.EventHandler(this.Regist_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(341, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Data do Evento :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adicionar Evento";
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
            this.panel1.TabIndex = 26;
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
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.LightGray;
            this.Description.Location = new System.Drawing.Point(12, 90);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(285, 83);
            this.Description.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(9, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Descrição do Evento :";
            // 
            // Duration
            // 
            this.Duration.BackColor = System.Drawing.Color.LightGray;
            this.Duration.Location = new System.Drawing.Point(12, 252);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(224, 20);
            this.Duration.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(9, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "Duração Prevista para o Evento :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(341, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 46;
            this.label7.Text = "Hora do Evento :";
            // 
            // Event_Time
            // 
            this.Event_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Event_Time.Location = new System.Drawing.Point(344, 149);
            this.Event_Time.Name = "Event_Time";
            this.Event_Time.Size = new System.Drawing.Size(200, 20);
            this.Event_Time.TabIndex = 4;
            // 
            // NumAttendees
            // 
            this.NumAttendees.BackColor = System.Drawing.Color.LightGray;
            this.NumAttendees.Location = new System.Drawing.Point(12, 201);
            this.NumAttendees.Name = "NumAttendees";
            this.NumAttendees.Size = new System.Drawing.Size(224, 20);
            this.NumAttendees.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(9, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "Limite de Pessoas para o Evento :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(333, 191);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 172);
            this.flowLayoutPanel1.TabIndex = 50;
            // 
            // Location
            // 
            this.Location.BackColor = System.Drawing.Color.LightGray;
            this.Location.Location = new System.Drawing.Point(12, 302);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(224, 20);
            this.Location.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(9, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 51;
            this.label6.Text = "Localização :";
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.SteelBlue;
            this.card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.card1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.card1.Id = "";
            this.card1.Location = new System.Drawing.Point(333, 191);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(250, 58);
            this.card1.TabIndex = 49;
            // 
            // Event_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 405);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.NumAttendees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Event_Time);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Event_Date);
            this.Controls.Add(this.Regist_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Event_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event_Register";
            this.Load += new System.EventHandler(this.Event_Register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Event_Date;
        private System.Windows.Forms.Button Regist_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Event_Time;
        private TextBox NumAttendees;
        private Label label2;
        private card card1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox Location;
        private Label label6;
    }
}