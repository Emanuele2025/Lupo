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
            //<a target="_blank" href="https://icons8.com/icon/13903/close-window">Chiudi La Finestra</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>
            //<a target="_blank" href="https://icons8.com/icon/63308/info">Info</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>
            //<a target="_blank" href="https://icons8.com/icon/21339/download">Download</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>
            LblDescrizione.Text = GetDescrizione();
            label6.Text += " For info or anything else, get in touch with Emanuele at 339.1980065 or by email:";
        }

        
        /// <summary>
        /// Fornisce la descrizione del programma
        /// </summary>
        /// <returns></returns>
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
                Utility.MessaggioErrore("Impossibile aprire il programma di posta elettronica: " + ex.Message);

            }
        }

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LnkIcon_Click(object sender, EventArgs e)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "https://icons8.it/",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Impossibile aprire il sito: " + ex.Message);

            }
        }

        private void LnkIcon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "https://icons8.it/",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Impossibile aprire il sito: " + ex.Message);

            }
        }
    }
}
