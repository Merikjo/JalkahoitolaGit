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
    
    public partial class Henkilokunta
    {
        public int Henkilokunta_ID { get; set; }
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Katuosoite { get; set; }
        public string Postinumero { get; set; }
        public string Postitoimipaikka { get; set; }
        public string Henkilotunnus { get; set; }
        public string Puhelinnumero_1 { get; set; }
        public string Sahkoposti { get; set; }
        public string Huomiot { get; set; }
        public Nullable<int> Osoite_id { get; set; }
        public Nullable<int> Huomio_id { get; set; }
        public Nullable<int> Puhelin_id { get; set; }
    
        public virtual Osoite Osoite { get; set; }
        public virtual Puhelin Puhelin { get; set; }
        public virtual Huomiot Huomiot1 { get; set; }
    }
}
