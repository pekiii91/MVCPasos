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
    
    public partial class tblPaso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPaso()
        {
            this.tblKorisniks = new HashSet<tblKorisnik>();
        }
    
        public int PasosID { get; set; }
        public string IzdajePU { get; set; }
        public string Drzava { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
        public int InformacijeOPasosu { get; set; }
        public int Uplata { get; set; }
        public int Gradjanin { get; set; }
        public int MaloletnoLice { get; set; }
        public int IzgubljenPasos { get; set; }
    
        public virtual tblGradjanin tblGradjanin { get; set; }
        public virtual tblInformacijeOPasosu tblInformacijeOPasosu { get; set; }
        public virtual tblIzgubljenPaso tblIzgubljenPaso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKorisnik> tblKorisniks { get; set; }
        public virtual tblMaloletnoLouse tblMaloletnoLouse { get; set; }
        public virtual tblUplata tblUplata { get; set; }
    }
}
