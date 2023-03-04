using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokKontrol.Dtos
{
    public class StokAdresDto
    {
        public string StokKodu { get; set; }
        public string OzelKod { get; set; }
        public string Barkod { get; set; }
        public string Ad { get; set; }
        public string GenelAd { get; set; }
        public string StokTipi { get; set; }
        public Nullable<decimal> AlışFiyat { get; set; }
        public Nullable<decimal> SatışFiyat { get; set; }
        public Nullable<decimal> Kdv { get; set; }
        public Nullable<int> Adet { get; set; }
        public string BosaltmaYontemi { get; set; }
        public string YüklemeBosaltmaAlani { get; set; }
        public string Yerleştirme { get; set; }
        public Nullable<bool> GeciciKabul { get; set; }
        public Nullable<bool> MalKabul { get; set; }
        public string Hasar { get; set; }
        public Nullable<bool> Durum { get; set; }

    }
}
