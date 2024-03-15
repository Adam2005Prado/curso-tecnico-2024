using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula5
{
    public class conexao
    {
        static private string servidor = "localhost";
        static private string bd = "projeto";
        static private string usuario = "root";
        static private string senha = "";
        public MySqlConnection conn = null;
        static private string strconn = "server=" + servidor + ";database=" + bd + ";user id=" + usuario + "; semha=" + senha;
        public MySqlConnection getconexao() {
            conn= new MySqlConnection(strconn);
                return conn;
                }
        public int cadastrar(string nome,string email,string senha)
        {
            int cadastro= 0;
            try
            {
                conn = getconexao();
                conn.Open();
                string sql = "insert into usuario (nome,email,senha) values('" + nome + "','" + email + "','" + senha + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                 cadastro  = cmd.ExecuteNonQuery();
                conn.Close();   
            } catch (Exception ex)
            {
                MessageBox.Show("Erro:"+ex.Message);
            } 
            return cadastro;
        }
       public DataTable obterdados(string sql)
        {
            DataTable dt = new DataTable();
            conn=getconexao();
            conn.Open();
            MySqlCommand cmd= new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);  
            adapter.Fill(dt);
            return dt;
        }
    }
}
