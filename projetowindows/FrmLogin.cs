using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWindows
{
    
    public partial class FrmLogin : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=OfinaDasPecas.mssql.somee.com;Initial Catalog=OfinaDasPecas;Persist Security Info=True;User ID=MFadmin;Password=MFadmin2");
        SqlCommand commad = new SqlCommand();
        SqlDataReader reader;
        
        public FrmLogin()
        {
            InitializeComponent();
           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {

                commad = new SqlCommand("SELECT tab_utilizador.*, tab_perfil.perfil FROM tab_perfil INNER JOIN tab_utilizador ON tab_perfil.id_perfil = tab_utilizador.id_perfil WHERE utilizador=@utilizador AND pw=@pw AND tab_utilizador.ativo = 1  AND (tab_perfil.perfil = 'admin' or tab_perfil.perfil = 'funcionario')", con);
                commad.Parameters.AddWithValue("@utilizador", txt_utilizador.Text);
                commad.Parameters.AddWithValue("@pw", EncryptString(txt_pw.Text));
                con.Open();
                reader = commad.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    MessageBox.Show("Bem vindo " + reader["utilizador"].ToString() + "  ", "Acesso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmMain main = new FrmMain();
                    main.lbl_utilizador.Text = reader["utilizador"].ToString();
                    this.Hide();
                    main.ShowDialog();

                }
                
                else
                {
                    MessageBox.Show("Utilizador ou palavra-passe incorretas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimparTexto();
                }

                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lbl_limpar_Click(object sender, EventArgs e)
        {
            LimparTexto();
        }

        /// <summary>
        /// Fechar a aplicação
        /// </summary>


        /// <summary>
        /// Metodo par limpar todas as caixas de texto 
        /// </summary>
        private void LimparTexto()
        {
            txt_utilizador.Clear();
            txt_pw.Clear();
            txt_utilizador.Focus();
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

        private void mostrar_pw_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrar_pw.Checked == false)
            {
                txt_pw.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pw.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem a certeza que pretende sair da aplicação","Comfirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
