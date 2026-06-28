using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.Design.AxImporter;

namespace Lupo
{
    public class Configurazione
    {
        //Percorso della cartella di configurazione
        private static readonly string PercorsoCartella = Path.Combine(
           Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Lupo");

        private static readonly string PercorsoCartellaFileConfigurazione = Path.Combine(PercorsoCartella, "Luposettings.json");


        public Configurazione()
        {



        }


        #region funzioni


        /// <summary>
        /// Rileva il percorso salvato della cartella dove scaricare i file di bing
        /// </summary>
        /// <returns></returns>
        public (string PercorsoFile, DateTime DataUltimoDownload) OttieniPercorso()
        {

            try
            {

                if (!File.Exists(PercorsoCartellaFileConfigurazione)) return ("", DateTime.MinValue);
                string FileJson = File.ReadAllText(PercorsoCartellaFileConfigurazione);
                var Opzioni = new JsonSerializerOptions { ReadCommentHandling = JsonCommentHandling.Skip };
                var PercorsoSalvato = JsonSerializer.Deserialize<Impostazioni>(FileJson, Opzioni);

                if (PercorsoSalvato != null)
                {

                    return (PercorsoSalvato.PercorsoCartellaFileBing, PercorsoSalvato.DataUltimoDownload);
                }


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }
            return ("", DateTime.MinValue);
        }


        public bool SalvaDati(string percorsoCartellaDownload, DateTime ultimoDownload)
        {
            bool esito = false;
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(PercorsoCartellaFileConfigurazione));
                Impostazioni impostazioniDaSalvare = new Impostazioni();
                var Opzioni = new JsonSerializerOptions { WriteIndented = true };
                impostazioniDaSalvare.PercorsoCartellaFileBing = percorsoCartellaDownload;
                impostazioniDaSalvare.DataUltimoDownload = ultimoDownload;

                string serializzoImpostaioni = JsonSerializer.Serialize(impostazioniDaSalvare, Opzioni);

                File.WriteAllText(PercorsoCartellaFileConfigurazione, serializzoImpostaioni);


            }
            catch (Exception ex)
            {

                Utility.MessaggioErrore(ex.Message);
            }


            return esito;

        }





        #endregion


    }

    class Impostazioni
    {
        /// <summary>
        /// Percorso 
        /// </summary>
        public string PercorsoCartellaFileBing { get; set; } = "";

        public DateTime DataUltimoDownload { get; set; }

    }





}
