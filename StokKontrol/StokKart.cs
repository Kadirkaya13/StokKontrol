//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokKontrol
{
    using System;
    using System.Collections.Generic;
    
    public partial class StokKart
    {
        public int Id { get; set; }
        public string StokKodu { get; set; }
        public string OzelKod { get; set; }
        public string Ad { get; set; }
        public string GenelAd { get; set; }
        public string StokTipi { get; set; }
        public Nullable<decimal> AlışFiyat { get; set; }
        public Nullable<decimal> SatışFiyat { get; set; }
        public Nullable<decimal> Kdv { get; set; }
        public Nullable<int> Adet { get; set; }
        public string Barkod { get; set; }
        public Nullable<bool> Durum { get; set; }
    
        public virtual Adresleme Adresleme { get; set; }
    }
}
