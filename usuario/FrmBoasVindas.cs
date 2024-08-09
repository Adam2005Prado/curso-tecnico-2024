using Minha_Parte_Biblio.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using usuario;

namespace Minha_Parte_Biblio
{
    public partial class FrmBoasVindas : Form
    {
        ClUserModelo Usuario_Modelo = new ClUserModelo();
        public FrmBoasVindas(ClUserModelo UserCont)
        {
            Usuario_Modelo = UserCont;
            InitializeComponent();
        }

        private void FrmBoasVindas_Load(object sender, EventArgs e)
        {
            LbNomeComp.Text = Usuario_Modelo.NomeComp;
        }

        private void FrmBoasVindas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BntViajar_Click(object sender, EventArgs e)
        {
            Frmusuario user = new Frmusuario(Usuario_Modelo);
            this.Hide();
            user.ShowDialog();

        }
    }
}
