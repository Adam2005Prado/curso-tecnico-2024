using Minha_Parte_Biblio.Modelo;
using System.Data;

namespace usuario
{
    public partial class Frmusuario : Form
    {
        int codigo;
        
        public Frmusuario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fotousuario_Click(object sender, EventArgs e)
        {

        }

        private void Frmusuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void vhrusuario1_Click(object sender, EventArgs e)
        {
            FrmhistLivros frmhistLivros = new FrmhistLivros();
            this.Hide();
            frmhistLivros.ShowDialog();
        }

        private void Frmusuario_Load(object sender, EventArgs e)
        {
            codigo=
            ClUserModelo clUserModelo = new ClUserModelo();
            DataTable dt = new DataTable();
            string username;
            conexao conexao = new conexao();
          dt= conexao.obterdados("select*from Table_User where ID_Aluno= "+codigo);
            username= dt.Rows[0][0].ToString();
            txtusername.Text = username;
            
           
            
        }
    }
}
