namespace conversormoedasadamlista3ex12
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
            label1 = new Label();
            label2 = new Label();
            moedadolar = new TextBox();
            taxacambio1 = new TextBox();
            label3 = new Label();
            moedareal = new TextBox();
            label4 = new Label();
            taxacambio2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(42, 138);
            button1.Name = "button1";
            button1.Size = new Size(161, 29);
            button1.TabIndex = 0;
            button1.Text = "Converter para Reais";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 402);
            button2.Name = "button2";
            button2.Size = new Size(171, 29);
            button2.TabIndex = 1;
            button2.Text = "Converter para Dólares";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-5, 20);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 2;
            label1.Text = "Insira o valor em Dólares:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-5, 65);
            label2.Name = "label2";
            label2.Size = new Size(225, 20);
            label2.TabIndex = 3;
            label2.Text = "Insira o valor da taxa de câmbio:";
            // 
            // moedadolar
            // 
            moedadolar.Location = new Point(178, 20);
            moedadolar.Name = "moedadolar";
            moedadolar.Size = new Size(125, 27);
            moedadolar.TabIndex = 4;
            // 
            // taxacambio1
            // 
            taxacambio1.Location = new Point(207, 265);
            taxacambio1.Name = "taxacambio1";
            taxacambio1.Size = new Size(125, 27);
            taxacambio1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 272);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 6;
            label3.Text = "Insira o valor em Reais:";
            // 
            // moedareal
            // 
            moedareal.Location = new Point(221, 62);
            moedareal.Name = "moedareal";
            moedareal.Size = new Size(125, 27);
            moedareal.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-5, 341);
            label4.Name = "label4";
            label4.Size = new Size(225, 20);
            label4.TabIndex = 8;
            label4.Text = "Insira o valor da taxa de câmbio:";
            // 
            // taxacambio2
            // 
            taxacambio2.Location = new Point(226, 334);
            taxacambio2.Name = "taxacambio2";
            taxacambio2.Size = new Size(125, 27);
            taxacambio2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.currency_exchange;
            ClientSize = new Size(505, 569);
            Controls.Add(taxacambio2);
            Controls.Add(label4);
            Controls.Add(moedareal);
            Controls.Add(label3);
            Controls.Add(taxacambio1);
            Controls.Add(moedadolar);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private TextBox moedadolar;
        private TextBox taxacambio1;
        private Label label3;
        private TextBox moedareal;
        private Label label4;
        private TextBox taxacambio2;
    }
}
