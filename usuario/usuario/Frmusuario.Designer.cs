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
            vhrusuario1 = new Button();
            lblvhrusuario = new Panel();
            button3 = new Button();
            fotousuario = new PictureBox();
            cbanoescolar = new ComboBox();
            cbcargo = new ComboBox();
            cbunidade = new ComboBox();
            panel1 = new Panel();
            button2 = new Button();
            btnhistorico = new Button();
            button1 = new Button();
            txtsenha = new TextBox();
            lblvhrusuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fotousuario).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Location = new Point(47, 276);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(445, 20);
            txtusername.TabIndex = 0;
            txtusername.TextChanged += textBox1_TextChanged;
            // 
            // txtnomecompleto
            // 
            txtnomecompleto.BorderStyle = BorderStyle.None;
            txtnomecompleto.Location = new Point(46, 431);
            txtnomecompleto.Name = "txtnomecompleto";
            txtnomecompleto.Size = new Size(446, 20);
            txtnomecompleto.TabIndex = 1;
            // 
            // txtidaluno
            // 
            txtidaluno.BorderStyle = BorderStyle.None;
            txtidaluno.Location = new Point(48, 586);
            txtidaluno.Name = "txtidaluno";
            txtidaluno.Size = new Size(445, 20);
            txtidaluno.TabIndex = 3;
            // 
            // vhrusuario1
            // 
            vhrusuario1.BackColor = Color.Transparent;
            vhrusuario1.FlatStyle = FlatStyle.Popup;
            vhrusuario1.Location = new Point(-2, 79);
            vhrusuario1.Name = "vhrusuario1";
            vhrusuario1.Size = new Size(447, 55);
            vhrusuario1.TabIndex = 5;
            vhrusuario1.UseVisualStyleBackColor = false;
            vhrusuario1.Click += vhrusuario1_Click;
            // 
            // lblvhrusuario
            // 
            lblvhrusuario.BackColor = Color.Transparent;
            lblvhrusuario.Controls.Add(button3);
            lblvhrusuario.Controls.Add(vhrusuario1);
            lblvhrusuario.Location = new Point(576, 791);
            lblvhrusuario.Name = "lblvhrusuario";
            lblvhrusuario.Size = new Size(445, 55);
            lblvhrusuario.TabIndex = 8;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(-9, -7);
            button3.Name = "button3";
            button3.Size = new Size(454, 77);
            button3.TabIndex = 8;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_2;
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
            // cbanoescolar
            // 
            cbanoescolar.FlatStyle = FlatStyle.Flat;
            cbanoescolar.FormattingEnabled = true;
            cbanoescolar.Location = new Point(567, 424);
            cbanoescolar.Name = "cbanoescolar";
            cbanoescolar.Size = new Size(446, 28);
            cbanoescolar.TabIndex = 10;
            // 
            // cbcargo
            // 
            cbcargo.FlatStyle = FlatStyle.Flat;
            cbcargo.FormattingEnabled = true;
            cbcargo.Location = new Point(567, 582);
            cbcargo.Name = "cbcargo";
            cbcargo.Size = new Size(446, 28);
            cbcargo.TabIndex = 11;
            // 
            // cbunidade
            // 
            cbunidade.FlatStyle = FlatStyle.Flat;
            cbunidade.FormattingEnabled = true;
            cbunidade.Location = new Point(567, 273);
            cbunidade.Name = "cbunidade";
            cbunidade.Size = new Size(446, 28);
            cbunidade.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnhistorico);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(48, 795);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 55);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(-5, -11);
            button2.Name = "button2";
            button2.Size = new Size(454, 77);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = false;
            // 
            // btnhistorico
            // 
            btnhistorico.BackColor = Color.Transparent;
            btnhistorico.FlatStyle = FlatStyle.Flat;
            btnhistorico.Location = new Point(-2, -11);
            btnhistorico.Name = "btnhistorico";
            btnhistorico.Size = new Size(454, 77);
            btnhistorico.TabIndex = 6;
            btnhistorico.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(-2, 79);
            button1.Name = "button1";
            button1.Size = new Size(447, 55);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            // 
            // txtsenha
            // 
            txtsenha.BorderStyle = BorderStyle.None;
            txtsenha.Location = new Point(48, 741);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(445, 20);
            txtsenha.TabIndex = 14;
            // 
            // Frmusuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1497, 898);
            Controls.Add(txtsenha);
            Controls.Add(panel1);
            Controls.Add(cbunidade);
            Controls.Add(cbcargo);
            Controls.Add(cbanoescolar);
            Controls.Add(fotousuario);
            Controls.Add(lblvhrusuario);
            Controls.Add(txtidaluno);
            Controls.Add(txtnomecompleto);
            Controls.Add(txtusername);
            Name = "Frmusuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "usuario";
            FormClosed += Frmusuario_FormClosed;
            Load += Frmusuario_Load;
            lblvhrusuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fotousuario).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtusername;
        private TextBox txtnomecompleto;
        private TextBox txtidaluno;
        private Button vhrusuario1;
        private Panel lblvhrusuario;
        private PictureBox fotousuario;
        private ComboBox cbanoescolar;
        private ComboBox cbcargo;
        private ComboBox cbunidade;
        private Panel panel1;
        private Button button1;
        private Button btnhistorico;
        private Button button3;
        private Button button2;
        private TextBox txtsenha;
    }
}
