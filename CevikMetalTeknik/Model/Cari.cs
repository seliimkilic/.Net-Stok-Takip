using System;
using System.Collections.Generic;

#nullable disable

namespace CevikMetalTeknik.Model
{
    public partial class Cari
    {
        public Cari()
        {
            Stoks = new HashSet<Stok>();
        }

        public int Cariid { get; set; }
        public string CariAdi { get; set; }
        public int? Parabirimiid { get; set; }
        public string CariKodu { get; set; }
        public string Cariislem { get; set; }
        public DateTime? Cariislemtarih { get; set; }

        public virtual Parabirimi Parabirimi { get; set; }
        public virtual ICollection<Stok> Stoks { get; set; }
    }
}
