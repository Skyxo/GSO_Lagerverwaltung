//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lagerverwaltung
{
    using System;
    using System.Collections.Generic;
    
    public partial class lager
    {
        public lager()
        {
            this.bestand = new HashSet<bestand>();
        }
    
        public int LagerID { get; set; }
        public string Standort { get; set; }
        public int Kapazitaet { get; set; }
    
        public virtual ICollection<bestand> bestand { get; set; }
    }
}
