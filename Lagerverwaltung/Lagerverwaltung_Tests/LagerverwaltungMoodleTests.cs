using Lagerverwaltung;
using Lagerverwaltung.Model;
using Lagerverwaltung.Model.Standort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lagerverwaltung_UnitTest
{
    [TestClass]
    class LagerverwaltungMoodleTests
    {

        [TestMethod]
        public void Test1()
        {
            Lager köln = new Köln();

            bestand palette = new bestand();
            palette.Bezeichnung = "Ein Moodle";
            palette.Einheiten = 24;

            köln.PaletteHinzufügen(palette, 500);

            köln.PaletteVerkaufen(palette, 500);

            // Leerne Palettenbestand prüfen
            Assert.AreEqual(0, köln.Palettenbestand);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Lager hat nicht ausreichend Kapazitäten zur Verfügung!")]
        public void Test2()
        {
            Lager köln = new Köln();
            Lager bonn = new Bonn();

            bestand palette = new bestand();
            palette.Bezeichnung = "Ein Moodle";
            palette.Einheiten = 24;

            // Paletten testweise hinzufügen
            köln.PaletteHinzufügen(palette, 5500);
            bonn.PaletteHinzufügen(palette, 10000);


            // Paletten in anderes Lager abziehen
            köln.PaletteVerkaufen(palette, 5500);
            bonn.PaletteVerkaufen(palette, 5500);

            // Prüfe ob sich der Palettenbestand trotzdem verändert hat
            Assert.AreEqual(10000, bonn.Palettenbestand);
            Assert.AreEqual(5500, köln.Palettenbestand);
        }

        [TestMethod]
        public void Test3()
        {
            Lager leverkusen = new Leverkusen();
            Lager köln = new Köln();

            bestand palette = new bestand();
            palette.Bezeichnung = "Ein Moodle";
            palette.Einheiten = 24;


            // Paletten testweise hinzufügen
            leverkusen.PaletteHinzufügen(palette, 4300);

            // Paletten nach Köln abziehen
            leverkusen.PaletteVerkaufen(palette, 4300);
            köln.PaletteHinzufügen(palette, 4300);

            // Palettenbestände prüfen
            Assert.AreEqual(0, leverkusen.Palettenbestand);
            Assert.AreEqual(4300, köln.Palettenbestand);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Es können keine negativen Palettenbestände hinzugefügt werden!")]
        public void Test4()
        {
            Lager köln = new Köln();

            bestand palette = new bestand();
            palette.Bezeichnung = "Ein Moodle";
            palette.Einheiten = 24;


            // Paletten testweise hinzufügen
            //köln.PaletteHinzufügen(palette, 1200);

            // Negativen Palettenbestand hinzufügen
            köln.PaletteHinzufügen(palette, -100);

            // Palettenbestand prüfen
            Assert.AreEqual(1200, köln.Palettenbestand);
        }

    }
}
