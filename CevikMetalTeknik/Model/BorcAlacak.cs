using System;
using System.Collections.Generic;

#nullable disable

namespace CevikMetalTeknik.Model
{
    public partial class BorcAlacak
    {
        public int Borcalacakid { get; set; }
        public int? Stokid { get; set; }
        public int? Cariid { get; set; }
        public int? Hareketid { get; set; }
        public int? Parabirimiid { get; set; }
        public double? Borc { get; set; }
        public double? Alacak { get; set; }

        public virtual Hareket Hareket { get; set; }
        public virtual Parabirimi Parabirimi { get; set; }
        public virtual Stok Stok { get; set; }
    }
}
