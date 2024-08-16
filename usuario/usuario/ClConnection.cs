using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace usuario
{
    internal class ClConnection
    {
        static private string servidor = "localhost";
        static private string DB = "Biblio_Sesi";
        static private string usuario = "root";
        static private string senhas = "";

        public MySqlConnection conn = null;
        static private string StrConexao = $"server={servidor};database={DB};user id={usuario};password={senhas}";

        public MySqlConnection getConexao()
        {
            conn = new MySqlConnection(StrConexao);
            return conn;
        }

        public int cadastrar(int codigo, string[] campos, object[] valores, string SQL, String PK_Table)
        {
            int registro = 0;
            try
            {
                conn = getConexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);

                for (int i = 0; i < valores.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }

                if (codigo > 0)
                {
                    cmd.Parameters.AddWithValue("@id", codigo);
                }

                registro = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return registro;
        }

        public DataTable obterdados(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                conn = getConexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;
        }
    }
}
