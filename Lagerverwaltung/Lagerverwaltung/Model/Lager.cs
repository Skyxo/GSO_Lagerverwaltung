using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.Model
{
    public class Lager
    {

        /// <summary>
        /// Lager ID
        /// </summary>
        public int LagerID
        {
            get;
            set;
        }

        /// <summary>
        /// Standort des Lagers
        /// </summary>
        public string Standort
        {
            get;
            set;
        }

        /// <summary>
        /// Maximale Kapazität von Paletten eines Lagers
        /// </summary>
        public int Kapazität
        {
            get;
            set;
        }

        /// <summary>
        /// Aktueller Palettenbestand
        /// </summary>
        public List<Palette> Palettenbestand
        {
            get;
            set;
        }

    }
}
