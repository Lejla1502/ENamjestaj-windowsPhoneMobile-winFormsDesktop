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
    
    public partial class esp_Proizvodi_SelectById_Result
    {
        public int ProizvodID { get; set; }
        public decimal Cijena { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public bool Statuss { get; set; }
        public int VrstaProizvoda { get; set; }
        public byte[] SlikaThumb { get; set; }
        public byte[] Slika { get; set; }
        public int TipID { get; set; }
        public int ModelID { get; set; }
        public string VrstaProizvodaNaziv { get; set; }
        public Nullable<decimal> ProsjecnaOcjena { get; set; }
        public string Model { get; set; }
        public string Tip { get; set; }
    }
}
