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
    
    public partial class Varaus
    {
        public int Varaus_ID { get; set; }
        public Nullable<int> Hoitaja_ID { get; set; }
        public Nullable<int> Hoitopaikka_ID { get; set; }
        public Nullable<int> Asiakas_ID { get; set; }
        public Nullable<System.DateTime> Alku { get; set; }
        public Nullable<System.DateTime> Loppu { get; set; }
        public string Palvelun_nimi { get; set; }
        public Nullable<int> Palvelu_ID { get; set; }
    
        public virtual Asiakkaat Asiakkaat { get; set; }
        public virtual Hoitajat Hoitajat { get; set; }
        public virtual Hoitopaikat Hoitopaikat { get; set; }
        public virtual Palvelut Palvelut { get; set; }
    }
}
