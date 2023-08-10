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
    public partial class Frmcari : Form
    {
        public int id=0;

        public Frmcari()
        {
            InitializeComponent();
        }
        CevikTeknikMetalDb_context db = new  CevikTeknikMetalDb_context();
        private void simpleButton3_Click(object sender, EventArgs e)
        {

           

            try
            {
                var cari = db.Caris.FirstOrDefault(x => x.Cariid == id);
                var stok = db.Stoks.FirstOrDefault(x => x.CariId == id);  
                if (stok == null)                                            
                {
                    DialogResult soru = MessageBox.Show(cari.CariAdi + " Cari Silinicek Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (soru == DialogResult.Yes)
                    {

                        if (cari != null)
                        {
                            db.Caris.Remove(cari);
                            db.SaveChanges();
                            MessageBox.Show("İşlem Başarılı");
                            Frmcari cr = (Frmcari)Application.OpenForms["Frmcari"];
                            cr.Listele();
                        }
                    }

                }

                else
                {
                    MessageBox.Show(cari.CariAdi + " Silinemez.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                
            }
        }
        public void Listele()
        {
            var liste = from cari in db.Caris
                        join para in db.Parabirimis on cari.Parabirimiid equals para.Parabirimiid into aa
                        from para in aa.DefaultIfEmpty()
                        
                        select new
                        {
                            cari.Cariid,
                            cari.CariKodu,
                            cari.CariAdi,
                            cari.Cariislem,
                            cari.Cariislemtarih,
                            para.ParabirimiAdi
                            

                        };
            gridControl1.DataSource = liste.ToList();
        }
        
        private void Frmcari_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Carieklmbtn_Click(object sender, EventArgs e)
        {
            FrmCariEkleme ekle = new FrmCariEkleme(); 
            ekle.ShowDialog();
        }

        private void CariDznbtn_Click(object sender, EventArgs e)
        {
            FrmCariDüzenleme dzn = new FrmCariDüzenleme();
            dzn.cariid = id;
            dzn.ShowDialog();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            id = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Cariid");
        }
    }
}
