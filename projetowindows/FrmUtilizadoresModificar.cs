using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ProjetoWindows
{
    public partial class FrmUtilizadoresModificar : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand commad = new SqlCommand();
        ConexaoDB DataBase = new ConexaoDB();
        SqlDataReader reader;
        FrmUtilizadores _utilizador;


        public FrmUtilizadoresModificar(FrmUtilizadores utilizador)
        {
            InitializeComponent();
            con = new SqlConnection(DataBase.ConexaoString());

            _utilizador = utilizador;

           //LoadPerfil();
           //LoadGenero();
           //LoadAtivo();
        }


        private void Limpar_Click(object sender, EventArgs e)
        {
            LimpaBotoes();
            btn_update.Enabled = false;
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (CamposObrigatorios())
                {

                    if (MessageBox.Show("Tem a certeza que pretende modificar", "Comfirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        //commad = new SqlCommand("UPDATE tab_utilizador SET utilizador=@utilizador, pw=@pw,ativo=@ativo, nome=@nome, apelido=@apelido, email=@email, nif=@nif, morada=@morada, telemovel=@telemovel, genero=@genero FROM tab_utilizador  WHERE id_utilizador=@id_utilizador", con);
                        //commad = new SqlCommand("update tab_utilizador set(tab_utilizador.id_utilizador=@id_utilizador,tab_utilizador.utilizador=@utilizador, tab_utilizador.pw=@pw, tab_perfil.perfil=@perfil, tab_utilizador.ativo=@ativo, tab_utilizador.nome=@nome, tab_utilizador.apelido=@apelido, tab_utilizador.email=@email, tab_utilizador.nif=@nif, tab_utilizador.morada=@morada, tab_utilizador.telemovel=@telemovel, tab_utilizador.genero=@genero) FROM tab_perfil INNER JOIN tab_utilizador ON tab_perfil.id_perfil = tab_utilizador.id_perfil", con);

                        commad = new SqlCommand("UPDATE tab_utilizador SET utilizador=@utilizador, pw=@pw, nome=@nome, apelido=@apelido, email=@email, nif=@nif, morada=@morada, telemovel=@telemovel FROM tab_utilizador  WHERE id_utilizador=@id_utilizador", con);
                        commad.Parameters.AddWithValue("@id_utilizador", txt_id.Text);
                        commad.Parameters.AddWithValue("@utilizador", txt_utilizador.Text);
                        commad.Parameters.AddWithValue("@pw", EncryptString(txt_pw.Text));
                        //commad.Parameters.AddWithValue("@perfil", drop_perfil.Text);
                        
                        commad.Parameters.AddWithValue("@ativo", drop_ativo.SelectedValue);
                        commad.Parameters.AddWithValue("@nome", txt_nome.Text);
                        commad.Parameters.AddWithValue("@apelido", txt_apelido.Text);
                        commad.Parameters.AddWithValue("@email", txt_email.Text);
                        commad.Parameters.AddWithValue("@nif", txt_nif.Text);
                        commad.Parameters.AddWithValue("@morada", txt_morada.Text);
                        commad.Parameters.AddWithValue("@telemovel", txt_telefone.Text);
                       // commad.Parameters.AddWithValue("@genero", drop_sexo.Text);

                        con.Open();
                        commad.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Utilizador gravado com sucesso!", "Gravar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpaBotoes();
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void controloBotoes1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool CamposObrigatorios()
        {
            bool output = true;

            if (string.IsNullOrEmpty(txt_utilizador.Text))
            {
                MessageBox.Show("Insira o utilizador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Insira o apelido do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_pw.Text))
            {
                MessageBox.Show("Insira a palavra-passe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            return output;
        }



        public void LimpaBotoes()
        {
            txt_utilizador.Clear();
            txt_pw.Clear();
            //drop_perfil
            //drop_ativo
            txt_nome.Clear();
            txt_apelido.Clear();
            txt_email.Clear();
            txt_nif.Clear();
            txt_morada.Clear();
            txt_telefone.Clear();
            //drop_sexo.SelectedValue
            txt_confirmePw.Clear();
            txt_utilizador.Focus();
        }

        public void LoadAtivo()
        {
            drop_sexo.Items.Clear();
            commad = new SqlCommand("SELECT DISTINCT  ativo FROM tab_utilizador", con);
            con.Open();
            reader = commad.ExecuteReader();
            while (reader.Read())
            {
                drop_sexo.Items.Add(reader["ativo"].ToString());
            }
            reader.Close();
            con.Close();
        }

        public void LoadGenero()
        {
           
            commad = new SqlCommand("SELECT genero FROM tab_utilizador", con);
            con.Open();
            reader = commad.ExecuteReader();
            while (reader.Read())
            {
                drop_sexo.Items.Add(reader["genero"].ToString());
            }
            reader.Close();
            con.Close();
        }

        public void LoadPerfil()
        {
           
            commad = new SqlCommand("SELECT perfil FROM tab_perfil", con);
            con.Open();
            reader = commad.ExecuteReader();
            while (reader.Read())
            {
                drop_perfil.Items.Add(reader["perfil"].ToString());
            }
            reader.Close();
            con.Close();
        }


        /// <summary>
        /// Metodo para encriptar uma string, neste contexto uso apenas na palavra passe
        /// </summary>
        /// <param name="Message"> parametro de entrada do metodo </param>
        /// <returns></returns>
        public static string EncryptString(string Message)
        {
            string Passphrase = "cinelCET60";
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            // Step 1. We hash the passphrase using MD5
            // We use the MD5 hash generator as the result is a 128 bit byte array
            // which is a valid length for the TripleDES encoder we use below

            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));

            // Step 2. Create a new TripleDESCryptoServiceProvider object
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

            // Step 3. Setup the encoder
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            // Step 4. Convert the input string to a byte[]
            byte[] DataToEncrypt = UTF8.GetBytes(Message);

            // Step 5. Attempt to encrypt the string
            try
            {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                // Clear the TripleDes and Hashprovider services of any sensitive information
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            // Step 6. Return the encrypted string as a base64 encoded string

            string enc = Convert.ToBase64String(Results);
            enc = enc.Replace("+", "KkKkK");
            enc = enc.Replace("/", "JjJjJ");
            enc = enc.Replace("\\", "IiIiI");
            return enc;
        }

        private void FrmUtilizadoresModificar_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'ofinaDasPecasDataSet3.tab_perfil' table. You can move, or remove it, as needed.
            this.tab_perfilTableAdapter.Fill(this.ofinaDasPecasDataSet3.tab_perfil);
           

        }
    }
}
