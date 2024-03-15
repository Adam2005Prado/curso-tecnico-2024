using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula5
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario usuario = new usuario();
            //int codigo=usuario.logar(textBox1.Text,textBox2.Text);
            
            DataTable dtusuario =usuario.logar(textBox1.Text,textBox2.Text);
            MessageBox.Show("Id logado:" + dtusuario.Rows[0][1].ToString());
            if (Convert.ToInt32(dtusuario.Rows[0][0]) > 0)
           
            {
                Form1 cadastro = new Form1();
                cadastro.ShowDialog();

                if (Convert.ToInt32(dtusuario.Rows[0][0]) > 0)
                {
                    frmprincipal frmprincipal=new frmprincipal(dtusuario);  
                    
                    Form1 cadastro1=new Form1();
                    cadastro1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!");
                }
            }
        }
    }
}
