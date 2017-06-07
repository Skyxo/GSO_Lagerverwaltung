using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lagerverwaltung.Model.Standort;
using Lagerverwaltung.Model;
using Lagerverwaltung;

namespace Lagerverwaltung_UnitTest
{
    [TestClass]
    public class LagerverwaltungBasicTests
    {

        [TestMethod]
        public void PalettenHinzufügen()
        {
            Lager köln = new Köln();

            bestand palette = new bestand();
            palette.Bezeichnung = "Fassbrause";
            palette.Einheiten = 24;

            köln.PaletteHinzufügen(palette, 10);

            Assert.AreEqual(10, köln.Palettenbestand);
        }

        [TestMethod]
        public void PalettenVerkaufen()
        {
            Lager leverkusen = new Leverkusen();

            bestand palette = new bestand();
            palette.Bezeichnung = "Fassbrause";
            palette.Einheiten = 24;

            leverkusen.PaletteVerkaufen(palette, 10);

            Assert.AreEqual(0, leverkusen.Palettenbestand);
        }

        [TestMethod]
        public void PalettenAbziehen()
        {
            Lager bonn = new Bonn();
            Lager köln = new Köln();

            bestand palette = new bestand();
            palette.Bezeichnung = "Fassbrause";
            palette.Einheiten = 24;

            bonn.PaletteHinzufügen(palette, 55);


            bonn.PaletteVerkaufen(palette, 35);
            köln.PaletteHinzufügen(palette, 35);


            Assert.AreEqual(55 - 35, bonn.Palettenbestand);
            Assert.AreEqual(35, köln.Palettenbestand);
        }

    }
}
