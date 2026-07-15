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
            components = new System.ComponentModel.Container();
            BtnScarica = new Button();
            TxtPercorsoCartella = new TextBox();
            lblEtichetta = new Label();
            BtnCercaCartella = new Button();
            pcbAnteprima = new PictureBox();
            cmsMenu = new ContextMenuStrip(components);
            mniImpostaComeSfondo = new ToolStripMenuItem();
            lsbListaFile = new ListBox();
            label2 = new Label();
            mnsMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            mniEsci = new ToolStripMenuItem();
            informazioniToolStripMenuItem = new ToolStripMenuItem();
            MniInformazioni = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pcbAnteprima).BeginInit();
            cmsMenu.SuspendLayout();
            mnsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // BtnScarica
            // 
            BtnScarica.Image = Properties.Resources.download;
            BtnScarica.ImageAlign = ContentAlignment.MiddleRight;
            BtnScarica.Location = new Point(230, 103);
            BtnScarica.Name = "BtnScarica";
            BtnScarica.Size = new Size(75, 23);
            BtnScarica.TabIndex = 0;
            BtnScarica.Text = "Scarica";
            BtnScarica.UseVisualStyleBackColor = true;
            BtnScarica.Click += BtnScarica_Click;
            // 
            // TxtPercorsoCartella
            // 
            TxtPercorsoCartella.Location = new Point(0, 74);
            TxtPercorsoCartella.Name = "TxtPercorsoCartella";
            TxtPercorsoCartella.ReadOnly = true;
            TxtPercorsoCartella.Size = new Size(305, 23);
            TxtPercorsoCartella.TabIndex = 1;
            // 
            // lblEtichetta
            // 
            lblEtichetta.AutoSize = true;
            lblEtichetta.Location = new Point(5, 56);
            lblEtichetta.Name = "lblEtichetta";
            lblEtichetta.Size = new Size(152, 15);
            lblEtichetta.TabIndex = 2;
            lblEtichetta.Text = "Percorso dove salvare il file:";
            // 
            // BtnCercaCartella
            // 
            BtnCercaCartella.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnCercaCartella.Location = new Point(311, 74);
            BtnCercaCartella.Name = "BtnCercaCartella";
            BtnCercaCartella.Size = new Size(30, 29);
            BtnCercaCartella.TabIndex = 3;
            BtnCercaCartella.Text = "...";
            BtnCercaCartella.TextAlign = ContentAlignment.TopLeft;
            BtnCercaCartella.UseVisualStyleBackColor = true;
            BtnCercaCartella.Click += BtnCercaCartella_Click;
            // 
            // pcbAnteprima
            // 
            pcbAnteprima.ContextMenuStrip = cmsMenu;
            pcbAnteprima.Location = new Point(566, 52);
            pcbAnteprima.Name = "pcbAnteprima";
            pcbAnteprima.Size = new Size(398, 345);
            pcbAnteprima.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAnteprima.TabIndex = 4;
            pcbAnteprima.TabStop = false;
            // 
            // cmsMenu
            // 
            cmsMenu.Items.AddRange(new ToolStripItem[] { mniImpostaComeSfondo });
            cmsMenu.Name = "cmsMenu";
            cmsMenu.Size = new Size(191, 26);
            cmsMenu.Opening += cmsMenu_Opening;
            // 
            // mniImpostaComeSfondo
            // 
            mniImpostaComeSfondo.Name = "mniImpostaComeSfondo";
            mniImpostaComeSfondo.Size = new Size(190, 22);
            mniImpostaComeSfondo.Text = "Imposta come sfondo";
            mniImpostaComeSfondo.ToolTipText = "Imposta l'immagine come sfondo di Windows ";
            mniImpostaComeSfondo.Click += mniImpostaComeSfondo_Click;
            // 
            // lsbListaFile
            // 
            lsbListaFile.FormattingEnabled = true;
            lsbListaFile.Location = new Point(365, 51);
            lsbListaFile.Name = "lsbListaFile";
            lsbListaFile.Size = new Size(195, 349);
            lsbListaFile.TabIndex = 5;
            lsbListaFile.SelectedIndexChanged += lsbListaFile_SelectedIndexChanged;
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
            // mnsMenu
            // 
            mnsMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, informazioniToolStripMenuItem });
            mnsMenu.Location = new Point(0, 25);
            mnsMenu.Name = "mnsMenu";
            mnsMenu.Size = new Size(964, 24);
            mnsMenu.TabIndex = 7;
            mnsMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mniEsci });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // mniEsci
            // 
            mniEsci.Image = Properties.Resources.chiudi_16;
            mniEsci.Name = "mniEsci";
            mniEsci.Size = new Size(180, 22);
            mniEsci.Text = "&Esci";
            mniEsci.Click += mniEsci_Click;
            // 
            // informazioniToolStripMenuItem
            // 
            informazioniToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MniInformazioni });
            informazioniToolStripMenuItem.Name = "informazioniToolStripMenuItem";
            informazioniToolStripMenuItem.Size = new Size(86, 20);
            informazioniToolStripMenuItem.Text = "Informazioni";
            // 
            // MniInformazioni
            // 
            MniInformazioni.Image = Properties.Resources.info_16;
            MniInformazioni.Name = "MniInformazioni";
            MniInformazioni.Size = new Size(180, 22);
            MniInformazioni.Text = "Informazioni....";
            MniInformazioni.Click += MniInformazioni_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 407);
            Controls.Add(mnsMenu);
            Controls.Add(label2);
            Controls.Add(lsbListaFile);
            Controls.Add(pcbAnteprima);
            Controls.Add(BtnCercaCartella);
            Controls.Add(lblEtichetta);
            Controls.Add(TxtPercorsoCartella);
            Controls.Add(BtnScarica);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = mnsMenu;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lupo - Gestione del download dello sfondo di bing";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pcbAnteprima).EndInit();
            cmsMenu.ResumeLayout(false);
            mnsMenu.ResumeLayout(false);
            mnsMenu.PerformLayout();
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
        private ContextMenuStrip cmsMenu;
        private ToolStripMenuItem mniImpostaComeSfondo;
        private MenuStrip mnsMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem mniEsci;
        private ToolStripMenuItem informazioniToolStripMenuItem;
        private ToolStripMenuItem MniInformazioni;
    }
}
