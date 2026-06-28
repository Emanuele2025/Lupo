using System;
using System.Collections.Generic;
using System.Text;

namespace Lupo
{

    /// <summary>
    /// Classe per la gestione delle funzionalità comuni
    /// </summary>
    public static class Utility
    {

        /// <summary>
        /// Messaggio informativo
        /// </summary>
        /// <param name="testo"></param>
        public static void MessaggioInfo(string testo)
        {
            MessageBox.Show(testo, "Lupo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// MEssaggio di errore
        /// </summary>
        /// <param name="test"></param>
        public static void MessaggioErrore(string testo)
        {
            MessageBox.Show(testo, "Lupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Visualizza un messaggio per cancellare il record
        /// </summary>
        /// <returns>Restituisce SI se è stata scelta la volontà di cancellare record</returns>
        public static bool CancellaRecord()
        {
            return MessageBox.Show("Si è certi di voler eliminare il record selezionato?", "Lupo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
        }
        /// <summary>
        /// Messaggio di scelta si e no generico
        /// </summary>
        /// <param name="testo"></param>
        /// <returns></returns>
        public static bool MessaggioSiNo(string testo)
        {
            return MessageBox.Show(testo, "Lupo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
        }






    }
}
