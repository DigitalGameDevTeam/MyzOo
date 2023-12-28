namespace MyzOo
{
    partial class card
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Card_Name = new System.Windows.Forms.Label();
            this.Card_Edit_Button = new System.Windows.Forms.Button();
            this.Card_Delete_Button = new System.Windows.Forms.Button();
            this.Card_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Card_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Card_Name
            // 
            this.Card_Name.AutoSize = true;
            this.Card_Name.Location = new System.Drawing.Point(151, 34);
            this.Card_Name.Name = "Card_Name";
            this.Card_Name.Size = new System.Drawing.Size(84, 13);
            this.Card_Name.TabIndex = 2;
            this.Card_Name.Text = "Noma do Animal";
            // 
            // Card_Edit_Button
            // 
            this.Card_Edit_Button.BackColor = System.Drawing.Color.Aqua;
            this.Card_Edit_Button.Location = new System.Drawing.Point(518, 13);
            this.Card_Edit_Button.Name = "Card_Edit_Button";
            this.Card_Edit_Button.Size = new System.Drawing.Size(104, 54);
            this.Card_Edit_Button.TabIndex = 3;
            this.Card_Edit_Button.Text = "Editar";
            this.Card_Edit_Button.UseVisualStyleBackColor = false;
            this.Card_Edit_Button.Click += new System.EventHandler(this.Card_Edit_Button_Click);
            // 
            // Card_Delete_Button
            // 
            this.Card_Delete_Button.BackColor = System.Drawing.Color.Red;
            this.Card_Delete_Button.Location = new System.Drawing.Point(640, 13);
            this.Card_Delete_Button.Name = "Card_Delete_Button";
            this.Card_Delete_Button.Size = new System.Drawing.Size(104, 54);
            this.Card_Delete_Button.TabIndex = 4;
            this.Card_Delete_Button.Text = "Apagar";
            this.Card_Delete_Button.UseVisualStyleBackColor = false;
            this.Card_Delete_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Card_pictureBox
            // 
            this.Card_pictureBox.BackColor = System.Drawing.Color.SteelBlue;
            this.Card_pictureBox.Location = new System.Drawing.Point(3, 3);
            this.Card_pictureBox.Name = "Card_pictureBox";
            this.Card_pictureBox.Size = new System.Drawing.Size(133, 75);
            this.Card_pictureBox.TabIndex = 5;
            this.Card_pictureBox.TabStop = false;
            // 
            // card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Card_pictureBox);
            this.Controls.Add(this.Card_Delete_Button);
            this.Controls.Add(this.Card_Edit_Button);
            this.Controls.Add(this.Card_Name);
            this.Name = "card";
            this.Size = new System.Drawing.Size(762, 81);
            this.MouseEnter += new System.EventHandler(this.card_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.card_MouseLeave);
            this.MouseHover += new System.EventHandler(this.card_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.Card_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Card_Name;
        private System.Windows.Forms.Button Card_Edit_Button;
        private System.Windows.Forms.Button Card_Delete_Button;
        private System.Windows.Forms.PictureBox Card_pictureBox;
    }
}
