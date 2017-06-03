using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.Model
{
    class Lager
    {

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
        /// Eine Palette dem Palettenbestand des Lagers hinzufügen
        /// </summary>
        public void PaletteHinzufügen()
        {

        }

        /// <summary>
        /// Verkaufen einer Palette aus dem Palettenbestand
        /// </summary>
        public void PaletteVerkaufen()
        {

        }

        /// <summary>
        /// Zieht eine Palette aus dem Palettenbestand in ein anderes Lager ab
        /// </summary>
        /// <param name="lager"></param>
        public void PaletteAbziehen(Lager lager)
        {

        }

    }
}
