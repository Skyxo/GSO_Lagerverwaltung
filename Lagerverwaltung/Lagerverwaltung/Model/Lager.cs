using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.Model
{
    public class Lager
    {

        private string connectionString = "host=localhost;user=root;database=lagerverwaltung"

        /// <summary>
        /// Lager ID
        /// </summary>
        public int LagerID
        {
            get;
            protected set;
        }

        /// <summary>
        /// Standort des Lagers
        /// </summary>
        public string Standort
        {
            get;
            protected set;
        }

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
        /// Lädt alle Daten aus der Datenbank mithilfe des EntityFrameworks
        /// </summary>
        protected void DatenLaden()
        {
            LagerverwaltungEntities entities = new LagerverwaltungEntities();

            // LINQ Abfrage aller Lager mit einem Standort
            IQueryable<lager> lagerListe = from l in entities.lager
                                      where l.Standort == Standort
                                      select l;

            // Erstes Objekt aus der Abfrage auslesen
            lager lager = lagerListe.FirstOrDefault();

            if (lager != null)
            {
                // Eigenschaften sichern
                LagerID = lager.LagerID;
                Standort = lager.Standort;
                Kapazität = lager.Kapazitaet;

                // Palettenbestand auslesen
                Palettenbestand = (from p in entities.bestand
                                   where p.LagerID == LagerID
                                   select p).Count();
            }
            else
            {
                throw new Exception("Lager konnte nicht gefunden werden");
            }


        }

        /// <summary>
        /// Eine Palette dem Palettenbestand des Lagers hinzufügen
        /// </summary>
        /// <param name="palette">Palette</param>
        /// <param name="anzahl">Anzahl der hinzuzufügenden Paletten</param>
        public void PaletteHinzufügen(Palette palette, int anzahl)
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

                LagerverwaltungEntities entities = new LagerverwaltungEntities();

                // Anzahl der Paletten zum Bestand hinzufügen
                for (int i = 0; i < anzahl; i++)
                {
                    palette.LagerID = LagerID;
                    entities.bestand.Add(palette);
                }

                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Verkaufen einer Palette aus dem Palettenbestand
        /// </summary>
        public void PaletteVerkaufen(Palette palette, int anzahl)
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
                Palettenbestand -= anzahl;

                LagerverwaltungEntities entities = new LagerverwaltungEntities();

                // Anzahl der Paletten zum Bestand hinzufügen
                for (int i = 0; i < anzahl; i++)
                {
                    palette.LagerID = LagerID;
                    entities.bestand.Remove(palette);
                }

                entities.SaveChanges();
            }
        }

    }
}
