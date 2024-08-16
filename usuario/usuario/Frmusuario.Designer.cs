namespace usuario
{
    partial class Frmusuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmusuario));
            txtusername = new TextBox();
            txtnomecompleto = new TextBox();
            txtidaluno = new TextBox();
            cbanoescolar = new ComboBox();
            cbcargo = new ComboBox();
            cbunidade = new ComboBox();
            txtsenha = new TextBox();
            fotousuario = new PictureBox();
            pnvhrusuario = new Panel();
            btnvhrusuarios = new Button();
            pnsausuario = new Panel();
            btnsausuario = new Button();
            btnexcluirusuario = new Button();
            pnexcluirusuario = new Panel();
            ((System.ComponentModel.ISupportInitialize)fotousuario).BeginInit();
            pnvhrusuario.SuspendLayout();
            pnsausuario.SuspendLayout();
            pnexcluirusuario.SuspendLayout();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Location = new Point(38, 124);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(445, 20);
            txtusername.TabIndex = 0;
            txtusername.TextChanged += textBox1_TextChanged;
            // 
            // txtnomecompleto
            // 
            txtnomecompleto.BorderStyle = BorderStyle.None;
            txtnomecompleto.Location = new Point(35, 279);
            txtnomecompleto.Name = "txtnomecompleto";
            txtnomecompleto.Size = new Size(446, 20);
            txtnomecompleto.TabIndex = 1;
            // 
            // txtidaluno
            // 
            txtidaluno.BorderStyle = BorderStyle.None;
            txtidaluno.Location = new Point(35, 433);
            txtidaluno.Name = "txtidaluno";
            txtidaluno.Size = new Size(445, 20);
            txtidaluno.TabIndex = 3;
            txtidaluno.TextChanged += txtidaluno_TextChanged;
            // 
            // cbanoescolar
            // 
            cbanoescolar.FlatStyle = FlatStyle.Flat;
            cbanoescolar.FormattingEnabled = true;
            cbanoescolar.Location = new Point(555, 273);
            cbanoescolar.Name = "cbanoescolar";
            cbanoescolar.Size = new Size(446, 28);
            cbanoescolar.TabIndex = 10;
            // 
            // cbcargo
            // 
            cbcargo.FlatStyle = FlatStyle.Flat;
            cbcargo.FormattingEnabled = true;
            cbcargo.Location = new Point(555, 428);
            cbcargo.Name = "cbcargo";
            cbcargo.Size = new Size(446, 28);
            cbcargo.TabIndex = 11;
            // 
            // cbunidade
            // 
            cbunidade.FlatStyle = FlatStyle.Flat;
            cbunidade.FormattingEnabled = true;
            cbunidade.Location = new Point(555, 120);
            cbunidade.Name = "cbunidade";
            cbunidade.Size = new Size(446, 28);
            cbunidade.TabIndex = 12;
            // 
            // txtsenha
            // 
            txtsenha.BorderStyle = BorderStyle.None;
            txtsenha.Location = new Point(38, 588);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(445, 20);
            txtsenha.TabIndex = 14;
            // 
            // fotousuario
            // 
            fotousuario.BackColor = Color.Transparent;
            fotousuario.Image = Properties.Resources.Wallpaper_Modelo_1_laboratorios;
            fotousuario.Location = new Point(1088, 88);
            fotousuario.Name = "fotousuario";
            fotousuario.Size = new Size(362, 551);
            fotousuario.SizeMode = PictureBoxSizeMode.CenterImage;
            fotousuario.TabIndex = 9;
            fotousuario.TabStop = false;
            fotousuario.Click += fotousuario_Click;
            // 
            // pnvhrusuario
            // 
            pnvhrusuario.BackColor = Color.Transparent;
            pnvhrusuario.Controls.Add(btnvhrusuarios);
            pnvhrusuario.Location = new Point(562, 533);
            pnvhrusuario.Name = "pnvhrusuario";
            pnvhrusuario.Size = new Size(447, 58);
            pnvhrusuario.TabIndex = 15;
            // 
            // btnvhrusuarios
            // 
            btnvhrusuarios.FlatStyle = FlatStyle.Popup;
            btnvhrusuarios.Location = new Point(1, 3);
            btnvhrusuarios.Name = "btnvhrusuarios";
            btnvhrusuarios.Size = new Size(450, 52);
            btnvhrusuarios.TabIndex = 0;
            btnvhrusuarios.UseVisualStyleBackColor = true;
            btnvhrusuarios.Click += btnvhrusuarios_Click;
            // 
            // pnsausuario
            // 
            pnsausuario.BackColor = Color.Transparent;
            pnsausuario.Controls.Add(btnsausuario);
            pnsausuario.Location = new Point(561, 635);
            pnsausuario.Name = "pnsausuario";
            pnsausuario.Size = new Size(452, 53);
            pnsausuario.TabIndex = 16;
            // 
            // btnsausuario
            // 
            btnsausuario.FlatStyle = FlatStyle.Popup;
            btnsausuario.Location = new Point(2, -2);
            btnsausuario.Name = "btnsausuario";
            btnsausuario.Size = new Size(452, 52);
            btnsausuario.TabIndex = 1;
            btnsausuario.UseVisualStyleBackColor = true;
            btnsausuario.Click += btnsausuario_Click;
            // 
            // btnexcluirusuario
            // 
            btnexcluirusuario.FlatStyle = FlatStyle.Popup;
            btnexcluirusuario.Location = new Point(-14, -1);
            btnexcluirusuario.Name = "btnexcluirusuario";
            btnexcluirusuario.Size = new Size(534, 52);
            btnexcluirusuario.TabIndex = 2;
            btnexcluirusuario.UseVisualStyleBackColor = true;
            btnexcluirusuario.Click += btnexcluirusuario_Click;
            // 
            // pnexcluirusuario
            // 
            pnexcluirusuario.BackColor = Color.Transparent;
            pnexcluirusuario.Controls.Add(btnexcluirusuario);
            pnexcluirusuario.Location = new Point(77, 662);
            pnexcluirusuario.Name = "pnexcluirusuario";
            pnexcluirusuario.Size = new Size(365, 53);
            pnexcluirusuario.TabIndex = 17;
            // 
            // Frmusuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1500, 758);
            Controls.Add(pnexcluirusuario);
            Controls.Add(pnsausuario);
            Controls.Add(pnvhrusuario);
            Controls.Add(txtsenha);
            Controls.Add(cbunidade);
            Controls.Add(cbcargo);
            Controls.Add(cbanoescolar);
            Controls.Add(fotousuario);
            Controls.Add(txtidaluno);
            Controls.Add(txtnomecompleto);
            Controls.Add(txtusername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frmusuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "usuario";
            FormClosed += Frmusuario_FormClosed;
            Load += Frmusuario_Load;
            ((System.ComponentModel.ISupportInitialize)fotousuario).EndInit();
            pnvhrusuario.ResumeLayout(false);
            pnsausuario.ResumeLayout(false);
            pnexcluirusuario.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtusername;
        private TextBox txtnomecompleto;
        private TextBox txtidaluno;
        private Button vhrusuario1;
        private Panel lblvhrusuario;
        private ComboBox cbanoescolar;
        private ComboBox cbcargo;
        private ComboBox cbunidade;
        private Panel pnsausuario;
        private Button btnhistorico;
        private Button button3;
        private Button button2;
        private TextBox txtsenha;
        private PictureBox fotousuario;
        private Panel pnvhrusuario;
        private Button btnsausuario;
        private Button btnvhrusuarios;
        private Button btnexcluirusuario;
        private Panel pnexcluirusuario;
    }
}
