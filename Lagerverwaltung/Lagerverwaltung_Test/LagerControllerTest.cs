using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lagerverwaltung.Controller;

namespace Lagerverwaltung_Test
{
    [TestClass]
    public class LagerControllerTest
    {
        [TestMethod]
        public void DatenLadenTest()
        {
            LagerController lager = new LagerController("Köln");

            Assert.AreEqual("Köln", lager.Lager.Standort);
            Assert.AreEqual(20000, lager.Lager.Kapazität);
        }

        [TestMethod]
        public void PaletteEinkaufenTest()
        {
            LagerController lager = new LagerController("Köln");
            

        }
    }
}
