using System;
using System.Collections.Generic;

#nullable disable

namespace CevikMetalTeknik.Model
{
    public partial class Hareket
    {
        public Hareket()
        {
            BorcAlacaks = new HashSet<BorcAlacak>();
        }

        public int Hareketid { get; set; }
        public int? Stokid { get; set; }
        public int? Giris { get; set; }
        public int? Cikis { get; set; }
        public string Acıklama { get; set; }
        public DateTime? İslemTarihi { get; set; }
        public int? Mevcut { get; set; }
        public string İslemYapılanCariAd { get; set; }
        public string İslemYapılanCariAd1 { get; set; }

        public virtual Stok Stok { get; set; }
        public virtual ICollection<BorcAlacak> BorcAlacaks { get; set; }
    }
}
