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





        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnScarica_Click(object sender, EventArgs e)
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
