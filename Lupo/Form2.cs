using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lupo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LblDescrizione.Text = GetDescrizione();
            label6.Text += " For info or anything else, get in touch with Emanuele at 339.1980065 or by email:";
        }

        private string GetDescrizione()
        {

            string returnDescrizione = "Programma gratuito per il download degli sfondi giornalieri del motore di ricerca Bing. - Free program to download daily Bing search wallpapers";
            return returnDescrizione;
        }

        private void lnlEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "mailto:emanuelemattei@tutanota.com",
                UseShellExecute = true
            };

            try
            {
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // log o mostrare messaggio all'utente
                MessageBox.Show("Impossibile aprire il client di posta: " + ex.Message);
            }
        }

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
