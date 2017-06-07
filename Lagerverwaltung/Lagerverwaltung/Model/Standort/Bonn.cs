using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.Model.Standort
{
    public class Bonn : Lager
    {

        /// <summary>
        /// Kapazität des Lagers festlegen und Palettenbestand auf 0 setzen
        /// </summary>
        public Bonn()
        {
            Standort = "Bonn";

            DatenLaden();
        }

    }
}
