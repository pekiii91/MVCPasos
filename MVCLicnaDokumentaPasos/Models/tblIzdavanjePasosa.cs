//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCLicnaDokumentaPasos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblIzdavanjePasosa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblIzdavanjePasosa()
        {
            this.tblInformacijeOPasosus = new HashSet<tblInformacijeOPasosu>();
        }
    
        public int IzdavanjePasosaID { get; set; }
        public string LicnaKarta { get; set; }
        public string Fotografija { get; set; }
        public string IzvodMaticneKnjigeRodjenih { get; set; }
        public string UverenjeODrzavljanstvu { get; set; }
        public string UplataZaPasos { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInformacijeOPasosu> tblInformacijeOPasosus { get; set; }
    }
}
