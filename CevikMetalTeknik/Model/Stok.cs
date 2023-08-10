using System;
using System.Collections.Generic;

#nullable disable

namespace CevikMetalTeknik.Model
{
    public partial class Stok
    {
        public Stok()
        {
            BorcAlacaks = new HashSet<BorcAlacak>();
            Harekets = new HashSet<Hareket>();
        }

        public int Stokid { get; set; }
        public string StokAdi { get; set; }
        public int? Parabirimiid { get; set; }
        public double? Fiyat { get; set; }
        public int? Giris { get; set; }
        public int? Cikis { get; set; }
        public string StokKodu { get; set; }
        public int? CariId { get; set; }
        public int? MevcutStok { get; set; }
        public string Urunislemturu { get; set; }
        public string StokResim { get; set; }
        public byte[] StokResim1 { get; set; }
        public int? StokGrubid { get; set; }

        public virtual Cari Cari { get; set; }
        public virtual Parabirimi Parabirimi { get; set; }
        public virtual StokGrub StokGrub { get; set; }
        public virtual ICollection<BorcAlacak> BorcAlacaks { get; set; }
        public virtual ICollection<Hareket> Harekets { get; set; }
    }
}
