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
using CevikMetalTeknikt;


namespace CevikMetalTeknik
{
    public partial class Frmstokhareket : Form
    {
        public int id = 0;
        public Frmstokhareket()
        {
            InitializeComponent();
        }
        CevikTeknikMetalDb_context db = new CevikTeknikMetalDb_context();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (id >0)
            {
            Frmislemyapma isle = new Frmislemyapma();
            isle.stokid = id;
            isle.ShowDialog();

            }
            else
            {
                MessageBox.Show("Hatalı İşlem Lütfen Tablodan Seçim Yapınız","Uyarı");
            }

            
        }
         public void listele()
        {
            var liste = from stok in db.Stoks
                        join hareket in db.Harekets on stok.Stokid equals hareket.Stokid into ss
                        from hareket in ss.DefaultIfEmpty()
                        join para in db.Parabirimis on stok.Parabirimiid equals para.Parabirimiid into p
                        from para in p.DefaultIfEmpty()
                        join cari in db.Caris on stok.CariId equals cari.Cariid into cc
                        from cari in cc.DefaultIfEmpty()
                        
                        select new
                        {
                            stok.Stokid,
                            stok.StokKodu,
                            stok.StokAdi,
                            cari.CariKodu,
                            cari.CariAdi,
                            para.ParabirimiAdi,
                            stok.Fiyat,
                            stok.MevcutStok,
                            hareket.Giris,
                            hareket.Cikis,
                            hareket.Acıklama,
                            hareket.İslemTarihi,
                            hareket.İslemYapılanCariAd,
                            hareket.İslemYapılanCariAd1


                        };
            gridControl1.DataSource = liste.Distinct().ToList();
        }
        private void Frmstokhareket_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            id = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Stokid");
        }

        private void detayToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmDetay dt = new FrmDetay();
            dt.stokid = id;
            dt.ShowDialog();
            id = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Stokid");
            
            
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

        }
    }
}
