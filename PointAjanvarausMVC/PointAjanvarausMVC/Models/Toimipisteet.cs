//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PointAjanvarausMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Toimipisteet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Toimipisteet()
        {
            this.Hoitopaikat = new HashSet<Hoitopaikat>();
            this.Palvelut = new HashSet<Palvelut>();
        }
    
        public int Toimipiste_ID { get; set; }
        public string Toimipisteen_Nimi { get; set; }
        public Nullable<int> Hoitopaikka_ID { get; set; }
        public Nullable<int> Osoite_ID { get; set; }
        public Nullable<int> Puhelin_ID { get; set; }
        public Nullable<int> Huomio_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hoitopaikat> Hoitopaikat { get; set; }
        public virtual Hoitopaikat Hoitopaikat1 { get; set; }
        public virtual Huomiot Huomiot { get; set; }
        public virtual Osoite Osoite { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Palvelut> Palvelut { get; set; }
        public virtual Puhelin Puhelin { get; set; }
    }
}
