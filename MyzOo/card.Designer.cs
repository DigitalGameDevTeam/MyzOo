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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Card_Id = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Card_Name
            // 
            this.Card_Name.AutoSize = true;
            this.Card_Name.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card_Name.Location = new System.Drawing.Point(409, 24);
            this.Card_Name.Name = "Card_Name";
            this.Card_Name.Size = new System.Drawing.Size(78, 32);
            this.Card_Name.TabIndex = 2;
            this.Card_Name.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.Card_Id);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 81);
            this.panel1.TabIndex = 3;
            // 
            // Card_Id
            // 
            this.Card_Id.AutoSize = true;
            this.Card_Id.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card_Id.Location = new System.Drawing.Point(49, 24);
            this.Card_Id.Name = "Card_Id";
            this.Card_Id.Size = new System.Drawing.Size(34, 32);
            this.Card_Id.TabIndex = 4;
            this.Card_Id.Text = "Id";
            this.Card_Id.Click += new System.EventHandler(this.Card_Id_Click);
            // 
            // card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Card_Name);
            this.Name = "card";
            this.Size = new System.Drawing.Size(762, 81);
            this.MouseEnter += new System.EventHandler(this.card_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.card_MouseLeave);
            this.MouseHover += new System.EventHandler(this.card_MouseHover);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Card_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Card_Id;
    }
}
