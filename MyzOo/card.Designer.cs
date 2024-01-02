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
            this.Card_Name.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F);
            this.Card_Name.ForeColor = System.Drawing.Color.White;
            this.Card_Name.Location = new System.Drawing.Point(0, 22);
            this.Card_Name.Name = "Card_Name";
            this.Card_Name.Size = new System.Drawing.Size(761, 32);
            this.Card_Name.TabIndex = 2;
            this.Card_Name.Text = "Name";
            this.Card_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Card_Name.Click += new System.EventHandler(this.Card_Name_Click);
            this.Card_Name.Enter += new System.EventHandler(this.Card_Name_Enter);
            this.Card_Name.MouseEnter += new System.EventHandler(this.Card_Name_MouseEnter);
            this.Card_Name.MouseLeave += new System.EventHandler(this.Card_Name_MouseLeave);
            // 
            // card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Card_Name);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "card";
            this.Size = new System.Drawing.Size(760, 79);
            this.Load += new System.EventHandler(this.card_Load);
            this.MouseEnter += new System.EventHandler(this.card_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.card_MouseLeave);
            this.MouseHover += new System.EventHandler(this.card_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Card_Name;
    }
}
