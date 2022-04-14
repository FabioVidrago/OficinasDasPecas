using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoWindows
{
    class ConexaoDB
    {

        SqlConnection con = new SqlConnection();
        SqlCommand command = new SqlCommand();
        private string myConexao;


        public string ConexaoString()
        {

            myConexao = @"Data Source=OfinaDasPecas.mssql.somee.com;Initial Catalog=OfinaDasPecas;Persist Security Info=True;User ID=MFadmin;Password=MFadmin2";
            return myConexao;
        }

        public void executeQuery(string sql)
        {
            try
            {
                con.ConnectionString = ConexaoString();
                con.Open();
                command = new SqlCommand(sql, con);
                command.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }

        }
    }
}
