using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Lupo
{
    partial class FrmInformazioni : Form
    {
        public FrmInformazioni()
        {
            InitializeComponent();
            this.Text = String.Format("Informazioni su {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Versione {0}", AssemblyVersion);
            // this.labelCopyright.Text = AssemblyCopyright;
            // this.labelCompanyName.Text = "Programma realizzato da Emanuele Mattei";
            this.labelCopyright.Text = "Per richieste, informazioni o altro, scrivere a emanuelemattei@email.it";
            this.labelCompanyName.Text = "Programma realizzato da Emanuele Mattei";
            this.textBoxDescription.Text = GetDescrizione();


        }

        #region Funzioni di accesso attributo assembly

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void FrmInformazioni_Load(object sender, EventArgs e)
        {
            //TEsto per descrizione
            string descrizione = "Programma gratuito per il download degli sfondi giornalieri del motore di ricerca Bing - Free program to download daily Bing search wallpapers";
            textBoxDescription.Text = descrizione;
            //textBoxDescription
            this.labelCopyright.Text = "Per richieste, informazioni o altro, scrivere a emanuelemattei@tutanota.com - For requests, information, or anything else, write to emanuelemattei@tutanota.com";
        }

        private string GetDescrizione()
        {

            string returnDescrizione = "Programma gratuito per il download degli sfondi giornalieri del motore di ricerca Bing - Free program to download daily Bing search wallpapers";
           // returnDescrizione = "Programma gratuito per la gestione delle organizzazioni non profit. Il software semplifica e vuole essere uno strumento di aiuto a tutte le organizzazioni di volontariato che si adoperano per finalità assistenziali, cultura e comunque non per lucro.  Uno strumento che si può ampliare anche in base alle richieste degli utilizzatori. L'utilizzo del software non comporta nulla nei confronti del suo realizzatore. Per maggiori informazioni o ampliamento chiamare il 339.1980065" + ringraziamenti;
            return returnDescrizione;
        }
        private void labelCopyright_Click(object sender, EventArgs e)
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

        private void labelCopyright_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void labelCopyright_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
