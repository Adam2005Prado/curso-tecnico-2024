namespace salariofuncionarioadamlista3ex10
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
            label3 = new Label();
            txtnomefuncionario = new TextBox();
            txtsalariofuncionario = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(278, 309);
            button1.Name = "button1";
            button1.Size = new Size(168, 29);
            button1.TabIndex = 0;
            button1.Text = "calacular salario\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 26);
            label1.Name = "label1";
            label1.Size = new Size(124, 40);
            label1.TabIndex = 1;
            label1.Text = "Salário Anual\r\n dos Funcionários\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(203, 40);
            label2.TabIndex = 2;
            label2.Text = "Insira o nome do funcionário:\r\n\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 186);
            label3.Name = "label3";
            label3.Size = new Size(260, 40);
            label3.TabIndex = 3;
            label3.Text = "Insira o salário mensal do funcionário:\r\n\r\n";
            // 
            // txtnomefuncionario
            // 
            txtnomefuncionario.Location = new Point(278, 117);
            txtnomefuncionario.Name = "txtnomefuncionario";
            txtnomefuncionario.Size = new Size(125, 27);
            txtnomefuncionario.TabIndex = 4;
            // 
            // txtsalariofuncionario
            // 
            txtsalariofuncionario.Location = new Point(278, 186);
            txtsalariofuncionario.Name = "txtsalariofuncionario";
            txtsalariofuncionario.Size = new Size(125, 27);
            txtsalariofuncionario.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.salary;
            ClientSize = new Size(505, 511);
            Controls.Add(txtsalariofuncionario);
            Controls.Add(txtnomefuncionario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtnomefuncionario;
        private TextBox txtsalariofuncionario;
    }
}
