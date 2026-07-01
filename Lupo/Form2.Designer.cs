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
            label1.Location = new Point(22, 49);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 8;
            label1.Text = "Descrizione:";
            // 
            // BtnChiudi
            // 
            BtnChiudi.Location = new Point(701, 415);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 9;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            // 
            // LblDescrizione
            // 
            LblDescrizione.AutoSize = true;
            LblDescrizione.Location = new Point(16, 69);
            LblDescrizione.Name = "LblDescrizione";
            LblDescrizione.Size = new Size(0, 15);
            LblDescrizione.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 115);
            label3.Name = "label3";
            label3.Size = new Size(227, 15);
            label3.TabIndex = 12;
            label3.Text = "Realizzato da Emanuele Mattei con amore";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 95);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 11;
            label4.Text = "Ideatore:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 142);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 13;
            label5.Text = "Contatti:";
            // 
            // lnlEmail
            // 
            lnlEmail.AutoSize = true;
            lnlEmail.Location = new Point(352, 163);
            lnlEmail.Name = "lnlEmail";
            lnlEmail.Size = new Size(176, 15);
            lnlEmail.TabIndex = 14;
            lnlEmail.TabStop = true;
            lnlEmail.Text = "emanuelemattei@tutanota.com";
            lnlEmail.LinkClicked += lnlEmail_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 163);
            label6.Name = "label6";
            label6.Size = new Size(322, 15);
            label6.TabIndex = 15;
            label6.Text = "Per informazioni o altro contattare Emanuele tramite email: ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}