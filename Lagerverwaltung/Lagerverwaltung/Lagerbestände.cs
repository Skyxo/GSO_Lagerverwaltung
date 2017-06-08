using Lagerverwaltung.Controller;
using Lagerverwaltung.Model;
using System;
using System.Windows.Forms;

namespace Lagerverwaltung
{
    public partial class LagerbeständeForm : Form
    {

        #region Lager
        /// <summary>
        /// Kölner Lager
        /// </summary>
        public LagerController LagerKöln
        {
            get;
            private set;
        }

        /// <summary>
        /// Bonner Lager
        /// </summary>
        public LagerController LagerBonn
        {
            get;
            private set;
        }

        /// <summary>
        /// Leverkusener Lager
        /// </summary>
        public LagerController LagerLeverkusen
        {
            get;
            private set;
        }
        #endregion

        /// <summary>
        /// Form und Lager initialisieren
        /// </summary>
        public LagerbeständeForm()
        {
            InitializeComponent();

            LagerKöln = new LagerController("Köln");
            LagerBonn = new LagerController("Bonn");
            LagerLeverkusen = new LagerController("Leverkusen");
        }

        #region Prozesse
        /// <summary>
        /// Palette einkaufen
        /// </summary>
        /// <param name="anzahl">Anzahl der zu kaufenden Paletten</param>
        /// <param name="lager">Lager für die Paletten</param>
        private void PaletteEinkaufen(int anzahl, ref Lager lager)
        {
            try
            {
                // Palette dem Lager hinzufügen
                //lager.PaletteHinzufügen(anzahl);
            }
            catch (OverflowException ex)
            {
                // MessageBox mit Fehlermeldung anzeigen
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Paletten verkaufen
        /// </summary>
        /// <param name="anzahl">Anzahl der zu verkaufenden Paletten</param>
        /// <param name="lager">Lager für die Paletten</param>
        private void PaletteVerkaufen(int anzahl, ref Lager lager)
        {
            try
            {
                // Palette aus dem Lager verkaufen
                //lager.PaletteVerkaufen(anzahl);
            }
            catch (OverflowException ex)
            {
                // MessageBox mit Fehlermeldung anzeigen
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Paletten in ein anderes Lager abziehen
        /// </summary>
        /// <param name="anzahl">Anzahl der zu abziehenden Paletten</param>
        /// <param name="herkunftsLager">Herkunftslager</param>
        /// <param name="zielLager">Ziellager</param>
        private void PaletteAbziehen(int anzahl, ref Lager herkunftsLager, ref Lager zielLager)
        {
            try
            {
                // Palette aus dem Lager in ein anderes Lager abziehen
                //herkunftsLager.PaletteAbziehen(anzahl, ref zielLager);
            }
            catch (OverflowException ex)
            {
                // MessageBox mit Fehlermeldung anzeigen
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Utils
        /// <summary>
        /// Text in ein Integer umwandeln, mit abwicklung von Exceptions
        /// </summary>
        /// <param name="text">Umzuwandelnder Text</param>
        /// <returns>Umgewandeltes Integer</returns>
        private int TextZuInt(string text)
        {
            string textAnzahl = kölnAnzahlTextBox.Text;
            int anzahl = 0;

            try
            {
                // Text in Integer parsen
                anzahl = Int32.Parse(textAnzahl);
            }
            catch (Exception ex)
            {
                String message = ex.Message;

                // MessageBox mit Fehler anzeigen
                MessageBox.Show("Ungültige Anzahl. Nur Zahlen erlaubt!");
            }

            return anzahl;
        }
        #endregion

        #region Events

        #region Köln
        /// <summary>
        /// Paletten in das Kölner Lager einkaufen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kölnPaletteEinkaufenButton_Click(object sender, EventArgs e)
        {
            try
            {
                //LagerKöln.PaletteHinzufügen(TextZuInt(kölnAnzahlTextBox.Text));
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Einkauf erfolgreich!");
        }

        /// <summary>
        /// Paletten aus dem Kölner Lager verkaufen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kölnPaletteVerkaufenButton_Click(object sender, EventArgs e)
        {
            try
            {
                //LagerKöln.PaletteVerkaufen(TextZuInt(kölnAnzahlTextBox.Text));
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Verkauf erfolgreich!");
        }

        /// <summary>
        /// Paletten aus dem Kölner Lager abziehen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kölnPaletteAbziehenButton_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Bonn
        /// <summary>
        /// Paletten in das Bonner Lager einkaufen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bonnPaletteEinkaufenButton_Click(object sender, EventArgs e)
        {
            try
            {
                //LagerKöln.PaletteHinzufügen(TextZuInt(kölnAnzahlTextBox.Text));
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Einkauf erfolgreich!");
        }

        /// <summary>
        /// Paletten aus dem Bonner Lager verkaufen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bonnPaletteVerkaufenButton_Click(object sender, EventArgs e)
        {
            try
            {
                //LagerBonn.PaletteVerkaufen(TextZuInt(kölnAnzahlTextBox.Text));
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Verkauf erfolgreich!");
        }

        /// <summary>
        /// Paletten aus dem Bonner Lager abziehen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bonnPaletteAbziehenButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Leverkusen
        /// <summary>
        /// Paletten in das Leverkusener Lager einkaufen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leverkusenPaletteEinkaufenButton_Click(object sender, EventArgs e)
        {
            try
            {
                //LagerKöln.PaletteHinzufügen(TextZuInt(kölnAnzahlTextBox.Text));
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Einkauf erfolgreich!");
        }

        /// <summary>
        /// Paletten aus dem Leverkusener Lager verkaufen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leverkusenPaletteVerkaufenButton_Click(object sender, EventArgs e)
        {
            try
            {
                //LagerLeverkusen.PaletteVerkaufen(TextZuInt(kölnAnzahlTextBox.Text));
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Verkauf erfolgreich!");
        }

        /// <summary>
        /// Paletten aus dem Leverkusener Lager abziehen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leverkusenPaletteAbziehenButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            // Do nothing...
        }

        #endregion

    }
}
