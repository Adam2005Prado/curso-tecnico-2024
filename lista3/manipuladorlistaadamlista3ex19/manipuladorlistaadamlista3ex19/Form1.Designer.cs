namespace manipuladorlistaadamlista3ex19
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
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 349);
            button1.Name = "button1";
            button1.Size = new Size(163, 29);
            button1.TabIndex = 0;
            button1.Text = "remover elemento";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(211, 349);
            button2.Name = "button2";
            button2.Size = new Size(240, 29);
            button2.TabIndex = 1;
            button2.Text = "remover elemento por indice";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(476, 349);
            button3.Name = "button3";
            button3.Size = new Size(240, 29);
            button3.TabIndex = 2;
            button3.Text = "adicionar elemento";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 59);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 3;
            label1.Text = "Manipulador de listas";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(527, 280);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(50, 238);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(262, 238);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(539, 209);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 8;
            label2.Text = "Insira um número:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 174);
            label3.Name = "label3";
            label3.Size = new Size(193, 20);
            label3.TabIndex = 9;
            label3.Text = "Insira o índice do elemento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 174);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 10;
            label4.Text = "Insira um elemento:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
