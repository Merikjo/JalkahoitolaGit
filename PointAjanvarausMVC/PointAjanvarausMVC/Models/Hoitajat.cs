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
    
    public partial class Hoitajat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hoitajat()
        {
            this.Event = new HashSet<Event>();
            this.Palvelut = new HashSet<Palvelut>();
            this.Rekisterointi = new HashSet<Rekisterointi>();
            this.Varauskalenteri = new HashSet<Varauskalenteri>();
            this.Varaus = new HashSet<Varaus>();
        }
    
        public int Hoitaja_ID { get; set; }
        public string Tunnus { get; set; }
        public string Etunimi { get; set; }
        public string Toinen_nimi { get; set; }
        public string Sukunimi { get; set; }
        public string Katuosoite { get; set; }
        public string Postinumero { get; set; }
        public string Postitoimipaikka { get; set; }
        public string Henkilotunnus { get; set; }
        public Nullable<System.DateTime> Aloituspvm { get; set; }
        public Nullable<System.DateTime> Valmistumispvm { get; set; }
        public Nullable<System.DateTime> Keskeytyspvm { get; set; }
        public string Tiedot_arkistoitu { get; set; }
        public Nullable<int> Huomio { get; set; }
        public Nullable<int> Osoite_id { get; set; }
        public Nullable<int> Puhelin_id { get; set; }
        public Nullable<int> Kurssi_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Event { get; set; }
        public virtual Osoite Osoite { get; set; }
        public virtual Puhelin Puhelin { get; set; }
        public virtual Huomiot Huomiot { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Palvelut> Palvelut { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rekisterointi> Rekisterointi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Varauskalenteri> Varauskalenteri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Varaus> Varaus { get; set; }
    }
}
