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
            textBox1 = new TextBox();
            label1 = new Label();
            BtnCercaCartella = new Button();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 65);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(305, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 38);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 2;
            label1.Text = "Percorso dove salvare il file:";
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(566, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(398, 369);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(365, 28);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(195, 364);
            listBox1.TabIndex = 5;
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
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(BtnCercaCartella);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(BtnScarica);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lupo - Gestione del download dello sfondo di bing";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnScarica;
        private TextBox textBox1;
        private Label label1;
        private Button BtnCercaCartella;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Label label2;
    }
}
