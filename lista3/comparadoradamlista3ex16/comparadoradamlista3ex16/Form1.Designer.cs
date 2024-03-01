namespace comparadoradamlista3ex16
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
            txtnum1inteiro = new TextBox();
            txtnum2inteiro = new TextBox();
            txtnum1decimal = new TextBox();
            txtnum2decimal = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(60, 347);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 0;
            button1.Text = "Comparar inteiros";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(343, 360);
            button2.Name = "button2";
            button2.Size = new Size(152, 29);
            button2.TabIndex = 1;
            button2.Text = "Comparar decimais";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 107);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 2;
            label1.Text = "Insira um valor inteiro:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 201);
            label2.Name = "label2";
            label2.Size = new Size(171, 20);
            label2.TabIndex = 3;
            label2.Text = "Insira outro valor inteiro:\r\n";
            // 
            // txtnum1inteiro
            // 
            txtnum1inteiro.Location = new Point(60, 146);
            txtnum1inteiro.Name = "txtnum1inteiro";
            txtnum1inteiro.Size = new Size(125, 27);
            txtnum1inteiro.TabIndex = 4;
            // 
            // txtnum2inteiro
            // 
            txtnum2inteiro.Location = new Point(60, 256);
            txtnum2inteiro.Name = "txtnum2inteiro";
            txtnum2inteiro.Size = new Size(125, 27);
            txtnum2inteiro.TabIndex = 5;
            // 
            // txtnum1decimal
            // 
            txtnum1decimal.Location = new Point(370, 156);
            txtnum1decimal.Name = "txtnum1decimal";
            txtnum1decimal.Size = new Size(125, 27);
            txtnum1decimal.TabIndex = 6;
            // 
            // txtnum2decimal
            // 
            txtnum2decimal.Location = new Point(359, 276);
            txtnum2decimal.Name = "txtnum2decimal";
            txtnum2decimal.Size = new Size(125, 27);
            txtnum2decimal.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 114);
            label3.Name = "label3";
            label3.Size = new Size(166, 20);
            label3.TabIndex = 8;
            label3.Text = "Insira um valor decimal:\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 227);
            label4.Name = "label4";
            label4.Size = new Size(181, 20);
            label4.TabIndex = 9;
            label4.Text = "Insira outro valor decimal:\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.up_down;
            ClientSize = new Size(543, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtnum2decimal);
            Controls.Add(txtnum1decimal);
            Controls.Add(txtnum2inteiro);
            Controls.Add(txtnum1inteiro);
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
        private TextBox txtnum1inteiro;
        private TextBox txtnum2inteiro;
        private TextBox txtnum1decimal;
        private TextBox txtnum2decimal;
        private Label label3;
        private Label label4;
    }
}
