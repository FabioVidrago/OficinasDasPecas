using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ProjetoWindows
{
    public partial class FrmUtilizadoresAdicionar : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand commad = new SqlCommand();
        ConexaoDB DataBase = new ConexaoDB();
        FrmUtilizadores _utilizador;


        public FrmUtilizadoresAdicionar(FrmUtilizadores utilizador)
        {
            InitializeComponent();
            con = new SqlConnection(DataBase.ConexaoString());

            _utilizador = utilizador;

        }

        private void bnt_gravar_Click(object sender, System.EventArgs e)
        {
            try
            {

                if (ValidaCampos())
                {

                    if (MessageBox.Show("Tem a certeza que pretende gravar", "Comfirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                        commad.Parameters.AddWithValue("@utilizador", txt_utilizador.Text);
                        commad.Parameters.AddWithValue("@email", txt_email.Text);
                        commad.Parameters.AddWithValue("@pw", EncryptString(txt_pw.Text));



                        SqlParameter retorno = new SqlParameter();
                        retorno.ParameterName = "@retorno";
                        retorno.Direction = ParameterDirection.Output;
                        retorno.SqlDbType = SqlDbType.Int;
                        commad.Parameters.Add(retorno);


                        commad.CommandType = CommandType.StoredProcedure;
                        commad.CommandText = "registar";

                        commad.Connection = con;
                        con.Open();
                        commad.ExecuteNonQuery();
                        int respostaRetorno = Convert.ToInt32(commad.Parameters["@retorno"].Value);
                        con.Close();

                        if (respostaRetorno == 1)
                        {
                            enviaMail();

                            LimpaBotoes();

                            _utilizador.MostrarUtilizadores();
                            this.Dispose();
                        }

                        else
                        {
                            MessageBox.Show("Utlizador ou email em uso.", "Tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void enviaMail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            mail.From = new MailAddress("dasmartinscinel@gmail.com");
            mail.To.Add(new MailAddress(txt_email.Text));
            mail.Subject = "Ativacao";
            mail.IsBodyHtml = true;

            mail.Body = "Para ativar a sua conta clique aqui <a href='https://localhost:44373/ativacao.aspx?utilizador=" + txt_utilizador.Text + "'> aqui </a>";

            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("dasmartinscinel@gmail.com", "Abc123abc.");

            smtp.EnableSsl = true;
            smtp.Send(mail);
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            LimpaBotoes();
            btn_registar.Enabled = true;
        }
       
        private void controloBotoes1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool ValidaCampos()
        {
            bool output = true;

            if (string.IsNullOrEmpty(txt_utilizador.Text))
            {
                MessageBox.Show("Insira o nome do utilizador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Insira o email", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            return output;
        }


        public void LimpaBotoes()
        {
            txt_utilizador.Clear();
            txt_pw.Clear();
            txt_confirmePw.Clear();
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
    }
}
