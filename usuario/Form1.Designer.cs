namespace usuario
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
            txtusername = new TextBox();
            txtnomecompleto = new TextBox();
            txtanoescolar = new TextBox();
            txtidaluno = new TextBox();
            txtcargo = new TextBox();
            button1 = new Button();
            btnsalvaralteracao = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(-49, -20);
            button1.Name = "button1";
            button1.Size = new Size(569, 87);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
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
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnsalvaralteracao);
            panel1.Location = new Point(567, 714);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 55);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button1);
            panel2.Location = new Point(48, 714);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 55);
            panel2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Usuário_Duplicada1;
            ClientSize = new Size(1497, 898);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtcargo);
            Controls.Add(txtidaluno);
            Controls.Add(txtanoescolar);
            Controls.Add(txtnomecompleto);
            Controls.Add(txtusername);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtusername;
        private TextBox txtnomecompleto;
        private TextBox txtanoescolar;
        private TextBox txtidaluno;
        private TextBox txtcargo;
        private Button button1;
        private Button btnsalvaralteracao;
        private Panel panel1;
        private Panel panel2;
    }
}
