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
        public int alterar (string email,string senha, string nome, int id)
        {
            int registro = 0;
            string sql = "update usuario set nome=@nome,email=@email, senha=@senha where" + "cod_usu=@codigo";
            MySqlConnection conn= conexao.getconexao();
            conn.Open();
            MySqlCommand cmd= new MySqlCommand( sql,conn);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@codigo", id);
            registro=Convert.ToInt32(cmd.ExecuteNonQuery());
            conn.Close();
            return registro;


        }
        public int excluir(int codigo)
        {

            int registro = 0;
            MySqlConnection conn = conexao.getconexao();
            conn.Open();
            string sql = "Delete from usuario where cod_usu=@codigo";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            registro= Convert.ToInt32(cmd.ExecuteNonQuery());
            conn.Close();
            return registro;
        }
    }
}
