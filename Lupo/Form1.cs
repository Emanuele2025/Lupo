
using SkiaSharp;
using System.Runtime.InteropServices;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

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
            try
            {
                //Rilevo il percorso
                percorsoCartella = RilevaPercorsoFileImpostazioni();
                 
                if (!string.IsNullOrWhiteSpace(percorsoCartella))
                {
                    TxtPercorsoCartella.Text = percorsoCartella;
                }
                if (string.IsNullOrWhiteSpace(percorsoCartella))
                {
                    return;
                }

                var files = new DirectoryInfo(percorsoCartella).GetFiles()
                    .Select(file => new
                    {
                        NomeFile = file.Name,
                        DataCreazione = file.CreationTime
                    })
                    .Where(file => file.NomeFile.EndsWith(".webp", StringComparison.OrdinalIgnoreCase))
                    .OrderByDescending(file => file.DataCreazione)
                    .ToList();

                List<string> fileNames = files.Select(f => f.NomeFile).ToList();
                lsbListaFile.DataSource = fileNames;

                // Se ci sono file, seleziona il primo e carica l'immagine
                if (fileNames.Count > 0)
                {
                    lsbListaFile.SelectedIndex = 0;
                    CaricaImmagineDaListBox();
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show("Errore: " + ex.Message, "Lupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Si è verificato un errore: {ex.Message}","Lupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //            CaricaImmagineIniziale();

        }

        private async void BtnScarica_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtPercorsoCartella.Text.Trim() == "")
                {

                    MessageBox.Show("Impostare un percorso dove salvare l'immagine.", "Lupo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrWhiteSpace(percorsoCartella))
                {
                    percorsoCartella = TxtPercorsoCartella.Text.Trim();
                }
                if (!string.IsNullOrWhiteSpace(TxtPercorsoCartella.Text.Trim()) && TxtPercorsoCartella.Text != percorsoCartella)
                {
                    //Messaggio si vuole salvare il nuovo percorso?
                }

               

                await  DownloadImmagine(percorsoCartella);
                string cartella = percorsoCartella;
                var files = new DirectoryInfo(cartella).GetFiles()
                    .Select(file => new
                    {
                        NomeFile = file.Name,
                        DataCreazione = file.CreationTime
                    })
                    .Where(file => file.NomeFile.EndsWith(".webp", StringComparison.OrdinalIgnoreCase))
                    .OrderByDescending(file => file.DataCreazione)
                    .ToList();

                List<string> fileNames = files.Select(f => f.NomeFile).ToList();
                lsbListaFile.DataSource = fileNames;

                // Se ci sono file, seleziona il primo e carica l'immagine
                if (fileNames.Count > 0)
                {
                    lsbListaFile.SelectedIndex = 0;
                    CaricaImmagineDaListBox();
                }


                if (!string.IsNullOrWhiteSpace(percorsoCartella))
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


        //TODO: Finire, salva il dato, solo se il percorso è diverso dal precedente (in questo caso visualizzo un messaggio) o se è vuoto, ancora non inizializzato 
        private void SalvaPercorso(string percorso)
        {
            try
            {
                bool esito = new Configurazione().SalvaDati(percorso, DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore:" + ex.Message, "Lupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        /// <summary>
        /// Effettua il download dell'immagine.
        /// </summary>
        /// <param name="percorsoSalvataggio"></param>
        /// <returns></returns>
        static async Task DownloadImmagine(string percorsoSalvataggio)
        {
            //Percorso di Bing dove estrapolare l'immagine
            string bingApiUrl = "https://www.bing.com/HPImageArchive.aspx?format=js&idx=0&n=1&mkt=it-IT";
            //string filePath = Path.Combine("C:\\Varie\\", "bing_wallpaper4.webp");
            //Richiesta http
            using HttpClient client = new HttpClient();

            try
            {
                //Rilevo codice html per la gestione JSON
                string json = await client.GetStringAsync(bingApiUrl);

                //Estraggo il nome dell'immagine ed il percorso dell'immagine bing
                using JsonDocument doc = JsonDocument.Parse(json);
                string urlBase = doc.RootElement
                    .GetProperty("images")[0]
                    .GetProperty("urlbase")
                    .GetString();

                //Nome del file da salvare
                string nomeFile = urlBase?.Split(".").Length > 1 ? urlBase.Split(".")[1] : urlBase;
                //rileva il sito preciso con l'immagine
                string imageUrl = $"https://www.bing.com{urlBase}_1920x1080.webp";
                nomeFile = percorsoSalvataggio + "\\" + nomeFile + ".webp";

                //Scarico l'immagine in array di byte
                byte[] imageBytes = await client.GetByteArrayAsync(imageUrl);
                await File.WriteAllBytesAsync(nomeFile, imageBytes);
                //bool result = SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, nomeFile, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
                //if (!result)
                //{
                //    throw new Exception("Impossibile impostare l'immagine come sfondo del desktop.");
                //}
                MessageBox.Show("File salvato con successo.", "Lupo", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore:" + ex.Message, "Lupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

  

        /// <summary>
        /// Rileva dalle impsostazioni il percorso dell'ultimo salvataggio
        /// </summary>
        /// <returns></returns>
        private string RilevaPercorsoFileImpostazioni()
        {
            string percorsoRilevato = "";
            try
            {
                percorsoRilevato = new Configurazione().OttieniPercorso().PercorsoFile;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore:" + ex.Message, "Lupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return percorsoRilevato;




        }

        //Per caricare l'immagine di tipo webp nel controllo listbox
        private void CaricaImmagineDaListBox()
        {
            string percorso = "C:\\Varie\\" + lsbListaFile.SelectedItem?.ToString();
            using (var data = File.OpenRead(percorso))
            {
                //Creo un oggetto skiaBitmap dallo stream dati
                var skiaBitmap = SKBitmap.Decode(data);

                //Converto SKBitmap in System.Drawing.Image
                using (var ms = new MemoryStream())
                {
                    //Imposto nel MemoryStream l'oggetto  SKBitmap come PNG 
                    using (var skiaImage = SKImage.FromBitmap(skiaBitmap))
                    {
                        skiaImage.Encode(SKEncodedImageFormat.Png, 100).SaveTo(ms);
                    }
                    ms.Position = 0; // Reset stream position

                    //Visualizzo l'immagine nel PictureBox
                    pcbAnteprima.Image = System.Drawing.Image.FromStream(ms);
                }
            }
        }

        private void BtnCercaCartella_Click(object sender, EventArgs e)
        {
            try
            {
                //Apro la finestra di dialogo per la selezione della cartella
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "Seleziona la cartella di destinazione per salvare l'immagine di bing";
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Imposto il percorso selezionato nella casella di testo
                        TxtPercorsoCartella.Text = folderBrowserDialog.SelectedPath;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore:" + ex.Message, "Lupo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void lsbListaFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CaricaImmagineDaListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore:" + ex.Message, "Lupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void mniImpostaComeSfondo_Click(object sender, EventArgs e)
        {

        }

        private void cmsMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = (pcbAnteprima.Image == null);
        }
    }
}
