using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.Model.Standort
{
    class Köln : Lager
    {

        /// <summary>
        /// Kapazität des Lagers festlegen und Palettenbestand auf 0 setzen
        /// </summary>
        public Köln()
        {
            Kapazität = 20000;
            Palettenbestand = 0;
        }

    }
}
