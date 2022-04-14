using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoWindows
{
    public partial class ControloBotoes : PictureBox
    {
        public ControloBotoes()
        {
            InitializeComponent();
        }


        private Image _imagemNormal;
        private Image _imagemDiferente;

        public Image ImagemNormal
        {
            get
            {
                return _imagemNormal;
            }
            set
            {
                _imagemNormal = value;
            }
        }
        public Image Imagemdiferente
        {
            get
            {
                return _imagemDiferente;
            }
            set
            {
                _imagemDiferente = value;
            }
        }

        private void ControloBotoes_MouseHover(object sender, EventArgs e)
        {
            this.Image = Imagemdiferente;
        }

        private void ControloBotoes_MouseLeave(object sender, EventArgs e)
        {
            this.Image = ImagemNormal;
        }
    }
}
