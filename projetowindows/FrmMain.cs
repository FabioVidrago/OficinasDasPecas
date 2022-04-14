using System;
using System.Windows.Forms;

namespace ProjetoWindows
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private Form _formAtivo = null;
        private void Abrirform(Form abrirForm)
        {
            if (_formAtivo != null)
            {
                _formAtivo.Close();
            }
            _formAtivo = abrirForm;
            abrirForm.TopLevel = false;
            abrirForm.FormBorderStyle = FormBorderStyle.None;
            abrirForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(abrirForm);
            panelMain.Tag = abrirForm;
            abrirForm.BringToFront();
            abrirForm.Show();

        }



        private void btn_fechar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem a certeza que pretende sair da aplicação", "Comfirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btn_utilizadores_Click(object sender, EventArgs e)
        {
            Abrirform(new FrmUtilizadores());
        }

        private void btn_pecas_Click(object sender, EventArgs e)
        {
            Abrirform(new FrmPecas());
        }

        private void btn_encomendas_Click(object sender, EventArgs e)
        {
            Abrirform(new FrmEncomendas());
        }

        private void btn_servicos_Click(object sender, EventArgs e)
        {
            //Abrirform(new FrmServicos());
        }
    }
}
