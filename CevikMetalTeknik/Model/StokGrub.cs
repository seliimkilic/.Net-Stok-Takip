using System;
using System.Collections.Generic;

#nullable disable

namespace CevikMetalTeknik.Model
{
    public partial class StokGrub
    {
        public StokGrub()
        {
            Stoks = new HashSet<Stok>();
        }

        public int StokGrubid { get; set; }
        public string StokGrubKod { get; set; }
        public string StokGrubAd { get; set; }

        public virtual ICollection<Stok> Stoks { get; set; }
    }
}
