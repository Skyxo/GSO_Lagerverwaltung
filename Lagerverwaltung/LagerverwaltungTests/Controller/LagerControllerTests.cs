﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lagerverwaltung.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung.Model;

namespace Lagerverwaltung.Controller.Tests
{
    [TestClass()]
    public class LagerControllerTests
    {

        [TestMethod()]
        public void LagerControllerTest()
        {
            LagerController lager = new LagerController("Köln");

            Assert.AreEqual(1, lager.Lager.LagerID);
            Assert.AreEqual("Köln", lager.Lager.Standort);
            Assert.AreEqual(20000, lager.Lager.Kapazität);
        }

        [TestMethod()]
        public void PaletteHinzufügenTest()
        {
            LagerController lager = new LagerController("Köln");

            Produkt produkt = new Produkt();
            produkt.Bezeichnung = "Gaffel Kölsch";
            produkt.MaxEinheiten = 24;

            Palette palette = new Palette();
            palette.Produkt = produkt;
            palette.Einheiten = 24;

            lager.PaletteHinzufügen(palette, 10);
        }

        [TestMethod()]
        public void ProdukteVerkaufenTest()
        {
            LagerController lager = new LagerController("Köln");

            Produkt produkt = new Produkt();
            produkt.Bezeichnung = "Gaffel Kölsch";
            produkt.MaxEinheiten = 24;

            lager.ProdukteVerkaufen(produkt, 25);
        }

        [TestMethod()]
        public void EinheitenProduktTest()
        {
            LagerController lager = new LagerController("Köln");

            Produkt produkt = new Produkt();
            produkt.Bezeichnung = "Gaffel Kölsch";
            produkt.MaxEinheiten = 24;

            int result = lager.EinheitenProdukt(produkt);

            Assert.AreNotEqual(0, result);
        }

    }
}