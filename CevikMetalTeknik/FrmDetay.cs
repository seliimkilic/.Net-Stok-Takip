using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CevikMetalTeknik.Data;
using CevikMetalTeknik.Model;

namespace CevikMetalTeknik
{
    public partial class FrmDetay : Form
    {
        CevikTeknikMetalDb_context db = new CevikTeknikMetalDb_context();
        public int stokid;
        public FrmDetay()
        {
            InitializeComponent();
        }

        public void getir()
        {
            
                var liste = from stoklar in db.Stoks.Where(x => x.Stokid == stokid)
                            join hareket in db.Harekets on stoklar.Stokid equals hareket.Stokid into hh
                            from hareket in hh.DefaultIfEmpty()
                            join para in db.Parabirimis on stoklar.Parabirimiid equals para.Parabirimiid into p
                            from para in p.DefaultIfEmpty()
                            join cari in db.Caris on stoklar.CariId equals cari.Cariid into cc
                            from cari in cc.DefaultIfEmpty()

                            select new
                            {

                                stoklar.StokAdi,
                                stoklar.StokKodu,
                                cari.CariKodu,
                                cari.CariAdi,
                                para.ParabirimiAdi,
                                stoklar.Fiyat,
                                stoklar.MevcutStok,
                                hareket.Giris,
                                hareket.Cikis,
                                hareket.İslemYapılanCariAd,
                                hareket.İslemYapılanCariAd1,
                                hareket.Acıklama,
                                hareket.İslemTarihi


                            };
                gridControl1.DataSource = liste.ToList();

            
            
                
            
        }

        private void FrmDetay_Load(object sender, EventArgs e)
        {
            getir();
        }
    }
}
