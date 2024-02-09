using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmcalculadora frmcalculadora = new Frmcalculadora();
            frmcalculadora.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notas notas = new notas();
            notas.ShowDialog();
        }

        private void prestcaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prestacao prestacao=new prestacao ();
            prestacao.ShowDialog();
        }
    }
}
