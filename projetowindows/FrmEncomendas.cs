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
    public partial class FrmEncomendas : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=OfinaDasPecas.mssql.somee.com;Initial Catalog=OfinaDasPecas;Persist Security Info=True;User ID=MFadmin;Password=MFadmin2");
        SqlCommand commad = new SqlCommand();
        SqlDataReader reader;
        public FrmEncomendas()
        {
            InitializeComponent();
            //MostrarEncomendas();
        }

        public void MostrarEncomendas()
        {

            GridViewEncomendas.Rows.Clear();

            commad = new SqlCommand("SELECT tab_encomenda.id_encomenda, tab_utilizador.utilizador, tab_encomenda.data_encomenda, tab_estado.estado  FROM tab_encomenda INNER JOIN tab_encomenda_detalhe ON tab_encomenda.id_encomenda = tab_encomenda_detalhe.id_encomenda INNER JOIN tab_estado ON tab_encomenda.id_estado = tab_estado.id_estado_reparacao INNER JOIN tab_utilizador ON tab_encomenda.id_cliente = tab_utilizador.id_utilizador WHERE CONCAT(id_encomenda, utilizador, data_encomenda) LIKE '%" + txt_procurar.Text + "%'", con);

            con.Open();
            reader = commad.ExecuteReader();

            while (reader.Read())
            {
                GridViewEncomendas.Rows.Add(reader["id__encomenda"].ToString(), reader["utilizador"].ToString(), DateTime.Parse(reader["data_encomenda"].ToString()).ToShortDateString(), reader["estado"].ToString());

            }
            reader.Close();
            con.Close();
        }

        private void txt_procurar_TextChanged(object sender, EventArgs e)
        {
            MostrarEncomendas();
        }
    }
}
