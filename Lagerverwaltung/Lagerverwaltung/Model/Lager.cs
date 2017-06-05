using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.Model
{
    public class Lager
    {

        /// <summary>
        /// Maximale Kapazität von Paletten eines Lagers
        /// </summary>
        public int Kapazität
        {
            get;
            protected set;
        }

        /// <summary>
        /// Aktueller Palettenbestand
        /// </summary>
        public int Palettenbestand
        {
            get;
            protected set;
        }

        /// <summary>
        /// Eine Palette dem Palettenbestand des Lagers hinzufügen
        /// </summary>
        /// <param name="anzahl">Anzahl der hinzuzufügenden Paletten</param>
        public void PaletteHinzufügen(int anzahl)
        {
            // Negative Anzahlen ausfiltern
            if (anzahl < 0)
            {
                throw new ArgumentOutOfRangeException("Es können keine negativen Palettenbestände hinzugefügt werden!");
            }

            // Verfügbare Kapazität prüfen
            if (Palettenbestand == Kapazität)
            {
                // Fehler melden, dass das Lager bereits voll ist.
                throw new ArgumentOutOfRangeException("Lager ist voll");
            }
            // Zukünftigen Palettenbestand überprüfen
            else if (Palettenbestand + anzahl > Kapazität)
            {
                throw new ArgumentOutOfRangeException("Lager hat nicht ausreichend Kapazitäten zur Verfügung!");
            }
            else
            {
                // Palette zum Bestand hinzufügen
                Palettenbestand += anzahl;
            }
        }

        /// <summary>
        /// Verkaufen einer Palette aus dem Palettenbestand
        /// </summary>
        public void PaletteVerkaufen(int anzahl)
        {
            // Negative Anzahlen ausfiltern
            if (anzahl < 0)
            {
                throw new ArgumentOutOfRangeException("Es können keine negativen Palettenbestände verkauft werden!");
            }

            // Verfügbare Paletten prüfen
            if (Palettenbestand == 0)
            {
                // Fehler melden, dass das Lager leer ist.
                throw new ArgumentOutOfRangeException("Keine Paletten zum Verkauf");
            }
            // Zukünftigen Palettenbestand überprüfen
            else if (Palettenbestand - anzahl < 0)
            {
                throw new ArgumentOutOfRangeException("Lager hat zu wenig Paletten zum Verkauf");
            }
            else
            {
                // Palette vom Bestand abziehen
                Palettenbestand--;
            }
        }

        /// <summary>
        /// Zieht eine Palette aus dem Palettenbestand in ein anderes Lager ab
        /// </summary>
        /// <param name="lager"></param>
        public void PaletteAbziehen(int anzahl, ref Lager lager)
        {
            try
            {
                // Palette aus aktuellem Lager entfernen
                PaletteVerkaufen(anzahl);

                // Palette zum neuen Lager hinzufügen
                lager.PaletteHinzufügen(anzahl);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw ex;
            }
        }

    }
}
