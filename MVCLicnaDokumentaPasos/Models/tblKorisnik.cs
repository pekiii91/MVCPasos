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
    
    public partial class tblKorisnik
    {
        public int KorsinikID { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public int Pasos { get; set; }
    
        public virtual tblPaso tblPaso { get; set; }
    }
}
