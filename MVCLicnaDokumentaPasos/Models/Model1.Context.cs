﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LicnaDokumentaPasosEntities : DbContext
    {
        public LicnaDokumentaPasosEntities()
            : base("name=LicnaDokumentaPasosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblGradjanin> tblGradjanins { get; set; }
        public virtual DbSet<tblInformacijeOPasosu> tblInformacijeOPasosus { get; set; }
        public virtual DbSet<tblIzdavanjePasosa> tblIzdavanjePasosas { get; set; }
        public virtual DbSet<tblIzgubljenPaso> tblIzgubljenPasos { get; set; }
        public virtual DbSet<tblKorisnik> tblKorisniks { get; set; }
        public virtual DbSet<tblMaloletnoLouse> tblMaloletnoLice { get; set; }
        public virtual DbSet<tblPaso> tblPasos { get; set; }
        public virtual DbSet<tblProduzetakPasosa> tblProduzetakPasosas { get; set; }
        public virtual DbSet<tblUplata> tblUplatas { get; set; }
        public virtual DbSet<vwGradjanin> vwGradjanins { get; set; }
        public virtual DbSet<vwIgubljenPaso> vwIgubljenPasos { get; set; }
        public virtual DbSet<vwInformacijeOPasosu> vwInformacijeOPasosus { get; set; }
        public virtual DbSet<vwIzdavanjePasosa> vwIzdavanjePasosas { get; set; }
        public virtual DbSet<vwKorisnik> vwKorisniks { get; set; }
        public virtual DbSet<vwMaloletnoLouse> vwMaloletnoLice { get; set; }
        public virtual DbSet<vwPaso> vwPasos { get; set; }
        public virtual DbSet<vwProduzetakPasosa> vwProduzetakPasosas { get; set; }
        public virtual DbSet<vwUplata> vwUplatas { get; set; }
    }
}
