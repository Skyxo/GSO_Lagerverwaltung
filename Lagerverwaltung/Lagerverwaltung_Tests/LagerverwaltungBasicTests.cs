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
        public void PalettenHinzuf�gen()
        {
            Lager k�ln = new K�ln();

            bestand palette = new bestand();
            palette.Bezeichnung = "Fassbrause";
            palette.Einheiten = 24;

            k�ln.PaletteHinzuf�gen(palette, 10);

            Assert.AreEqual(10, k�ln.Palettenbestand);
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
            Lager k�ln = new K�ln();

            bestand palette = new bestand();
            palette.Bezeichnung = "Fassbrause";
            palette.Einheiten = 24;

            bonn.PaletteHinzuf�gen(palette, 55);


            bonn.PaletteVerkaufen(palette, 35);
            k�ln.PaletteHinzuf�gen(palette, 35);


            Assert.AreEqual(55 - 35, bonn.Palettenbestand);
            Assert.AreEqual(35, k�ln.Palettenbestand);
        }

    }
}
