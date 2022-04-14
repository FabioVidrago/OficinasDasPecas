using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoWindows
{
    public partial class FrmUtilizadores : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=OfinaDasPecas.mssql.somee.com;Initial Catalog=OfinaDasPecas;Persist Security Info=True;User ID=MFadmin;Password=MFadmin2");
        SqlCommand commad = new SqlCommand();
        SqlDataReader reader;
        public FrmUtilizadores()
        {
            InitializeComponent();
            MostrarUtilizadores();
        }


        public void MostrarUtilizadores()
        {

            GridViewUtilizadores.Rows.Clear();

            //commad = new SqlCommand("SELECT tab_utilizador.id_utilizador, tab_utilizador.utilizador, tab_utilizador.pw, tab_perfil.perfil, tab_utilizador.ativo, tab_utilizador.nome, tab_utilizador.apelido, tab_utilizador.email, tab_utilizador.nif, tab_utilizador.morada,  tab_utilizador.telemovel, tab_utilizador.binarios, tab_utilizador.genero FROM tab_perfil INNER JOIN tab_utilizador ON tab_perfil.id_perfil = tab_utilizador.id_perfil WHERE CONCAT(id_utilizador,utilizador,perfil,nome,apelido,telemovel,morada,nif,genero,email) LIKE '%" + txt_procurar.Text + "%'", con);

            commad = new SqlCommand("SELECT tab_utilizador.id_utilizador, tab_utilizador.utilizador, tab_utilizador.pw, tab_perfil.perfil, tab_utilizador.ativo, tab_utilizador.nome, tab_utilizador.apelido, tab_utilizador.email, tab_utilizador.nif, tab_utilizador.morada,  tab_utilizador.telemovel, tab_utilizador.genero FROM tab_perfil INNER JOIN tab_utilizador ON tab_perfil.id_perfil = tab_utilizador.id_perfil WHERE CONCAT(id_utilizador, utilizador, utilizador, perfil, nome, apelido, telemovel, morada, nif, genero, email) LIKE '%" + txt_procurar.Text + "%'", con);

            con.Open();
            reader = commad.ExecuteReader();
            while (reader.Read())
            {
                GridViewUtilizadores.Rows.Add(reader["id_utilizador"].ToString(), reader["utilizador"].ToString(), reader["pw"].ToString(), reader["perfil"].ToString(), reader["ativo"].ToString(), reader["nome"].ToString(), reader["apelido"].ToString(), reader["email"].ToString(), reader["nif"].ToString(), reader["morada"].ToString(), reader["telemovel"].ToString(), reader["genero"].ToString());

            }
            reader.Close();
            con.Close();
        }

        private void txt_procurar_TextChanged(object sender, EventArgs e)
        {
            MostrarUtilizadores();
        }

        private void btn_mais_Click(object sender, EventArgs e)
        {
            FrmUtilizadoresAdicionar adicionar = new FrmUtilizadoresAdicionar(this);
            adicionar.ShowDialog();
        }

        private void GridViewUtilizadores_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            FrmUtilizadoresModificar editarUtilizador = new FrmUtilizadoresModificar(this);
            string colName = GridViewUtilizadores.Columns[e.ColumnIndex].Name;
            if (colName == "Editar")
            {

                editarUtilizador.txt_id.Text = GridViewUtilizadores.Rows[e.RowIndex].Cells[0].Value.ToString();
                editarUtilizador.txt_utilizador.Text = GridViewUtilizadores.Rows[e.RowIndex].Cells[1].Value.ToString();
                editarUtilizador.txt_pw.Text = GridViewUtilizadores.Rows[e.RowIndex].Cells[2].Value.ToString();
                editarUtilizador.txt_confirmePw.Text = GridViewUtilizadores.Rows[e.RowIndex].Cells[2].Value.ToString();
                editarUtilizador.drop_perfil.SelectedItem = GridViewUtilizadores.Rows[e.RowIndex].Cells[3].Value.ToString();

                editarUtilizador.drop_ativo.Text = GridViewUtilizadores.Rows[e.RowIndex].Cells[4].Value.ToString();


                editarUtilizador.txt_nome.Text = GridViewUtilizadores.Rows[e.RowIndex].Cells[5].Value.ToString();
                editarUtilizador.txt_apelido.Text = GridViewUtilizadores.Rows[e.RowIndex].Cells[6].Value.ToString();
                editarUtilizador.txt_email.Text = GridViewUtilizadores.Rows[e.RowIndex].Cells[7].Value.ToString();
                editarUtilizador.txt_nif.Text = GridViewUtilizadores.Rows[e.RowIndex].Cells[8].Value.ToString();
                editarUtilizador.txt_morada.Text = GridViewUtilizadores.Rows[e.RowIndex].Cells[9].Value.ToString();
                editarUtilizador.txt_telefone.Text = GridViewUtilizadores.Rows[e.RowIndex].Cells[10].Value.ToString();

                editarUtilizador.drop_sexo.SelectedItem = GridViewUtilizadores.Rows[e.RowIndex].Cells[11].Value.ToString();

                editarUtilizador.btn_update.Enabled = true;
                editarUtilizador.txt_utilizador.Enabled = false;

                editarUtilizador.ShowDialog();

            }
            else if (colName == "Apagar")
            {
                if (MessageBox.Show($"Tem a certeza que pretende apagar {editarUtilizador.txt_utilizador.Text}?", "Apagar utilizador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();


                    commad = new SqlCommand("delete FROM tab_utilizador WHERE id_utilizador='" + GridViewUtilizadores.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    commad.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("apagado com sucesso!");

                }
            }

            MostrarUtilizadores();
        }
    }
}
