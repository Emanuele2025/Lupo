using System.Runtime.InteropServices;

namespace Lupo
{
    public partial class Form1 : Form
    {
        //Dichiarazione API per impostare lo sfondo del Desktop.
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        private const int SPI_SETDESKWALLPAPER = 20;
        private const int SPIF_UPDATEINIFILE = 0x01;
        private const int SPIF_SENDWININICHANGE = 0x02;

        //TODO: Aggiungere la funzione che salva e legge un file di configurazione dove si trova la cartella dove si trova no file, in modo da non doverla scegliere ogni volta.

        private string percorsoCartella = string.Empty;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Rilevo il percorso




        }

        private void BtnScarica_Click(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrWhiteSpace( percorsoCartella))
                {
                    SalvaPercorso(percorsoCartella);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore:" + ex.Message, "Lupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Funzioni varie

        private void SalvaPercorso(string percorso)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore:" + ex.Message, "Lupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }








        }
}
