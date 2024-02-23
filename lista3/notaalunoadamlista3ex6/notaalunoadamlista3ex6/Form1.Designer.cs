namespace notaalunoadamlista3ex6
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
            média = new Button();
            txtnome = new TextBox();
            txtnota1 = new TextBox();
            txtnota2 = new TextBox();
            txtnota3 = new TextBox();
            txtnota4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // média
            // 
            média.Location = new Point(297, 251);
            média.Name = "média";
            média.Size = new Size(75, 23);
            média.TabIndex = 0;
            média.Text = "média";
            média.UseVisualStyleBackColor = true;
            média.Click += Média_Click;
            // 
            // txtnome
            // 
            txtnome.Location = new Point(71, 165);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(100, 23);
            txtnome.TabIndex = 1;
            // 
            // txtnota1
            // 
            txtnota1.Location = new Point(56, 239);
            txtnota1.Name = "txtnota1";
            txtnota1.Size = new Size(100, 23);
            txtnota1.TabIndex = 2;
            // 
            // txtnota2
            // 
            txtnota2.Location = new Point(56, 294);
            txtnota2.Name = "txtnota2";
            txtnota2.Size = new Size(100, 23);
            txtnota2.TabIndex = 3;
            // 
            // txtnota3
            // 
            txtnota3.Location = new Point(56, 339);
            txtnota3.Name = "txtnota3";
            txtnota3.Size = new Size(100, 23);
            txtnota3.TabIndex = 4;
            // 
            // txtnota4
            // 
            txtnota4.Location = new Point(56, 397);
            txtnota4.Name = "txtnota4";
            txtnota4.Size = new Size(100, 23);
            txtnota4.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 173);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 242);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 7;
            label2.Text = "Nota1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 302);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 8;
            label3.Text = "Nota2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 347);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 9;
            label4.Text = "Nota3:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 405);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 10;
            label5.Text = "Nota4:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(222, 107);
            label6.Name = "label6";
            label6.Size = new Size(122, 15);
            label6.TabIndex = 11;
            label6.Text = "Calculadora de Média";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.grade;
            ClientSize = new Size(493, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtnota4);
            Controls.Add(txtnota3);
            Controls.Add(txtnota2);
            Controls.Add(txtnota1);
            Controls.Add(txtnome);
            Controls.Add(média);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button média;
        private TextBox txtnome;
        private TextBox txtnota1;
        private TextBox txtnota2;
        private TextBox txtnota3;
        private TextBox txtnota4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
