namespace calculodescontoadamlista3ex9
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
            label1 = new Label();
            calculardesconto = new Button();
            txtnomeproduto = new TextBox();
            label2 = new Label();
            txtvalorproduto = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtdesconto = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de descontos";
            // 
            // calculardesconto
            // 
            calculardesconto.Location = new Point(260, 322);
            calculardesconto.Name = "calculardesconto";
            calculardesconto.Size = new Size(237, 29);
            calculardesconto.TabIndex = 1;
            calculardesconto.Text = "Calcular Desconto\r\n";
            calculardesconto.UseVisualStyleBackColor = true;
            calculardesconto.Click += button1_Click;
            // 
            // txtnomeproduto
            // 
            txtnomeproduto.Location = new Point(287, 67);
            txtnomeproduto.Name = "txtnomeproduto";
            txtnomeproduto.Size = new Size(125, 27);
            txtnomeproduto.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 70);
            label2.Name = "label2";
            label2.Size = new Size(182, 20);
            label2.TabIndex = 3;
            label2.Text = "Insira o nome do produto:";
            // 
            // txtvalorproduto
            // 
            txtvalorproduto.Location = new Point(287, 136);
            txtvalorproduto.Name = "txtvalorproduto";
            txtvalorproduto.Size = new Size(125, 27);
            txtvalorproduto.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-2, 139);
            label3.Name = "label3";
            label3.Size = new Size(240, 20);
            label3.TabIndex = 5;
            label3.Text = "Insira o valaor original do produto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-2, 208);
            label4.Name = "label4";
            label4.Size = new Size(272, 20);
            label4.TabIndex = 6;
            label4.Text = "Insira o valaor do desconto do produto:";
            // 
            // txtdesconto
            // 
            txtdesconto.Location = new Point(287, 201);
            txtdesconto.Name = "txtdesconto";
            txtdesconto.Size = new Size(125, 27);
            txtdesconto.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.discount;
            ClientSize = new Size(501, 450);
            Controls.Add(txtdesconto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtvalorproduto);
            Controls.Add(label2);
            Controls.Add(txtnomeproduto);
            Controls.Add(calculardesconto);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button calculardesconto;
        private TextBox txtnomeproduto;
        private Label label2;
        private TextBox txtvalorproduto;
        private Label label3;
        private Label label4;
        private TextBox txtdesconto;
    }
}
