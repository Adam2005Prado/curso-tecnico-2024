using Minha_Parte_Biblio.Modelo;
using System.Data;

namespace usuario
{
    public partial class Frmusuario : Form
    {

        ClUserModelo codigo = new ClUserModelo();
        DataTable dt = new DataTable();
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

            codigo.ID_Aluno = "1";
            string ID_Aluno;
            string nameuser;
            string nomecompleto;
            string senha;
            string IMG_User;
            int CFK_Ano;
            int CFK_Cargo;
            int CFK_Unidade;

            ClConnection conexao = new ClConnection();
            dt = conexao.obterdados("select * from Table_User where ID_Aluno = " + codigo.ID_Aluno);
            nameuser = dt.Rows[0]["nameuser"].ToString();
            ID_Aluno = dt.Rows[0]["ID_Aluno"].ToString();
            nomecompleto = dt.Rows[0]["Nome_Completo"].ToString();
            senha = dt.Rows[0]["Senha"].ToString();
            IMG_User = dt.Rows[0]["IMG_User"].ToString();
            CFK_Ano = Convert.ToInt32(dt.Rows[0]["CFK_Ano"]);
            CFK_Cargo = Convert.ToInt32(dt.Rows[0]["CFK_Cargo"]);
            CFK_Unidade = Convert.ToInt32(dt.Rows[0]["CFK_Unidade"]);

            nameuser.ToString

            cbanoescolar.SelectedIndex = CFK_Ano;
            cbcargo.SelectedIndex = CFK_Cargo;
            cbunidade.SelectedIndex = CFK_Unidade;



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }
    }
}
