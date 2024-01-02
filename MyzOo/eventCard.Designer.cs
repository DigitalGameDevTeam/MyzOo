namespace MyzOo
{
    partial class eventCard
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
            this.Card_Name = new System.Windows.Forms.Label();
            this.CardName = new System.Windows.Forms.Label();
            this.Card_Description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Card_Name
            // 
            this.Card_Name.AutoSize = true;
            this.Card_Name.BackColor = System.Drawing.Color.Transparent;
            this.Card_Name.Location = new System.Drawing.Point(104, 25);
            this.Card_Name.Name = "Card_Name";
            this.Card_Name.Size = new System.Drawing.Size(28, 13);
            this.Card_Name.TabIndex = 51;
            this.Card_Name.Text = "Text";
            // 
            // CardName
            // 
            this.CardName.AutoSize = true;
            this.CardName.BackColor = System.Drawing.Color.Transparent;
            this.CardName.Location = new System.Drawing.Point(104, 25);
            this.CardName.Name = "CardName";
            this.CardName.Size = new System.Drawing.Size(28, 13);
            this.CardName.TabIndex = 51;
            this.CardName.Text = "Text";
            // 
            // Card_Description
            // 
            this.Card_Description.AutoSize = true;
            this.Card_Description.Location = new System.Drawing.Point(114, 19);
            this.Card_Description.Name = "Card_Description";
            this.Card_Description.Size = new System.Drawing.Size(35, 13);
            this.Card_Description.TabIndex = 0;
            this.Card_Description.Text = "label1";
            this.Card_Description.Click += new System.EventHandler(this.Card_Description_Click);
            this.Card_Description.MouseEnter += new System.EventHandler(this.Card_Description_MouseEnter);
            this.Card_Description.MouseLeave += new System.EventHandler(this.Card_Description_MouseLeave);
            // 
            // eventCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.Card_Description);
            this.Name = "eventCard";
            this.Size = new System.Drawing.Size(250, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private card card1;
        private System.Windows.Forms.Label Card_Name;
        private System.Windows.Forms.Label CardName;
        private System.Windows.Forms.Label Card_Description;
    }
}
