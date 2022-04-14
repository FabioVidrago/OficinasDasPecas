using System;
using System.Windows.Forms;

namespace ProjetoWindows
{
    public partial class FrmEntrada : Form
    {
        int ComecaTempo = 0;
        public FrmEntrada()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ComecaTempo += 2;
            progressBar1.Value = ComecaTempo;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                FrmLogin login = new FrmLogin();
                this.Hide();
                login.ShowDialog();

                /*
                FrmPecas login = new FrmPecas();
                this.Hide();
                login.ShowDialog();*/
            }

        }
    }
}
