using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.Model
{
    public class Palette
    {

        /// <summary>
        /// Palette ID
        /// </summary>
        public int PaletteID
        {
            get;
            set;
        }

        /// <summary>
        /// Produkts auf der Palette
        /// </summary>
        public Produkt Produkt
        {
            get;
            set;
        }

        /// <summary>
        /// Anzahl der Einheiten des Produkts auf einer Palette
        /// </summary>
        public int Einheiten
        {
            get;
            set;
        }

    }
}
