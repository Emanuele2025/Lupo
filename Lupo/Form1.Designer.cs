namespace Lupo
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
            BtnScarica = new Button();
            TxtPercorsoCartella = new TextBox();
            lblEtichetta = new Label();
            BtnCercaCartella = new Button();
            pcbAnteprima = new PictureBox();
            lsbListaFile = new ListBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbAnteprima).BeginInit();
            SuspendLayout();
            // 
            // BtnScarica
            // 
            BtnScarica.Location = new Point(230, 94);
            BtnScarica.Name = "BtnScarica";
            BtnScarica.Size = new Size(75, 23);
            BtnScarica.TabIndex = 0;
            BtnScarica.Text = "Scarica";
            BtnScarica.UseVisualStyleBackColor = true;
            BtnScarica.Click += BtnScarica_Click;
            // 
            // TxtPercorsoCartella
            // 
            TxtPercorsoCartella.Location = new Point(0, 65);
            TxtPercorsoCartella.Name = "TxtPercorsoCartella";
            TxtPercorsoCartella.ReadOnly = true;
            TxtPercorsoCartella.Size = new Size(305, 23);
            TxtPercorsoCartella.TabIndex = 1;
            // 
            // lblEtichetta
            // 
            lblEtichetta.AutoSize = true;
            lblEtichetta.Location = new Point(5, 38);
            lblEtichetta.Name = "lblEtichetta";
            lblEtichetta.Size = new Size(152, 15);
            lblEtichetta.TabIndex = 2;
            lblEtichetta.Text = "Percorso dove salvare il file:";
            // 
            // BtnCercaCartella
            // 
            BtnCercaCartella.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnCercaCartella.Location = new Point(311, 65);
            BtnCercaCartella.Name = "BtnCercaCartella";
            BtnCercaCartella.Size = new Size(30, 29);
            BtnCercaCartella.TabIndex = 3;
            BtnCercaCartella.Text = "...";
            BtnCercaCartella.TextAlign = ContentAlignment.TopLeft;
            BtnCercaCartella.UseVisualStyleBackColor = true;
            // 
            // pcbAnteprima
            // 
            pcbAnteprima.Location = new Point(566, 28);
            pcbAnteprima.Name = "pcbAnteprima";
            pcbAnteprima.Size = new Size(398, 369);
            pcbAnteprima.TabIndex = 4;
            pcbAnteprima.TabStop = false;
            // 
            // lsbListaFile
            // 
            lsbListaFile.FormattingEnabled = true;
            lsbListaFile.Location = new Point(365, 28);
            lsbListaFile.Name = "lsbListaFile";
            lsbListaFile.Size = new Size(195, 364);
            lsbListaFile.TabIndex = 5;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Highlight;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(964, 25);
            label2.TabIndex = 6;
            label2.Text = "Lupo - Programma per il download dei sfondi giornalieri del motore di ricerca di Bing";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 407);
            Controls.Add(label2);
            Controls.Add(lsbListaFile);
            Controls.Add(pcbAnteprima);
            Controls.Add(BtnCercaCartella);
            Controls.Add(lblEtichetta);
            Controls.Add(TxtPercorsoCartella);
            Controls.Add(BtnScarica);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lupo - Gestione del download dello sfondo di bing";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pcbAnteprima).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnScarica;
        private TextBox TxtPercorsoCartella;
        private Label lblEtichetta;
        private Button BtnCercaCartella;
        private PictureBox pcbAnteprima;
        private ListBox lsbListaFile;
        private Label label2;
    }
}
