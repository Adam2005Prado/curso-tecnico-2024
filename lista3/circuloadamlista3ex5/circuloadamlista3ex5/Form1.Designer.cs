namespace circuloadamlista3ex5
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
            btnDiametro = new Button();
            txtRaio = new TextBox();
            SuspendLayout();
            // 
            // btnDiametro
            // 
            btnDiametro.Location = new Point(174, 347);
            btnDiametro.Name = "btnDiametro";
            btnDiametro.Size = new Size(94, 29);
            btnDiametro.TabIndex = 0;
            btnDiametro.Text = "diametro";
            btnDiametro.UseVisualStyleBackColor = true;
            btnDiametro.Click += btnDiametro_Click;
            // 
            // txtRaio
            // 
            txtRaio.Location = new Point(148, 202);
            txtRaio.Name = "txtRaio";
            txtRaio.Size = new Size(125, 27);
            txtRaio.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.new_moon;
            ClientSize = new Size(514, 511);
            Controls.Add(txtRaio);
            Controls.Add(btnDiametro);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDiametro;
        private TextBox txtRaio;
    }
}
