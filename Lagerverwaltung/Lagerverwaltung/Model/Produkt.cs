using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.Model
{
    public class Produkt
    {

        /// <summary>
        /// Produkt ID
        /// </summary>
        public int ProduktID
        {
            get;
            set;
        }

        /// <summary>
        /// Bezeichnung
        /// </summary>
        public string Bezeichnung
        {
            get;
            set;
        }

        /// <summary>
        /// Maximale Einheiten pro Palette
        /// </summary>
        public int MaxEinheiten
        {
            get;
            set;
        }

    }
}
