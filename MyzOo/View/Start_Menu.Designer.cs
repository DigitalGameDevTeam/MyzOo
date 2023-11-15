namespace MyzOo
{
    partial class Start_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Close_button = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.Seila_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "My zOo";
            // 
            // Close_button
            // 
            this.Close_button.FlatAppearance.BorderSize = 0;
            this.Close_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Close_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_button.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Close_button.Location = new System.Drawing.Point(92, 246);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(156, 59);
            this.Close_button.TabIndex = 3;
            this.Close_button.Text = "Sair";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Login_button
            // 
            this.Login_button.FlatAppearance.BorderSize = 0;
            this.Login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Login_button.Location = new System.Drawing.Point(92, 116);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(156, 59);
            this.Login_button.TabIndex = 4;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Seila_button
            // 
            this.Seila_button.FlatAppearance.BorderSize = 0;
            this.Seila_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Seila_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Seila_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seila_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seila_button.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Seila_button.Location = new System.Drawing.Point(92, 181);
            this.Seila_button.Name = "Seila_button";
            this.Seila_button.Size = new System.Drawing.Size(156, 59);
            this.Seila_button.TabIndex = 5;
            this.Seila_button.Text = "Sei lá";
            this.Seila_button.UseVisualStyleBackColor = true;
            this.Seila_button.Click += new System.EventHandler(this.Seila_button_Click);
            // 
            // Start_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(343, 358);
            this.Controls.Add(this.Seila_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Start_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My zOo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button Seila_button;
    }
}

