using Lagerverwaltung.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagerverwaltung
{
    public partial class LagerView : Form
    {
        public LagerView()
        {
            InitializeComponent();
        }

        #region Tests
        /// <summary>
        /// ComboBox Lagerauswahl
        /// </summary>
        private void LagerAusgewählt()
        {
            if (lagerAuswahlComboBox.SelectedIndex == -1)
            {
                throw new ArgumentOutOfRangeException("Bitte wähle ein Lager aus!");
            }
        }

        /// <summary>
        /// Produkteingeabe
        /// </summary>
        private void ProduktEingabe()
        {
            if (string.IsNullOrEmpty(produktBezeichnungTextBox.Text) || string.IsNullOrEmpty(produktEinheitenTextBox.Text))
            {
                throw new ArgumentOutOfRangeException("Bitte fülle die Daten für ein Produkt aus.");
            }
        }

        /// <summary>
        /// Zeillager
        /// </summary>
        private void ZiellagerAusgewählt()
        {
            if (zeilLagerAuswahlComboBox.SelectedIndex != -1)
            {
                throw new ArgumentOutOfRangeException("Bitte wähle ein Ziellager für das Verschieben aus.");
            }
        }
        #endregion


        #region Events
        /// <summary>
        /// Palette einkaufen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PalettenEinkaufenButton_Click(object sender, EventArgs e)
        {
            try
            {
                LagerAusgewählt();
                ProduktEingabe();

                LagerController lager = new LagerController(lagerAuswahlComboBox.SelectedText);

                lager.PaletteHinzufügen(produktBezeichnungTextBox.Text, Int32.Parse(produktEinheitenTextBox.Text), Int32.Parse(palettenAnzahlTextBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Paletten wurden eingekauft.");
            }
        }

        /// <summary>
        /// Palette verkaufen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void produktVerkaufenButton_Click(object sender, EventArgs e)
        {
            try
            {
                LagerAusgewählt();
                ProduktEingabe();

                LagerController lager = new LagerController(lagerAuswahlComboBox.SelectedText);

                lager.ProdukteVerkaufen(produktBezeichnungTextBox.Text, Int32.Parse(produktEinheitenTextBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Produkt wurde verkauft.");
            }
        }

        /// <summary>
        /// Palette verschieben
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void produktVerschiebenButton_Click(object sender, EventArgs e)
        {
            try
            {
                LagerAusgewählt();
                ProduktEingabe();
                ZiellagerAusgewählt();

                LagerController lager = new LagerController(lagerAuswahlComboBox.SelectedText);
                LagerController zielLager = new LagerController(zeilLagerAuswahlComboBox.SelectedText);

                lager.ProduktVerschieben(produktBezeichnungTextBox.Text, Int32.Parse(produktEinheitenTextBox.Text), ref zielLager);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Produkt wurde verschoben.");
            }
        }
        #endregion

    }
}
