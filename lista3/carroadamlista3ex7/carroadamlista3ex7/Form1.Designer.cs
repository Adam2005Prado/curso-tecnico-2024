namespace carroadamlista3ex7
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
            txtmarca = new TextBox();
            txtmodelo = new TextBox();
            txtdescricao = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtmarca
            // 
            txtmarca.Location = new Point(132, 274);
            txtmarca.Name = "txtmarca";
            txtmarca.Size = new Size(100, 23);
            txtmarca.TabIndex = 0;
            // 
            // txtmodelo
            // 
            txtmodelo.Location = new Point(132, 327);
            txtmodelo.Name = "txtmodelo";
            txtmodelo.Size = new Size(100, 23);
            txtmodelo.TabIndex = 1;
            // 
            // txtdescricao
            // 
            txtdescricao.Location = new Point(132, 388);
            txtdescricao.Name = "txtdescricao";
            txtdescricao.Size = new Size(100, 23);
            txtdescricao.TabIndex = 2;
            txtdescricao.TextChanged += txtdescricao_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 272);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 335);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 4;
            label2.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 396);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Descricao";
            // 
            // button1
            // 
            button1.Location = new Point(289, 326);
            button1.Name = "button1";
            button1.Size = new Size(187, 23);
            button1.TabIndex = 6;
            button1.Text = "Exibir descrição";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.car;
            ClientSize = new Size(510, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtdescricao);
            Controls.Add(txtmodelo);
            Controls.Add(txtmarca);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtmarca;
        private TextBox txtmodelo;
        private TextBox txtdescricao;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
