﻿namespace aula5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtnome = new TextBox();
            txtemail = new TextBox();
            txtsenha = new TextBox();
            btncadastrar = new Button();
            dataGridView1 = new DataGridView();
            btneditar = new Button();
            btnexcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(226, 386);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Conexao";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 113);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 1;
            label1.Text = "Insira o nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 184);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "Insira o email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 251);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 3;
            label3.Text = "Insira a senha:";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(249, 115);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(100, 23);
            txtnome.TabIndex = 4;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(249, 176);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(100, 23);
            txtemail.TabIndex = 5;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(249, 243);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(100, 23);
            txtsenha.TabIndex = 6;
            // 
            // btncadastrar
            // 
            btncadastrar.Location = new Point(226, 310);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(75, 23);
            btncadastrar.TabIndex = 7;
            btncadastrar.Text = "Cadastrar";
            btncadastrar.UseVisualStyleBackColor = true;
            btncadastrar.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(494, 228);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btneditar
            // 
            btneditar.Location = new Point(131, 310);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(75, 23);
            btneditar.TabIndex = 9;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btneditar_Click;
            // 
            // btnexcluir
            // 
            btnexcluir.Location = new Point(356, 310);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(75, 23);
            btnexcluir.TabIndex = 10;
            btnexcluir.Text = "excluir";
            btnexcluir.UseVisualStyleBackColor = true;
            btnexcluir.Click += btnexcluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnexcluir);
            Controls.Add(btneditar);
            Controls.Add(dataGridView1);
            Controls.Add(btncadastrar);
            Controls.Add(txtsenha);
            Controls.Add(txtemail);
            Controls.Add(txtnome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtnome;
        private TextBox txtemail;
        private TextBox txtsenha;
        private Button btncadastrar;
        private DataGridView dataGridView1;
        private Button btneditar;
        private Button btnexcluir;
    }
}
