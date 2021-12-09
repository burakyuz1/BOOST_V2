//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Ogrenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ogrenci()
        {
            this.Ogrenciler1 = new HashSet<Ogrenci>();
            this.Hobiler = new HashSet<Hobi>();
        }
    
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public Nullable<int> UniversiteId { get; set; }
        public Nullable<int> DogumYeriId { get; set; }
        public Nullable<int> LiderId { get; set; }
    
        public virtual IletisimBilgileri IletisimBilgileri { get; set; }
        public virtual Sehir Sehirler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ogrenci> Ogrenciler1 { get; set; }
        public virtual Ogrenci Ogrenciler2 { get; set; }
        public virtual Universite Universiteler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hobi> Hobiler { get; set; }
    }
}
