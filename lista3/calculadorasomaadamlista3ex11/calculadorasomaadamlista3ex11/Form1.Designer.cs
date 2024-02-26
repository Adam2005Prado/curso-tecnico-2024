namespace calculadorasomaadamlista3ex11
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
            valor1double = new TextBox();
            valor2double = new TextBox();
            label3 = new Label();
            label4 = new Label();
            valorinteiro1 = new TextBox();
            valorinteiro2 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(51, 283);
            button1.Name = "button1";
            button1.Size = new Size(123, 29);
            button1.TabIndex = 0;
            button1.Text = "Somar Double";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-3, 137);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 1;
            label1.Text = "Insira um valor Double:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-3, 212);
            label2.Name = "label2";
            label2.Size = new Size(177, 20);
            label2.TabIndex = 2;
            label2.Text = "Insira outro valor Double:";
            // 
            // valor1double
            // 
            valor1double.Location = new Point(165, 137);
            valor1double.Name = "valor1double";
            valor1double.Size = new Size(125, 27);
            valor1double.TabIndex = 3;
            // 
            // valor2double
            // 
            valor2double.Location = new Point(180, 205);
            valor2double.Name = "valor2double";
            valor2double.Size = new Size(125, 27);
            valor2double.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(327, 137);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 5;
            label3.Text = "Insira um valor inteiro:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(327, 225);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 6;
            label4.Text = "Insira outro valor inteiro:";
            // 
            // valorinteiro1
            // 
            valorinteiro1.Location = new Point(504, 130);
            valorinteiro1.Name = "valorinteiro1";
            valorinteiro1.Size = new Size(125, 27);
            valorinteiro1.TabIndex = 7;
            // 
            // valorinteiro2
            // 
            valorinteiro2.Location = new Point(507, 218);
            valorinteiro2.Name = "valorinteiro2";
            valorinteiro2.Size = new Size(125, 27);
            valorinteiro2.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(375, 283);
            button2.Name = "button2";
            button2.Size = new Size(123, 29);
            button2.TabIndex = 9;
            button2.Text = "Somar inteiro";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.plus_symbol_button;
            ClientSize = new Size(644, 450);
            Controls.Add(button2);
            Controls.Add(valorinteiro2);
            Controls.Add(valorinteiro1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(valor2double);
            Controls.Add(valor1double);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox valor1double;
        private TextBox valor2double;
        private Label label3;
        private Label label4;
        private TextBox valorinteiro1;
        private TextBox valorinteiro2;
        private Button button2;
    }
}
