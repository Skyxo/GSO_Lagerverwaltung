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
        public void PalettenHinzuf�gen()
        {
            Lager k�ln = new K�ln();

            k�ln.PaletteHinzuf�gen(200);

            Assert.AreEqual(20011, k�ln.Palettenbestand);
        }

        [TestMethod]
        public void PalettenVerkaufen()
        {
            Lager leverkusen = new Leverkusen();
            leverkusen.PaletteHinzuf�gen(3991);

            leverkusen.PaletteVerkaufen(222);

            Assert.AreEqual(3991 - 222, leverkusen.Palettenbestand);
        }

        [TestMethod]
        public void PalettenAbziehen()
        {
            Lager bonn = new Bonn();
            Lager k�ln = new K�ln();

            bonn.PaletteHinzuf�gen(2938);
            k�ln.PaletteHinzuf�gen(221);

            bonn.PaletteAbziehen(332, ref k�ln);

            Assert.AreEqual(2938 - 332, bonn.Palettenbestand);
            Assert.AreEqual(221 + 332, k�ln.Palettenbestand);
        }

    }
}
