using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyzOo.View
{
    public partial class Display : UserControl
    {
        
        public Display()
        {
            InitializeComponent();
        }

        #region Properties

        private string _animal;
        private Image _icon;

        [Category("Custom Props")]
        public string Animal
        {
            get { return _animal; }
            set { _animal = value; Nome_do_Animal.Text = value; }
        }

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; Imagem_do_Animal.Image = value; }
        }


        #endregion

        private void Display_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            Editar_Button.BackColor = Color.Gainsboro;
            Apagar_Button.BackColor = Color.Gainsboro;
          
        }
    }
}
