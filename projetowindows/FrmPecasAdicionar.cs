using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWindows
{
    public partial class FrmPecasAdicionar : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand commad = new SqlCommand();
        ConexaoDB DataBase = new ConexaoDB();
        FrmPecas _peca;

        public FrmPecasAdicionar(FrmPecas peca)
        {
            InitializeComponent();
            con = new SqlConnection(DataBase.ConexaoString());
            _peca = peca;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {

                
                if (ValidaCampos())
                {

                    if (MessageBox.Show("Tem a certeza que pretende gravar", "Comfirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Stream imgStream = FileUpload1.PostedFile.InputStream;

                       // int tamanho_array = FileUpload1.PostedFile.ContentLength;

                        //byte[] imgBinaryData = new byte[tamanho_array];

                        //imgStream.Read(imgBinaryData, 0, tamanho_array);

                        commad.Parameters.AddWithValue("@nome", txt_nome.Text);
                        commad.Parameters.AddWithValue("@ref", txt_ref.Text);
                        commad.Parameters.AddWithValue("@valor", Convert.ToDecimal(txt_valor.Text));
                        //commad.Parameters.AddWithValue("@data_fabrico", txt_data.Text);
                        //commad.Parameters.AddWithValue("@descricao", txt_descricao.Text);
                        //commad.Parameters.AddWithValue("@binarios", imgBinaryData);
                        commad.Parameters.AddWithValue("@tipo", drop_tipo.SelectedValue);
                        commad.Parameters.AddWithValue("@marca", drop_marca.SelectedValue);
                        //commad.Parameters.AddWithValue("@quantidade", txt_quantidade.Text);


                        SqlParameter retorno = new SqlParameter();
                        retorno.ParameterName = "@retorno";
                        retorno.Direction = ParameterDirection.Output;
                        retorno.SqlDbType = SqlDbType.Int;
                        commad.Parameters.Add(retorno);

                        commad.CommandType = CommandType.StoredProcedure;
                        commad.CommandText = "inserir_peca";

                        commad.Connection = con;
                        con.Open();
                        commad.ExecuteNonQuery();
                        int respostaRetorno1 = Convert.ToInt32(commad.Parameters["@retorno"].Value);
                        con.Close();


                        if (respostaRetorno1 == 1)
                        {
                            MessageBox.Show("Peça inserida com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Algo deu errado!");
                        }



                    }
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }



            


   
        }

        private bool ValidaCampos()
        {
            bool output = true;

            if (string.IsNullOrEmpty(txt_nome.Text))
            {
                MessageBox.Show("Insira o nome da peça", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_ref.Text))
            {
                MessageBox.Show("Insira a referência", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            return output;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
