//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eProdajaNamjestaja_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zaposlenici
    {
        public int ZaposlenikID { get; set; }
        public Nullable<System.DateTime> DatumRegistracije { get; set; }
        public string KorisnickoIme { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool Statuss { get; set; }
        public int UlogaID { get; set; }
    }
}
