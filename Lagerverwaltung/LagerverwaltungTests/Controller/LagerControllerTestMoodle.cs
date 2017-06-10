using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lagerverwaltung.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung.Model;

namespace LagerverwaltungTests.Controller
{
    [TestClass]
    class LagerControllerTestMoodle
    {

        [TestMethod]
        public void Test1()
        {
            LagerController lager = new LagerController("Köln");

            int lagerBestand = lager.Lager.Palettenbestand.Count;

            Produkt produkt = new Produkt();
            produkt.Bezeichnung = "Fassbrause";
            produkt.MaxEinheiten = 32;

            Palette palette = new Palette();
            palette.Produkt = produkt;
            palette.Einheiten = 32;

            lager.PaletteHinzufügen(palette, 500);

            lager.ProdukteVerkaufen(produkt, 500 * 32);

            // Palettenbestand prüfen
            Assert.AreEqual(lagerBestand, lager.Lager.Palettenbestand.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Lager hat nicht ausreichend Kapazitäten zur Verfügung!")]
        public void Test2()
        {
            LagerController köln = new LagerController("Köln");
            LagerController bonn = new LagerController("Bonn");

            int lagerBestandKöln = köln.Lager.Palettenbestand.Count;
            int lagerBestandBonn = bonn.Lager.Palettenbestand.Count;

            Produkt produkt = new Produkt();
            produkt.Bezeichnung = "Fassbrause";
            produkt.MaxEinheiten = 32;

            Palette palette = new Palette();
            palette.Produkt = produkt;
            palette.Einheiten = 32;

            köln.PaletteHinzufügen(palette, 5500);
            bonn.PaletteHinzufügen(palette, 10000);

            // Paletten in anderes Lager abziehen
            köln.ProduktVerschieben(produkt, 5500 * 32, ref bonn);

            // Prüfe ob sich der Palettenbestand trotzdem verändert hat
            Assert.AreEqual(10000, bonn.Lager.Palettenbestand.Count);
            Assert.AreEqual(5500, köln.Lager.Palettenbestand.Count);
        }

        [TestMethod]
        public void Test3()
        {
            LagerController leverkusen = new LagerController("Leverkusen");
            LagerController köln = new LagerController("Köln");

            int lagerBestandLeverkusen = leverkusen.Lager.Palettenbestand.Count;
            int lagerBestandKöln = köln.Lager.Palettenbestand.Count;

            Produkt produkt = new Produkt();
            produkt.Bezeichnung = "Fassbrause";
            produkt.MaxEinheiten = 32;

            Palette palette = new Palette();
            palette.Produkt = produkt;
            palette.Einheiten = 32;

            // Paletten testweise hinzufügen
            leverkusen.PaletteHinzufügen(palette, 4300);

            // Paletten nach Köln abziehen
            leverkusen.ProduktVerschieben(produkt, 4300 * 32, ref köln);

            // Palettenbestände prüfen
            Assert.AreEqual(lagerBestandLeverkusen, leverkusen.Lager.Palettenbestand.Count);
            Assert.AreEqual(lagerBestandKöln + 4300, köln.Lager.Palettenbestand.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Es können keine negativen Palettenbestände hinzugefügt werden!")]
        public void Test4()
        {
            LagerController köln = new LagerController("Köln");

            int lagerBestandKöln = köln.Lager.Palettenbestand.Count;

            Produkt produkt = new Produkt();
            produkt.Bezeichnung = "Fassbrause";
            produkt.MaxEinheiten = 32;

            Palette palette = new Palette();
            palette.Produkt = produkt;
            palette.Einheiten = 32;

            // Paletten testweise hinzufügen
            köln.PaletteHinzufügen(palette, 1200);

            // Negativen Palettenbestand hinzufügen
            köln.PaletteHinzufügen(palette, -100);

            // Palettenbestand prüfen
            Assert.AreEqual(lagerBestandKöln, köln.Lager.Palettenbestand.Count);
        }


    }
}
