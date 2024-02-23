namespace trianguloadamlista3ex8
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
            txtladoa = new TextBox();
            txtladob = new TextBox();
            txtladoc = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(311, 291);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Perímetro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 208);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Valor Lado A:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 252);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor Lado B:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 310);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 3;
            label3.Text = "Valor Lado C:";
            // 
            // txtladoa
            // 
            txtladoa.Location = new Point(183, 205);
            txtladoa.Name = "txtladoa";
            txtladoa.Size = new Size(100, 23);
            txtladoa.TabIndex = 4;
            // 
            // txtladob
            // 
            txtladob.Location = new Point(183, 252);
            txtladob.Name = "txtladob";
            txtladob.Size = new Size(100, 23);
            txtladob.TabIndex = 5;
            // 
            // txtladoc
            // 
            txtladoc.Location = new Point(183, 302);
            txtladoc.Name = "txtladoc";
            txtladoc.Size = new Size(100, 23);
            txtladoc.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.triangle;
            ClientSize = new Size(515, 450);
            Controls.Add(txtladoc);
            Controls.Add(txtladob);
            Controls.Add(txtladoa);
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
        private TextBox txtladoa;
        private TextBox txtladob;
        private TextBox txtladoc;
    }
}
