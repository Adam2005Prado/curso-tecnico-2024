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
            txtusername = new TextBox();
            txtnomecompleto = new TextBox();
            txtanoescolar = new TextBox();
            txtidaluno = new TextBox();
            txtcargo = new TextBox();
            vhrusuario1 = new Button();
            btnsalvaralteracao = new Button();
            sausuario = new Panel();
            lblvhrusuario = new Panel();
            fotousuario = new PictureBox();
            sausuario.SuspendLayout();
            lblvhrusuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fotousuario).BeginInit();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.Location = new Point(47, 273);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(445, 27);
            txtusername.TabIndex = 0;
            txtusername.TextChanged += textBox1_TextChanged;
            // 
            // txtnomecompleto
            // 
            txtnomecompleto.BorderStyle = BorderStyle.None;
            txtnomecompleto.Location = new Point(46, 429);
            txtnomecompleto.Name = "txtnomecompleto";
            txtnomecompleto.Size = new Size(446, 20);
            txtnomecompleto.TabIndex = 1;
            // 
            // txtanoescolar
            // 
            txtanoescolar.Location = new Point(568, 425);
            txtanoescolar.Name = "txtanoescolar";
            txtanoescolar.Size = new Size(445, 27);
            txtanoescolar.TabIndex = 2;
            // 
            // txtidaluno
            // 
            txtidaluno.Location = new Point(48, 581);
            txtidaluno.Name = "txtidaluno";
            txtidaluno.Size = new Size(445, 27);
            txtidaluno.TabIndex = 3;
            // 
            // txtcargo
            // 
            txtcargo.Location = new Point(567, 583);
            txtcargo.Name = "txtcargo";
            txtcargo.Size = new Size(445, 27);
            txtcargo.TabIndex = 4;
            // 
            // vhrusuario1
            // 
            vhrusuario1.BackColor = Color.Transparent;
            vhrusuario1.FlatStyle = FlatStyle.Popup;
            vhrusuario1.Location = new Point(-2, 0);
            vhrusuario1.Name = "vhrusuario1";
            vhrusuario1.Size = new Size(447, 55);
            vhrusuario1.TabIndex = 5;
            vhrusuario1.UseVisualStyleBackColor = false;
            vhrusuario1.Click += vhrusuario1_Click;
            // 
            // btnsalvaralteracao
            // 
            btnsalvaralteracao.BackColor = Color.Transparent;
            btnsalvaralteracao.FlatStyle = FlatStyle.Popup;
            btnsalvaralteracao.Location = new Point(-13, -12);
            btnsalvaralteracao.Name = "btnsalvaralteracao";
            btnsalvaralteracao.Size = new Size(473, 83);
            btnsalvaralteracao.TabIndex = 6;
            btnsalvaralteracao.UseVisualStyleBackColor = false;
            // 
            // sausuario
            // 
            sausuario.BackColor = Color.Transparent;
            sausuario.Controls.Add(btnsalvaralteracao);
            sausuario.Location = new Point(567, 714);
            sausuario.Name = "sausuario";
            sausuario.Size = new Size(446, 55);
            sausuario.TabIndex = 7;
            // 
            // lblvhrusuario
            // 
            lblvhrusuario.BackColor = Color.Transparent;
            lblvhrusuario.Controls.Add(vhrusuario1);
            lblvhrusuario.Location = new Point(48, 714);
            lblvhrusuario.Name = "lblvhrusuario";
            lblvhrusuario.Size = new Size(445, 55);
            lblvhrusuario.TabIndex = 8;
            // 
            // fotousuario
            // 
            fotousuario.BackColor = Color.Transparent;
            fotousuario.Image = Properties.Resources.Wallpaper_Modelo_1_laboratorios;
            fotousuario.Location = new Point(1094, 243);
            fotousuario.Name = "fotousuario";
            fotousuario.Size = new Size(362, 551);
            fotousuario.SizeMode = PictureBoxSizeMode.StretchImage;
            fotousuario.TabIndex = 9;
            fotousuario.TabStop = false;
            fotousuario.Click += fotousuario_Click;
            // 
            // Frmusuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Usuário_Duplicada1;
            ClientSize = new Size(1497, 898);
            Controls.Add(fotousuario);
            Controls.Add(lblvhrusuario);
            Controls.Add(sausuario);
            Controls.Add(txtcargo);
            Controls.Add(txtidaluno);
            Controls.Add(txtanoescolar);
            Controls.Add(txtnomecompleto);
            Controls.Add(txtusername);
            Name = "Frmusuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "usuario";
            FormClosed += Frmusuario_FormClosed;
            sausuario.ResumeLayout(false);
            lblvhrusuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fotousuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtusername;
        private TextBox txtnomecompleto;
        private TextBox txtanoescolar;
        private TextBox txtidaluno;
        private TextBox txtcargo;
        private Button vhrusuario1;
        private Button btnsalvaralteracao;
        private Panel sausuario;
        private Panel lblvhrusuario;
        private PictureBox fotousuario;
    }
}
