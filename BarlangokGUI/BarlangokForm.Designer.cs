namespace BarlangokGUI
{
    partial class BarlangokForm
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
            lblUi001 = new Label();
            tbAzonosito = new TextBox();
            btnKereses = new Button();
            lblUi002 = new Label();
            lblUi003 = new Label();
            lblUi004 = new Label();
            tbHosszusag = new TextBox();
            tbMelyseg = new TextBox();
            lblBarlangNeve = new Label();
            btnMentes = new Button();
            SuspendLayout();
            // 
            // lblUi001
            // 
            lblUi001.AutoSize = true;
            lblUi001.Location = new Point(38, 47);
            lblUi001.Name = "lblUi001";
            lblUi001.Size = new Size(100, 25);
            lblUi001.TabIndex = 0;
            lblUi001.Text = "Azonosító:";
            // 
            // tbAzonosito
            // 
            tbAzonosito.Location = new Point(303, 44);
            tbAzonosito.Name = "tbAzonosito";
            tbAzonosito.Size = new Size(81, 32);
            tbAzonosito.TabIndex = 0;
            // 
            // btnKereses
            // 
            btnKereses.Location = new Point(432, 44);
            btnKereses.Name = "btnKereses";
            btnKereses.Size = new Size(187, 39);
            btnKereses.TabIndex = 1;
            btnKereses.Text = "Barlang keresése";
            btnKereses.UseVisualStyleBackColor = true;
            // 
            // lblUi002
            // 
            lblUi002.AutoSize = true;
            lblUi002.Location = new Point(12, 111);
            lblUi002.Name = "lblUi002";
            lblUi002.Size = new Size(126, 25);
            lblUi002.TabIndex = 0;
            lblUi002.Text = "Barlang neve:";
            // 
            // lblUi003
            // 
            lblUi003.AutoSize = true;
            lblUi003.Location = new Point(33, 175);
            lblUi003.Name = "lblUi003";
            lblUi003.Size = new Size(105, 25);
            lblUi003.TabIndex = 0;
            lblUi003.Text = "Hosszúság:";
            // 
            // lblUi004
            // 
            lblUi004.AutoSize = true;
            lblUi004.Location = new Point(52, 239);
            lblUi004.Name = "lblUi004";
            lblUi004.Size = new Size(86, 25);
            lblUi004.TabIndex = 0;
            lblUi004.Text = "Mélység:";
            // 
            // tbHosszusag
            // 
            tbHosszusag.Location = new Point(219, 172);
            tbHosszusag.Name = "tbHosszusag";
            tbHosszusag.Size = new Size(165, 32);
            tbHosszusag.TabIndex = 2;
            // 
            // tbMelyseg
            // 
            tbMelyseg.Location = new Point(219, 236);
            tbMelyseg.Name = "tbMelyseg";
            tbMelyseg.Size = new Size(165, 32);
            tbMelyseg.TabIndex = 3;
            // 
            // lblBarlangNeve
            // 
            lblBarlangNeve.AutoSize = true;
            lblBarlangNeve.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBarlangNeve.Location = new Point(219, 111);
            lblBarlangNeve.Name = "lblBarlangNeve";
            lblBarlangNeve.Size = new Size(0, 25);
            lblBarlangNeve.TabIndex = 0;
            // 
            // btnMentes
            // 
            btnMentes.Enabled = false;
            btnMentes.Location = new Point(432, 172);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(187, 39);
            btnMentes.TabIndex = 4;
            btnMentes.Text = "Adatok mentése";
            btnMentes.UseVisualStyleBackColor = true;
            // 
            // BarlangokForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 311);
            Controls.Add(btnMentes);
            Controls.Add(btnKereses);
            Controls.Add(tbMelyseg);
            Controls.Add(tbHosszusag);
            Controls.Add(tbAzonosito);
            Controls.Add(lblUi004);
            Controls.Add(lblUi003);
            Controls.Add(lblBarlangNeve);
            Controls.Add(lblUi002);
            Controls.Add(lblUi001);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "BarlangokForm";
            Text = "Barlangok";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUi001;
        private TextBox tbAzonosito;
        private Button btnKereses;
        private Label lblUi002;
        private Label lblUi003;
        private Label lblUi004;
        private TextBox tbHosszusag;
        private TextBox tbMelyseg;
        private Label lblBarlangNeve;
        private Button btnMentes;
    }
}
