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
    
    public partial class tblInformacijeOPasosu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblInformacijeOPasosu()
        {
            this.tblPasos = new HashSet<tblPaso>();
        }
    
        public int InformacijeOPasosuID { get; set; }
        public string Email { get; set; }
        public int Telefon { get; set; }
        public int IzdavanjePasosa { get; set; }
        public int ProduzetakPasosa { get; set; }
    
        public virtual tblIzdavanjePasosa tblIzdavanjePasosa { get; set; }
        public virtual tblProduzetakPasosa tblProduzetakPasosa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPaso> tblPasos { get; set; }
    }
}
