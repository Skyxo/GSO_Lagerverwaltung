using Lagerverwaltung.Model;
using Lagerverwaltung.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.Controller
{
    public class LagerController
    {

        /// <summary>
        /// Lagermodell
        /// </summary>
        public Lager Lager
        {
            get;
            private set;
        }

        /// <summary>
        /// Lager mit Daten befüllen
        /// </summary>
        /// <param name="standort"></param>
        public LagerController(string standort)
        {
            Lager = new Lager();
            Lager.Palettenbestand = new List<Palette>();

            DatenLaden(standort);
        }

        #region Inizialisierung
        /// <summary>
        /// Lädt alle Daten aus der Datenbank mithilfe des EntityFrameworks
        /// </summary>
        private void DatenLaden(string standort)
        {
            string query = 
                "SELECT LagerID, Standort, Kapazitaet " +
                "FROM lager " +
                "WHERE Standort = @Standort";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["Standort"] = standort;

            DataTable data = DatenUtils.DatenHolen(query, parameters);

            if (data.Rows.Count > 0)
            {
                Lager.LagerID = Int32.Parse(data.Rows[0]["LagerID"].ToString());
                Lager.Standort = data.Rows[0]["Standort"].ToString();
                Lager.Kapazität = Int32.Parse(data.Rows[0]["Kapazitaet"].ToString());

                PalettenbestandLaden();
            }
            else
            {
                throw new KeyNotFoundException("Lager nicht gefunden");
            }
        }

        /// <summary>
        /// Palettenbestand aus der Datenbank laden
        /// </summary>
        public void PalettenbestandLaden()
        {
            string query =
                "SELECT palette.PaletteID AS PaletteID, ProduktID, produkt.MaxEinheiten AS MaxEinheiten, produkt.Bezeichnung AS Bezeichnung, palette.Einheiten AS Einheiten " +
                "FROM paletten palette " + 
                "JOIN produkte produkt USING (ProduktID) " +
                "WHERE palette.LagerID = @LagerID";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["LagerID"] = Lager.LagerID;
            
            DataTable data = DatenUtils.DatenHolen(query, parameters);

            if (data.Rows.Count > 0)
            {

                foreach (DataRow row in data.Rows)
                {
                    Produkt produkt = new Produkt();
                    produkt.ProduktID = Int32.Parse(row["ProduktID"].ToString());
                    produkt.Bezeichnung = row["Bezeichnung"].ToString();
                    produkt.MaxEinheiten = Int32.Parse(row["MaxEinheiten"].ToString());

                    Palette palette = new Palette();
                    palette.PaletteID = Int32.Parse(row["PaletteID"].ToString());
                    palette.Einheiten = Int32.Parse(row["Einheiten"].ToString());
                    palette.Produkt = produkt;

                    Lager.Palettenbestand.Add(palette);
                }
            }
        }
        #endregion

        #region Akteure
        /// <summary>
        /// <see cref="PaletteHinzufügen(Palette, int, bool)"/>
        /// </summary>
        /// <param name="produktBezeichnung">Produktbezeichnung</param>
        /// <param name="produktEinheiten">Einheiten des Produkts auf der Palette</param>
        /// <param name="anzahl">Anzahl der Paletten</param>
        public void PaletteHinzufügen(string produktBezeichnung, int produktEinheiten, int anzahl)
        {
            Produkt produkt = new Produkt();
            produkt.Bezeichnung = produktBezeichnung;
            produkt.MaxEinheiten = produktEinheiten;

            Palette palette = new Palette();
            palette.Einheiten = produktEinheiten;
            palette.Produkt = produkt;

            PaletteHinzufügen(palette, anzahl);
        }

        /// <summary>
        /// <see cref="PaletteHinzufügen(Palette, int, bool)"/>
        /// </summary>
        /// <param name="palette">Palette</param>
        /// <param name="anzahl">Anzahl der Paletten</param>
        public void PaletteHinzufügen(Palette palette, int anzahl)
        {
            PaletteHinzufügen(palette, anzahl, true);
        }

        /// <summary>
        /// Eine Palette dem Palettenbestand des Lagers hinzufügen
        /// </summary>
        /// <param name="palette">Palette</param>
        /// <param name="anzahl">Anzahl der hinzuzufügenden Paletten</param>
        /// <param name="einheitenAusPalette">Übernimmt für die Einheiten der Palette die maximale Einheitenanzahl aus dem Produkt</param>
        public void PaletteHinzufügen(Palette palette, int anzahl, bool einheitenAusProdukt)
        {
            // Negative Anzahlen ausfiltern
            if (anzahl < 0)
            {
                throw new ArgumentOutOfRangeException("Es können keine negativen Palettenbestände hinzugefügt werden!");
            }

            // Zukünftigen Palettenbestand überprüfen
            else if (LagerVoll(anzahl))
            {
                throw new ArgumentOutOfRangeException("Lager hat nicht ausreichend Kapazitäten zur Verfügung!");
            }

            // Palette zum Bestand hinzufügen
            else
            {
                int produktID = ProduktEinbinden(palette.Produkt);
                
                string query =
                    "INSERT INTO paletten (LagerID, ProduktID, Einheiten) " +
                    "VALUES ";

                string teilQuery = "";
                for (int i = 0; i < anzahl; i++)
                {
                    teilQuery += ",(@LagerID, @ProduktID, @Einheiten) ";
                }
                teilQuery = teilQuery.Substring(1);
                query += teilQuery;

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("LagerID", Lager.LagerID);
                parameters.Add("ProduktID", produktID);
                parameters.Add("Einheiten", (einheitenAusProdukt ? palette.Produkt.MaxEinheiten : palette.Einheiten));

                DatenUtils.DatenHolen(query, parameters);

                Lager.Palettenbestand.Add(palette);
            }
        }

        /// <summary>
        /// <see cref="ProdukteVerkaufen(Produkt, int)"/>
        /// </summary>
        /// <param name="produktBezeichnung">Bezeichnung des Produkts</param>
        /// <param name="einheiten">Einheiten des Produkts</param>
        public void ProdukteVerkaufen(string produktBezeichnung, int einheiten)
        {
            Produkt produkt = new Produkt();
            produkt.Bezeichnung = produktBezeichnung;

            ProdukteVerkaufen(produkt, einheiten);
        }

        /// <summary>
        /// Verkaufen einer Palette aus dem Palettenbestand
        /// </summary>
        /// <param name="einheiten">Einheiten des Produkts</param>
        /// <param name="produkt">Produkt</param>
        public void ProdukteVerkaufen(Produkt produkt, int einheiten)
        {
            // Negative Einheiten prüfen
            if (einheiten < 0) {
                throw new ArgumentOutOfRangeException("Es können keine negativen Bestände verkauft werden!");
            }

            // Existiert die Einheiten in dem Lager?
            int einheitenProdukt = EinheitenProdukt(produkt);

            // Wie viele Paletten macht das?
            int anzahlPaletten = PalettenzahlBerechnen(einheiten, produkt.MaxEinheiten);
            int restPalette = RestEinheitenBerechnen(einheiten, produkt.MaxEinheiten);

            // Existenz des Produkts prüfen
            if (einheitenProdukt == 0)
            {
                throw new ArgumentOutOfRangeException("Produkt enthält in dem Lager keine Einheiten");
            }
            else if (einheitenProdukt < einheiten)
            {
                throw new ArgumentOutOfRangeException("Nicht ausreichend Kapazität an Produkte vorhanden");
            }

            // Bestand des Lagers prüfen
            if (LagerLeer(anzahlPaletten))
            {
                throw new ArgumentOutOfRangeException("Lager hat zu wenig Paletten zum Verkauf");
            }


            // Liste aller Paletten welche abgezogen werden sollen
            string query =
                "SELECT palette.PaletteID " +
                "FROM paletten palette " +
                "JOIN produkte produkt USING (ProduktID) " +
                "WHERE produkt.Bezeichnung = @ProduktBezeichnung " +
                "AND palette.LagerID = @LagerID " +
                "AND palette.Einheiten = @PaletteEinheiten " +
                "LIMIT @Limit ";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("ProduktBezeichnung", produkt.Bezeichnung);
            parameters.Add("LagerID", Lager.LagerID);
            parameters.Add("PaletteEinheiten", produkt.MaxEinheiten);
            parameters.Add("Limit", anzahlPaletten - 1);

            DataTable data = DatenUtils.DatenHolen(query, parameters);
            List<int> palettenIDs = new List<int>();

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    palettenIDs.Add(Int32.Parse(row["PaletteID"].ToString()));
                }
            }


            // Paletten aus dem Lager abziehen
            query =
                "DELETE FROM paletten " +
                "WHERE PaletteID IN (@PalettenIDs)";

            parameters = new Dictionary<string, object>();
            parameters.Add("PalettenIDs", string.Join(", ", palettenIDs));

            DatenUtils.DatenBearbeiten(query, parameters);


            // ID der ersten Palette finden
            query =
                "SELECT palette.PaletteID " +
                "FROM paletten palette " +
                "JOIN produkte produkt USING (ProduktID) " +
                "WHERE produkt.Bezeichnung = @ProduktBezeichnung " +
                "AND palette.LagerID = @LagerID " +
                "AND palette.Einheiten >= @PaletteEinheiten " +
                "LIMIT 1 ";

            parameters = new Dictionary<string, object>();
            parameters.Add("ProduktBezeichnung", produkt.Bezeichnung);
            parameters.Add("LagerID", Lager.LagerID);
            parameters.Add("PaletteEinheiten", restPalette);

            data = DatenUtils.DatenHolen(query, parameters);
            int paletteID = -1;
            
            if (data.Rows.Count > 0)
            {
                paletteID = Int32.Parse(data.Rows[0]["PaletteID"].ToString());

            }

            // Einheiten der letzten Palette bearbeiten
            if (paletteID >= 0)
            {
                query =
                    "UPDATE paletten " +
                    "SET Einheiten = Einheiten - @EinheitenAbzug " +
                    "WHERE PaletteID = @PaletteID";

                parameters = new Dictionary<string, object>();
                parameters.Add("EinheitenAbzug", restPalette);
                parameters.Add("PaletteID", paletteID);

                DatenUtils.DatenBearbeiten(query, parameters);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Es konnte keine Palette zum Bearbeiten gefunden werden");
            }

        }

        /// <summary>
        /// <see cref="ProduktVerschieben(Produkt, int, ref LagerController)"/>
        /// </summary>
        /// <param name="produktBezeichnung">Bezeichnung des Produkts</param>
        /// <param name="einheiten">Anzahl der Einheiten</param>
        /// <param name="lager">Ziellager</param>
        public void ProduktVerschieben(string produktBezeichnung, int einheiten, ref LagerController lager)
        {
            Produkt produkt = new Produkt();
            produkt.Bezeichnung = produktBezeichnung;

            ProduktVerschieben(produkt, einheiten, ref lager);
        }

        /// <summary>
        /// Produkt in ein anderes Lager verschieben
        /// </summary>
        /// <param name="produkt">Produkt</param>
        /// <param name="einheiten">Anzahl der Einheiten</param>
        /// <param name="lager">Ziellager</param>
        public void ProduktVerschieben(Produkt produkt, int einheiten, ref LagerController lager)
        {
            // Negative Einheiten prüfen
            if (einheiten < 0)
            {
                throw new ArgumentOutOfRangeException("Es können keine negativen Bestände verkauft werden!");
            }

            // Existiert die Einheiten in dem Lager?
            int einheitenProdukt = EinheitenProdukt(produkt);

            // Wie viele Paletten macht das?
            int anzahlPaletten = PalettenzahlBerechnen(einheiten, produkt.MaxEinheiten);
            int restPaletteAnzahl = RestEinheitenBerechnen(einheiten, produkt.MaxEinheiten);

            // Existenz des Produkts prüfen
            if (einheitenProdukt == 0)
            {
                throw new ArgumentOutOfRangeException("Produkt enthält in dem Lager keine Einheiten");
            }

            // Prüfen ob genügend Einheiten des Produktes verfügbar sind
            else if (einheitenProdukt < einheiten)
            {
                throw new ArgumentOutOfRangeException("Nicht ausreichend Kapazität an Produkte vorhanden");
            }

            // Bestand des Lagers prüfen
            else if (LagerLeer(anzahlPaletten))
            {
                throw new ArgumentOutOfRangeException("Lager hat zu wenig Paletten zum Verkauf");
            }

            // Bestand des Ziellagers prüfen
            if (lager.LagerVoll(anzahlPaletten))
            {
                throw new ArgumentOutOfRangeException("Das angegebene Lager hat nicht genügend Kapazitäten vorhanden");
            }


            // Produkt verkaufen
            ProdukteVerkaufen(produkt, einheiten);
            
            if (anzahlPaletten > 0 && einheiten == produkt.MaxEinheiten)
            {
                // Neue Palette mit gesuchten Produkt erstellen
                Palette palette = new Palette();
                palette.Einheiten = produkt.MaxEinheiten;
                palette.Produkt = produkt;

                // Volle Paletten dem Ziellager hinzufügen
                lager.PaletteHinzufügen(palette, anzahlPaletten - 1);
            }


            // Palette mit den restlichen Einheiten dem Ziellager hinzufügen
            if (restPaletteAnzahl > 0)
            {
                Palette restPalette = new Palette();
                restPalette.Einheiten = restPaletteAnzahl;
                restPalette.Produkt = produkt;

                lager.PaletteHinzufügen(restPalette, 1, false);
            }

            // [Ersetzt den Weg, nicht gefüllte Paletten zu finden, diese aufzufüllen und danach deren LagerID zu ändern]
            
        }
        #endregion

        #region Produkt Utilities
        /// <summary>
        /// Summe aller Einheiten eines Produktes aller Paletten im Lager
        /// </summary>
        /// <param name="produkt"></param>
        /// <returns></returns>
        public int EinheitenProdukt(Produkt produkt)
        {
            string query =
                "SELECT SUM(palette.Einheiten) AS einheitenSum " +
                "FROM paletten palette " +
                "JOIN produkte produkt USING (ProduktID) " +
                "WHERE produkt.Bezeichnung = @Bezeichnung " +
                "AND palette.LagerID = @LagerID " +
                "GROUP BY palette.Einheiten";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["Bezeichnung"] = produkt.Bezeichnung;
            parameters["LagerID"] = Lager.LagerID;


            DataTable data = DatenUtils.DatenHolen(query, parameters);

            if (data.Rows.Count > 0)
            {
                return Int32.Parse(data.Rows[1]["einheitenSum"].ToString());
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Produkt zur Produktlisten hinzufügen falls dieses nicht existiert
        /// </summary>
        /// <param name="produkt">Produkt welches zur Datenbank hinzugefügt werden soll</param>
        /// <returns>ProduktID des vorhandenen oder neuen Produkts</returns>
        private int ProduktEinbinden(Produkt produkt)
        {
            int produktID = -1;
            Produkt produktFund = ProduktFinden(produkt.Bezeichnung);

            // Produkt zur Liste hinzufügen
            if (produktFund == null)
            {
                string query =
                    "INSERT INTO produkte (Bezeichnung, MaxEinheiten) " +
                    "VALUES (@Bezeichnung, @MaxEinheiten)";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters["Bezeichnung"] = produkt.Bezeichnung;
                parameters["MaxEinheiten"] = produkt.MaxEinheiten;

                produktID = DatenUtils.DatenBearbeiten(query, parameters);
            }

            // ProduktID weitergeben
            else
            {
                produktID = produktFund.ProduktID;
            }

            return produktID;
        }

        /// <summary>
        /// Prüfe ob ein Produkt mit einer Bezeichnung existiert
        /// </summary>
        /// <param name="bezeichnung">Bezeichnung des Produkts zur Suche</param>
        /// <returns>Gefundenes Produkt aus der Produktliste</returns>
        public Produkt ProduktFinden(string bezeichnung)
        {
            string query =
                "SELECT ProduktID, Bezeichnung, MaxEinheiten " +
                "FROM produkte " +
                "WHERE Bezeichnung = @Bezeichnung " + 
                "LIMIT 1";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["Bezeichnung"] = bezeichnung;

            DataTable data = DatenUtils.DatenHolen(query, parameters);

            Produkt produkt = null;

            if (data.Rows.Count > 0)
            {
                produkt = new Produkt();

                produkt.ProduktID = Int32.Parse(data.Rows[0]["ProduktID"].ToString());
                produkt.Bezeichnung = data.Rows[0]["Bezeichnung"].ToString();
                produkt.MaxEinheiten = Int32.Parse(data.Rows[0]["MaxEinheiten"].ToString());
            }

            return produkt;
        }
        #endregion

        #region Utils (Berechnungen etc.)
        /// <summary>
        /// Kapazität wird überschritten
        /// </summary>
        /// <param name="anzahlPaletten">Anzahl der Paletten</param>
        /// <returns>Kapazität überschritten</returns>
        private bool LagerVoll(int anzahlPaletten)
        {
            return Lager.Palettenbestand.Count + anzahlPaletten > Lager.Kapazität;
        }

        /// <summary>
        /// Kapazität wird negativ
        /// </summary>
        /// <param name="anzahlPaletten"></param>
        /// <returns>Kapazität negativ</returns>
        private bool LagerLeer(int anzahlPaletten)
        {
            return Lager.Palettenbestand.Count - anzahlPaletten < 0;
        }

        /// <summary>
        /// Anzahl der Paletten berechnen
        /// </summary>
        /// <param name="einheiten"></param>
        /// <param name="max"></param>
        /// <returns>Anzahl der benötigten Paletten</returns>
        private int PalettenzahlBerechnen(int einheiten, int max)
        {
            double anzahl = ((double) einheiten) / ((double) max);

            return Convert.ToInt32(Math.Ceiling(anzahl));
        }

        /// <summary>
        /// Anzahl der Einheiten der letzten Paletten berechnen
        /// </summary>
        /// <param name="einheiten"></param>
        /// <param name="max"></param>
        /// <returns>Rest</returns>
        private int RestEinheitenBerechnen(int einheiten, int max)
        {
            double anzahl = ((double)einheiten) / ((double)max);
            double rest = anzahl - Math.Floor(anzahl);

            return Convert.ToInt32(rest * einheiten);
        }
        #endregion

    }
}
