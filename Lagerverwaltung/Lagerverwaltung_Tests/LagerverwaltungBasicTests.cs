using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lagerverwaltung.Model.Standort;
using Lagerverwaltung.Model;

namespace Lagerverwaltung_UnitTest
{
    [TestClass]
    public class LagerverwaltungBasicTests
    {

        [TestMethod]
        public void PalettenHinzufügen()
        {
            Lager köln = new Köln();

            köln.PaletteHinzufügen(200);

            Assert.AreEqual(20011, köln.Palettenbestand);
        }

        [TestMethod]
        public void PalettenVerkaufen()
        {
            Lager leverkusen = new Leverkusen();
            leverkusen.PaletteHinzufügen(3991);

            leverkusen.PaletteVerkaufen(222);

            Assert.AreEqual(3991 - 222, leverkusen.Palettenbestand);
        }

        [TestMethod]
        public void PalettenAbziehen()
        {
            Lager bonn = new Bonn();
            Lager köln = new Köln();

            bonn.PaletteHinzufügen(2938);
            köln.PaletteHinzufügen(221);

            bonn.PaletteAbziehen(332, ref köln);

            Assert.AreEqual(2938 - 332, bonn.Palettenbestand);
            Assert.AreEqual(221 + 332, köln.Palettenbestand);
        }

    }
}
