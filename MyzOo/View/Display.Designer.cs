namespace MyzOo.View
{
    partial class Display
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Imagem_do_Animal = new System.Windows.Forms.PictureBox();
            this.Nome_do_Animal = new System.Windows.Forms.Label();
            this.Editar_Button = new System.Windows.Forms.Button();
            this.Apagar_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem_do_Animal)).BeginInit();
            this.SuspendLayout();
            // 
            // Imagem_do_Animal
            // 
            this.Imagem_do_Animal.Location = new System.Drawing.Point(3, 3);
            this.Imagem_do_Animal.Name = "Imagem_do_Animal";
            this.Imagem_do_Animal.Size = new System.Drawing.Size(143, 86);
            this.Imagem_do_Animal.TabIndex = 0;
            this.Imagem_do_Animal.TabStop = false;
            // 
            // Nome_do_Animal
            // 
            this.Nome_do_Animal.AutoSize = true;
            this.Nome_do_Animal.Location = new System.Drawing.Point(186, 40);
            this.Nome_do_Animal.Name = "Nome_do_Animal";
            this.Nome_do_Animal.Size = new System.Drawing.Size(84, 13);
            this.Nome_do_Animal.TabIndex = 1;
            this.Nome_do_Animal.Text = "Nome do Animal";
            // 
            // Editar_Button
            // 
            this.Editar_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.Editar_Button.FlatAppearance.BorderSize = 0;
            this.Editar_Button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.Editar_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar_Button.ForeColor = System.Drawing.Color.Black;
            this.Editar_Button.Location = new System.Drawing.Point(364, 24);
            this.Editar_Button.Name = "Editar_Button";
            this.Editar_Button.Size = new System.Drawing.Size(94, 45);
            this.Editar_Button.TabIndex = 2;
            this.Editar_Button.Text = "Editar";
            this.Editar_Button.UseVisualStyleBackColor = false;
            // 
            // Apagar_Button
            // 
            this.Apagar_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.Apagar_Button.FlatAppearance.BorderSize = 0;
            this.Apagar_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Apagar_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apagar_Button.ForeColor = System.Drawing.Color.Black;
            this.Apagar_Button.Location = new System.Drawing.Point(464, 24);
            this.Apagar_Button.Name = "Apagar_Button";
            this.Apagar_Button.Size = new System.Drawing.Size(94, 45);
            this.Apagar_Button.TabIndex = 3;
            this.Apagar_Button.Text = "Apagar";
            this.Apagar_Button.UseVisualStyleBackColor = false;
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.Apagar_Button);
            this.Controls.Add(this.Editar_Button);
            this.Controls.Add(this.Nome_do_Animal);
            this.Controls.Add(this.Imagem_do_Animal);
            this.Name = "Display";
            this.Size = new System.Drawing.Size(599, 92);
            this.Load += new System.EventHandler(this.Display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imagem_do_Animal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Imagem_do_Animal;
        private System.Windows.Forms.Label Nome_do_Animal;
        private System.Windows.Forms.Button Editar_Button;
        private System.Windows.Forms.Button Apagar_Button;
    }
}
