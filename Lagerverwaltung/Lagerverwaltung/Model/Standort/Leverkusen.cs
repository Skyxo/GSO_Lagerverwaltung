using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.Model.Standort
{
    public class Leverkusen : Lager
    {

        /// <summary>
        /// Kapazität des Lagers festlegen und Palettenbestand auf 0 setzen
        /// </summary>
        public Leverkusen()
        {
            Kapazität = 15000;
            Palettenbestand = 0;
        }

    }
}
