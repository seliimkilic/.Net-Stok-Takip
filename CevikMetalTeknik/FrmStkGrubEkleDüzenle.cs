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
    public partial class FrmStkGrubEkleDüzenle : Form
    {
        CevikTeknikMetalDb_context db = new CevikTeknikMetalDb_context();
        public int id;
        public FrmStkGrubEkleDüzenle()
        {
            InitializeComponent();
        }

        private void iptalbtn_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("İptal İşlemi Yapılacak emin misin?", "Uygulama Çıkış", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }
        public void doldur()
        {

            if (id > 0)
            {
                var grub = db.StokGrubs.FirstOrDefault(x => x.StokGrubid == id);
                kodtx.Text = grub.StokGrubKod;
                adtx.Text = grub.StokGrubAd;
                
            }

        }

        private void FrmStkGrubEkleDüzenle_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            try
            {


                string grubad = adtx.Text;
                string kod = kodtx.Text;
                bool mevcut = db.StokGrubs.Any(x => x.StokGrubAd == grubad);
                bool mevcut2 = db.StokGrubs.Any(x => x.StokGrubKod == kod);
                
                if (mevcut || mevcut2)
                {
                    MessageBox.Show("Aynı isim veya kod Kullanımdadır.Lütfen Farklı isim veya kod  Giriniz.");
                }
                else
                {
                    if (id > 0)
                    {
                        var güncelleme = db.StokGrubs.Where(w => w.StokGrubid == id).FirstOrDefault();
                        güncelleme.StokGrubAd = adtx.Text.ToString();
                        güncelleme.StokGrubKod = kodtx.Text.ToString();
                        db.SaveChanges();
                    }

                    else
                    {

                        StokGrub ekle = new StokGrub();

                        ekle.StokGrubAd = adtx.Text;
                        ekle.StokGrubKod = kodtx.Text;

                        db.StokGrubs.Add(ekle);
                        db.SaveChanges();

                    }

                    FrmStokGrub st = (FrmStokGrub)Application.OpenForms["FrmStokGrub"];
                    st.veri();
                    MessageBox.Show("İşlem Başarılı");
                    this.Close();

                }

            }


            catch
            {
                MessageBox.Show("Hatalı İşlem ");
            }
        }
    }
}
