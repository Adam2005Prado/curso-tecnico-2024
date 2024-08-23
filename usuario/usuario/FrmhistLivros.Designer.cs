namespace usuario
{
    partial class FrmhistLivros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nlivros = new Label();
            qqtdelivros = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // nlivros
            // 
            nlivros.AutoSize = true;
            nlivros.BackColor = Color.Transparent;
            nlivros.Font = new Font("Showcard Gothic", 66F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nlivros.ForeColor = Color.White;
            nlivros.Location = new Point(163, 681);
            nlivros.Name = "nlivros";
            nlivros.Size = new Size(187, 136);
            nlivros.TabIndex = 0;
            nlivros.Text = "00";
            nlivros.Click += label1_Click;
            // 
            // qqtdelivros
            // 
            qqtdelivros.BackColor = Color.Transparent;
            qqtdelivros.Location = new Point(435, 269);
            qqtdelivros.Name = "qqtdelivros";
            qqtdelivros.Size = new Size(973, 617);
            qqtdelivros.TabIndex = 1;
            // 
            // FrmhistLivros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.HistóricoDUPLICADA;
            ClientSize = new Size(1482, 711);
            Controls.Add(qqtdelivros);
            Controls.Add(nlivros);
            Name = "FrmhistLivros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmhistLivros";
            FormClosed += FrmhistLivros_FormClosed;
            Load += FrmhistLivros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nlivros;
        private FlowLayoutPanel qqtdelivros;
    }
}