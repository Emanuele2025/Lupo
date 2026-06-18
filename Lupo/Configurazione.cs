using System;
using System.Collections.Generic;
using System.Text;

namespace Lupo
{
    public class Configurazione
    {
        //Percorso della cartella di configurazione
     private static readonly string PercorsoCartella = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Lupo");

        private static readonly string PercorsoCartellaFileConfigurazione = Path.Combine(PercorsoCartella, "Luposettings.json");

        /// <summary>
        /// Percorso 
        /// </summary>
        public string PercorsoCartellaFileSFondi { get; set; }
        public Configurazione() { 
        
        
        
        }


        #region funzioni


        /// <summary>
        /// Rileva il percorso salvato della cartella dove scaricare i file di bing
        /// </summary>
        /// <returns></returns>
        public string OttieniPercorso()
        {
            string PercorsoCertellaDownload = "";
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore:" + ex.Message, "Lupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return PercorsoCertellaDownload;
        }



        #endregion


    }
}
