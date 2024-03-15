using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula5
{
    internal class usuario
    {
        conexao conexao = new conexao();

        public DataTable logar(string email,string senha)
        {
            DataTable dt = new DataTable();
            int registro = 0;
            try
            {
                string sql = "select * from usuario where email=@email and senha=@senha";
                MySqlConnection com = conexao.getconexao();
                com.Open();
                MySqlCommand cmd= new MySqlCommand(sql,com);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                // registro=Convert.ToInt32(cmd.ExecuteScalar());

                adapter.Fill(dt);

            } catch (Exception ex)
            {
                MessageBox.Show("Erro:"+ex.Message);
            }
            return dt;
        }
    }
}
