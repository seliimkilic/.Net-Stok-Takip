using CevikMetalTeknik.Model;
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

namespace CevikMetalTeknik
{
    public partial class FrmParabirimiEkleDüzenle : Form
    {
        CevikTeknikMetalDb_context db = new CevikTeknikMetalDb_context();
        public int id;
        public FrmParabirimiEkleDüzenle()
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
        public void FrmDoldur()
            {    
            
            if (id>0)
            {
            var para = db.Parabirimis.FirstOrDefault(x => x.Parabirimiid == id);     
            adtx.Text = para.ParabirimiAdi;
            simgetx.Text = para.Simge;
            
            }
            
            }
        private void kaydetbtn_Click(object sender, EventArgs e)
        {

            try
            {
                
                
                string paraad = adtx.Text;
                bool mevcut = db.Parabirimis.Any(x => x.ParabirimiAdi == paraad);
                if (mevcut)
                {
                    MessageBox.Show("Aynı isim Kullanımdadır.Lütfen Farklı isim  Giriniz.");
                }
                else
                {
                    if (id > 0)
                {
                    var güncelleme = db.Parabirimis.Where(w => w.Parabirimiid ==id).FirstOrDefault();
                    güncelleme.ParabirimiAdi= adtx.Text.ToString();
                    güncelleme.Simge = simgetx.Text.ToString();
                    db.SaveChanges();
                }

                else
                {
                        
                    Parabirimi ekle = new Parabirimi();

                    ekle.ParabirimiAdi = adtx.Text;
                    ekle.Simge = simgetx.Text;

                    db.Parabirimis.Add(ekle);
                    db.SaveChanges();

                }

                FrmParabirimiTanımlama st = (FrmParabirimiTanımlama)Application.OpenForms["FrmParabirimiTanımlama"];
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

        private void FrmParabirimiEkleDüzenle_Load(object sender, EventArgs e)
        {
            FrmDoldur();
        }
    }
}
