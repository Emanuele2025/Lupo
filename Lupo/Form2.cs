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
        }

        private string GetDescrizione()
        {

            string returnDescrizione = " Programma gratuito per il download degli sfondi giornalieri del motore di ricerca Bing.";
            return returnDescrizione;
        }

        private void lnlEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "mailto:emanuelemattei@email.it",
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
    }
}
