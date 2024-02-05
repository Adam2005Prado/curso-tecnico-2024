namespace aula2
{
    partial class Frmcalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcalculadora));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            button9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(76, 201);
            button1.Name = "button1";
            button1.Size = new Size(197, 90);
            button1.TabIndex = 7;
            button1.Text = "Soma";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(322, 201);
            button2.Name = "button2";
            button2.Size = new Size(173, 90);
            button2.TabIndex = 8;
            button2.Text = "Subtração";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(123, 337);
            button3.Name = "button3";
            button3.Size = new Size(109, 29);
            button3.TabIndex = 10;
            button3.Text = "Multiplicação";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(375, 337);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 11;
            button4.Text = "Divisão";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(66, 70);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 4;
            label1.Text = "Digite um número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(401, 83);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 5;
            label2.Text = "Digite outro número";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(565, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(596, 351);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 13;
            button5.Text = "Raiz";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(582, 214);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 12;
            button6.Text = "Potência";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(148, 166);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 6;
            button7.Text = "Báskara";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(369, 159);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 9;
            button8.Text = "Log";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(227, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(76, 107);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 3;
            label3.Text = "Digite outro número";
            // 
            // button9
            // 
            button9.Location = new Point(582, 144);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 14;
            button9.Text = "tela2";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // Frmcalculadora
            // 
            BackColor = Color.IndianRed;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(792, 425);
            Controls.Add(button9);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "Frmcalculadora";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox textBox3;
        private Label label3;
        private Button button9;
    }
}
