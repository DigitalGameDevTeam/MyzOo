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
            this.SuspendLayout();
            // 
            // Card_Name
            // 
            this.Card_Name.AutoSize = true;
            this.Card_Name.Location = new System.Drawing.Point(16, 34);
            this.Card_Name.Name = "Card_Name";
            this.Card_Name.Size = new System.Drawing.Size(84, 13);
            this.Card_Name.TabIndex = 2;
            this.Card_Name.Text = "Noma do Animal";
            // 
            // card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Card_Name);
            this.Name = "card";
            this.Size = new System.Drawing.Size(762, 81);
            this.MouseEnter += new System.EventHandler(this.card_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.card_MouseLeave);
            this.MouseHover += new System.EventHandler(this.card_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Card_Name;
    }
}
