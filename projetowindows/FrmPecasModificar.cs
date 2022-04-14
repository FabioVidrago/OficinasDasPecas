using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWindows
{
    public partial class FrmPecasModificar : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand commad = new SqlCommand();
        ConexaoDB DataBase = new ConexaoDB();
        SqlDataReader reader;
        FrmPecas _peca;

        public FrmPecasModificar(FrmPecas peca)
        {
            InitializeComponent();
            con = new SqlConnection(DataBase.ConexaoString());

            _peca = peca;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {

        }
    }
}
