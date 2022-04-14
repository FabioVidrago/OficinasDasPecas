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
    public partial class FrmPecas : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=OfinaDasPecas.mssql.somee.com;Initial Catalog=OfinaDasPecas;Persist Security Info=True;User ID=MFadmin;Password=MFadmin2");
        SqlCommand commad = new SqlCommand();
        SqlDataReader reader;
        public FrmPecas()
        {
            InitializeComponent();
            MostrarPecas();
        }

        private void btn_mais_Click(object sender, EventArgs e)
        {
            FrmPecasModificar adicionar = new FrmPecasModificar(this);
            adicionar.label_info.Text = "Adicionar Peças";
            adicionar.btn_adicionar.Text = "Adicionar";
            adicionar.btn_adicionar.BackColor = Color.Green;
            adicionar.txt_data.Text = DateTime.Now.ToString("dd-MM-yyyy");
            adicionar.ShowDialog();
        }

        private void txt_procurar_TextChanged(object sender, EventArgs e)
        {
            MostrarPecas();
        }

 
        public void MostrarPecas()
        {

            GridViewPecas.Rows.Clear();


            commad = new SqlCommand("SELECT tab_peca.id_peca,tab_peca.nome, tab_peca.ref, tab_peca.valor, tab_peca_tipo.tipo_peca, tab_peca_marca.marca_peca, tab_peca.data_fabrico, tab_peca.quantidade FROM tab_peca INNER JOIN tab_peca_marca ON tab_peca.id_marca_peca = tab_peca_marca.id_marca_peca INNER JOIN tab_peca_tipo ON tab_peca.id_tipo = tab_peca_tipo.id_tipo AND tab_peca_marca.id_tipo = tab_peca_tipo.id_tipo WHERE CONCAT(id_peca, nome, ref, valor, tipo_peca, marca_peca, data_fabrico, quantidade) LIKE '%" + txt_procurar.Text + "%'", con);

            con.Open();
            reader = commad.ExecuteReader();
            while (reader.Read())
            {
                GridViewPecas.Rows.Add(reader["id_peca"].ToString(),  reader["nome"].ToString(), reader["ref"].ToString(), reader["valor"].ToString(), reader["tipo_peca"].ToString(), reader["marca_peca"].ToString(), DateTime.Parse(reader["data_fabrico"].ToString()).ToShortDateString(), reader["quantidade"].ToString());

            }
            reader.Close();
            con.Close();


        }

        private void GridViewPecas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmPecasModificar editarPeca = new FrmPecasModificar(this);
            string colName = GridViewPecas.Columns[e.ColumnIndex].Name;
            if (colName == "Editar")
            {
                editarPeca.label_info.Text = "Modificar Peças";
                editarPeca.btn_adicionar.Text = "Update";
                editarPeca.btn_adicionar.BackColor = Color.Aqua;
                //editarPeca.btn_adicionar.BackColor = Color.Highlight;
                editarPeca.txt_id.Text = GridViewPecas.Rows[e.RowIndex].Cells[0].Value.ToString();
                editarPeca.txt_nome.Text = GridViewPecas.Rows[e.RowIndex].Cells[1].Value.ToString();
                editarPeca.txt_ref.Text = GridViewPecas.Rows[e.RowIndex].Cells[2].Value.ToString();
                editarPeca.txt_valor.Text = GridViewPecas.Rows[e.RowIndex].Cells[3].Value.ToString();
                editarPeca.drop_tipo.Text = GridViewPecas.Rows[e.RowIndex].Cells[4].Value.ToString();

                editarPeca.drop_marca.Text = GridViewPecas.Rows[e.RowIndex].Cells[5].Value.ToString();


                editarPeca.txt_data.Text = GridViewPecas.Rows[e.RowIndex].Cells[6].Value.ToString();
                editarPeca.txt_quantidade.Text = GridViewPecas.Rows[e.RowIndex].Cells[7].Value.ToString();


                editarPeca.ShowDialog();

            }
            else if (colName == "Apagar")
            {
                if (MessageBox.Show($"Tem a certeza que pretende apagar {editarPeca.txt_nome.Text}?", "Apagar peça", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();


                    commad = new SqlCommand("delete FROM tab_peca WHERE id_peca='" + GridViewPecas.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    commad.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("apagado com sucesso!");

                }
            }

            MostrarPecas();
        }
    }
}
