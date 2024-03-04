namespace tamanhocamisetaadamlista3ex25 { 
using System;
using System.Windows.Forms;


    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        public enum tamanhocamiseta
        {
            pequeno = 0,
            medio = 1,
            grande = 2
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(tamanhocamiseta.pequeno);
            comboBox1.Items.Add(tamanhocamiseta.medio);
            comboBox1.Items.Add(tamanhocamiseta.grande);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (comboBox1.SelectedItem != null)
                {
                    tamanhocamiseta tamanhoSelecionado = (tamanhocamiseta)comboBox1.SelectedItem;
                    MessageBox.Show($"Tamanho selecionado: {tamanhoSelecionado}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, ecolha um tamanho.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { }
        }
    }

