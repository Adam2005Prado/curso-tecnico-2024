using Minha_Parte_Biblio.Controle;
using Minha_Parte_Biblio.Modelo;
using System.Data;

namespace usuario
{
    public partial class Frmusuario : Form
    {

        ClUserModelo codigo = new ClUserModelo();
        DataTable dt = new DataTable();
        ClConnection conexao = new ClConnection();

        string ID_Aluno;
        string nameuser;
        string nomecompleto;
        string senha;
        string IMG_User;
        int CFK_Ano;
        int CFK_Cargo;
        int CFK_Unidade;
        public Frmusuario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void fotousuario_Click(object sender, EventArgs e)
        {

        }

        private void Frmusuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnvhrusuario(object sender, EventArgs e)
        {

            FrmhistLivros frmhistLivros = new FrmhistLivros();
            this.Hide();
            frmhistLivros.ShowDialog();
        }

        private void Frmusuario_Load(object sender, EventArgs e)
        {

            cbcargo.DataSource = conexao.obterdados("select * from Table_Cargo");
            cbcargo.DisplayMember = "Cargo";
            cbcargo.ValueMember = "CD_Cargo";
            cbanoescolar.DataSource = conexao.obterdados("Select * from  Table_Ano_Escolar");
            cbanoescolar.DisplayMember = "Ano_Escolar";
            cbanoescolar.ValueMember = "CD_Ano_Escolar";
            cbunidade.DataSource = conexao.obterdados("select * from Table_Unidade");
            cbunidade.DisplayMember = "Nome_Unidade";
            cbunidade.ValueMember = "CD_Unidade";

            ID_Aluno = "aluno1";



            dt = conexao.obterdados("select * from Table_User where ID_Aluno = "+ "'"+ID_Aluno+"'");

           
            nameuser = dt.Rows[0]["NameUser"].ToString();
            ID_Aluno = dt.Rows[0]["ID_Aluno"].ToString();
            nomecompleto = dt.Rows[0]["Nome_Completo"].ToString();
            senha = dt.Rows[0]["Senha"].ToString();
            IMG_User = dt.Rows[0]["IMG_User"].ToString();
            CFK_Ano = Convert.ToInt32(dt.Rows[0]["CFK_Ano"]);
            CFK_Cargo = Convert.ToInt32(dt.Rows[0]["CFK_Cargo"]);
            CFK_Unidade = Convert.ToInt32(dt.Rows[0]["CFK_Unidade"]);


            txtusername.Text = nameuser;
            txtidaluno.Text = ID_Aluno;
            txtnomecompleto.Text = nomecompleto;
            txtsenha.Text = senha;
            //fotousuario.Image = Image.FromFile(IMG_User);

            cbanoescolar.SelectedIndex = CFK_Ano - 1;

            cbcargo.SelectedIndex = CFK_Cargo - 1;
            cbunidade.SelectedIndex = CFK_Unidade - 1;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtidaluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnvhrusuarios_Click(object sender, EventArgs e)
        {
            FrmhistLivros frmhistLivros = new FrmhistLivros();
            frmhistLivros.ShowDialog();
        }

        private void btnexcluirusuario_Click(object sender, EventArgs e)
        {

        }

        private void btnsausuario_Click(object sender, EventArgs e)
        {
            ClUserModelo clUserModelo = new ClUserModelo();
            clUserModelo.ID_Aluno=txtidaluno.Text;
            clUserModelo.NomeComp=txtnomecompleto.Text;
            clUserModelo.UserName=txtusername.Text;
            clUserModelo.Password=txtsenha.Text;
            clUserModelo.Index_Cargo=cbcargo.SelectedIndex;
            clUserModelo.Index_Ano=cbanoescolar.SelectedIndex;
            clUserModelo.Index_Unidade=cbunidade.SelectedIndex;
            ClUsercontrole clUsercontrole = new ClUsercontrole();
            if(clUsercontrole.editar(clUserModelo) == true)
            {
                MessageBox.Show("Atualizado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar os dados");
            }

        }
    }
}
        
