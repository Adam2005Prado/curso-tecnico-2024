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
    public partial class frmprincipal : Form
    {
        DataTable login;
        public frmprincipal(DataTable usuario)
        {                                                       
            this.login = usuario;
            MessageBox.Show("Seja bem vindo" + this.login.Rows[0][1].ToString());
            InitializeComponent();
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {

        }                                        
    }
}
