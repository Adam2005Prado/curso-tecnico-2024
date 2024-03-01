namespace calculadorageometricaadamlista3ex15
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
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtlarguraretangulo = new TextBox();
            txtalturaretangulo = new TextBox();
            txtbasetriangulo = new TextBox();
            txtalturatriangulo = new TextBox();
            txtraiocirculo = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(34, 373);
            button1.Name = "button1";
            button1.Size = new Size(169, 29);
            button1.TabIndex = 0;
            button1.Text = "Área Retângulo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(269, 373);
            button2.Name = "button2";
            button2.Size = new Size(169, 29);
            button2.TabIndex = 1;
            button2.Text = "Área Triângulo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(303, 448);
            button3.Name = "button3";
            button3.Size = new Size(169, 29);
            button3.TabIndex = 2;
            button3.Text = "Área Circulo\r\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 112);
            label1.Name = "label1";
            label1.Size = new Size(200, 20);
            label1.TabIndex = 3;
            label1.Text = "Insira a largura do retângulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 170);
            label2.Name = "label2";
            label2.Size = new Size(191, 20);
            label2.TabIndex = 4;
            label2.Text = "Insira a altura do retângulo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 427);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 5;
            label3.Text = "Insira o raio do circulo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(194, 211);
            label4.Name = "label4";
            label4.Size = new Size(180, 20);
            label4.TabIndex = 6;
            label4.Text = "Insira a base do triângulo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(187, 276);
            label5.Name = "label5";
            label5.Size = new Size(187, 20);
            label5.TabIndex = 7;
            label5.Text = "Insira a altura do triângulo:";
            // 
            // txtlarguraretangulo
            // 
            txtlarguraretangulo.Location = new Point(223, 109);
            txtlarguraretangulo.Name = "txtlarguraretangulo";
            txtlarguraretangulo.Size = new Size(125, 27);
            txtlarguraretangulo.TabIndex = 8;
            // 
            // txtalturaretangulo
            // 
            txtalturaretangulo.Location = new Point(233, 163);
            txtalturaretangulo.Name = "txtalturaretangulo";
            txtalturaretangulo.Size = new Size(125, 27);
            txtalturaretangulo.TabIndex = 9;
            // 
            // txtbasetriangulo
            // 
            txtbasetriangulo.Location = new Point(380, 211);
            txtbasetriangulo.Name = "txtbasetriangulo";
            txtbasetriangulo.Size = new Size(125, 27);
            txtbasetriangulo.TabIndex = 10;
            // 
            // txtalturatriangulo
            // 
            txtalturatriangulo.Location = new Point(380, 269);
            txtalturatriangulo.Name = "txtalturatriangulo";
            txtalturatriangulo.Size = new Size(125, 27);
            txtalturatriangulo.TabIndex = 11;
            // 
            // txtraiocirculo
            // 
            txtraiocirculo.Location = new Point(114, 463);
            txtraiocirculo.Name = "txtraiocirculo";
            txtraiocirculo.Size = new Size(125, 27);
            txtraiocirculo.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.shapes;
            ClientSize = new Size(505, 502);
            Controls.Add(txtraiocirculo);
            Controls.Add(txtalturatriangulo);
            Controls.Add(txtbasetriangulo);
            Controls.Add(txtalturaretangulo);
            Controls.Add(txtlarguraretangulo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtlarguraretangulo;
        private TextBox txtalturaretangulo;
        private TextBox txtbasetriangulo;
        private TextBox txtalturatriangulo;
        private TextBox txtraiocirculo;
    }
}
