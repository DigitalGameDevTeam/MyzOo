namespace MyzOo.View
{
    partial class AnimalList_Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Animal_ListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 70);
            this.panel1.TabIndex = 1;
            // 
            // Minimize_button
            // 
            this.Minimize_button.BackColor = System.Drawing.Color.Transparent;
            this.Minimize_button.FlatAppearance.BorderSize = 0;
            this.Minimize_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.Minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize_button.ForeColor = System.Drawing.SystemColors.Window;
            this.Minimize_button.Location = new System.Drawing.Point(917, 0);
            this.Minimize_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Minimize_button.Name = "Minimize_button";
            this.Minimize_button.Size = new System.Drawing.Size(75, 70);
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
            this.Exit_button.Location = new System.Drawing.Point(992, 0);
            this.Exit_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(75, 70);
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
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "Animalius";
            // 
            // Animal_ListBox
            // 
            this.Animal_ListBox.FormattingEnabled = true;
            this.Animal_ListBox.ItemHeight = 16;
            this.Animal_ListBox.Location = new System.Drawing.Point(16, 105);
            this.Animal_ListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Animal_ListBox.Name = "Animal_ListBox";
            this.Animal_ListBox.Size = new System.Drawing.Size(303, 356);
            this.Animal_ListBox.TabIndex = 2;
            this.Animal_ListBox.SelectedIndexChanged += new System.EventHandler(this.Animal_ListBox_SelectedIndexChanged);
            // 
            // AnimalList_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Animal_ListBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AnimalList_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnimalList_Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Minimize_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Animal_ListBox;
    }
}