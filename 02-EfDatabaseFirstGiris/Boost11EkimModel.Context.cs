﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _02_EfDatabaseFirstGiris
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Boost11EkimDbEntities : DbContext
    {
        public Boost11EkimDbEntities()
            : base("name=Boost11EkimDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bolge> Bolgeler { get; set; }
        public virtual DbSet<Hobi> Hobiler { get; set; }
        public virtual DbSet<IletisimBilgileri> IletisimBilgileri { get; set; }
        public virtual DbSet<Ogrenci> Ogrenciler { get; set; }
        public virtual DbSet<Sehir> Sehirler { get; set; }
        public virtual DbSet<Universite> Universiteler { get; set; }
    }
}
