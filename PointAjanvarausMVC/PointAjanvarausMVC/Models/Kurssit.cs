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
    
    public partial class Kurssit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kurssit()
        {
            this.Rekisterointi2 = new HashSet<Rekisterointi>();
        }
    
        public int Kurssi_ID { get; set; }
        public string Kurssinimike { get; set; }
        public string Opintopisteet { get; set; }
        public Nullable<int> Rekisterointi { get; set; }
    
        public virtual Rekisterointi Rekisterointi1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rekisterointi> Rekisterointi2 { get; set; }
    }
}
