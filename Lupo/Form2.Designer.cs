namespace Lupo
{
    partial class Form2
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
            label2 = new Label();
            label1 = new Label();
            BtnChiudi = new Button();
            LblDescrizione = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lnlEmail = new LinkLabel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Highlight;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(800, 25);
            label2.TabIndex = 7;
            label2.Text = "Lupo - Informazioni";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 26);
            label1.Name = "label1";
            label1.Size = new Size(83, 17);
            label1.TabIndex = 8;
            label1.Text = "Descrizione:";
            // 
            // BtnChiudi
            // 
            BtnChiudi.Location = new Point(713, 283);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 9;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // LblDescrizione
            // 
            LblDescrizione.Location = new Point(308, 43);
            LblDescrizione.Name = "LblDescrizione";
            LblDescrizione.Size = new Size(477, 29);
            LblDescrizione.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 92);
            label3.Name = "label3";
            label3.Size = new Size(227, 15);
            label3.TabIndex = 12;
            label3.Text = "Realizzato da Emanuele Mattei con amore";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(304, 72);
            label4.Name = "label4";
            label4.Size = new Size(63, 17);
            label4.TabIndex = 11;
            label4.Text = "Ideatore:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(304, 119);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 13;
            label5.Text = "Contatti:";
            // 
            // lnlEmail
            // 
            lnlEmail.AutoSize = true;
            lnlEmail.Location = new Point(624, 188);
            lnlEmail.Name = "lnlEmail";
            lnlEmail.Size = new Size(176, 15);
            lnlEmail.TabIndex = 14;
            lnlEmail.TabStop = true;
            lnlEmail.Text = "emanuelemattei@tutanota.com";
            lnlEmail.LinkClicked += lnlEmail_LinkClicked;
            // 
            // label6
            // 
            label6.Location = new Point(304, 136);
            label6.Name = "label6";
            label6.Size = new Size(322, 63);
            label6.TabIndex = 15;
            label6.Text = "Per informazioni o altro contattare Emanuele al numeo di telefono 339.1980065 oppure  tramite email: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lupo;
            pictureBox1.Location = new Point(-3, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 318);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(lnlEmail);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(LblDescrizione);
            Controls.Add(BtnChiudi);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informazioni su Lupo";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button BtnChiudi;
        private Label LblDescrizione;
        private Label label3;
        private Label label4;
        private Label label5;
        private LinkLabel lnlEmail;
        private Label label6;
        private PictureBox pictureBox1;
    }
}