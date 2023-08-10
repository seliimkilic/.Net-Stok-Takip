using System;
using System.Collections.Generic;

#nullable disable

namespace CevikMetalTeknik.Model
{
    public partial class Parabirimi
    {
        public Parabirimi()
        {
            BorcAlacaks = new HashSet<BorcAlacak>();
            Caris = new HashSet<Cari>();
            Stoks = new HashSet<Stok>();
        }

        public int Parabirimiid { get; set; }
        public string ParabirimiAdi { get; set; }
        public string Simge { get; set; }

        public virtual ICollection<BorcAlacak> BorcAlacaks { get; set; }
        public virtual ICollection<Cari> Caris { get; set; }
        public virtual ICollection<Stok> Stoks { get; set; }
    }
}
