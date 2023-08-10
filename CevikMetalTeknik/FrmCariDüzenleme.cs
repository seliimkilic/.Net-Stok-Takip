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
    public partial class FrmCariDüzenleme : Form
    {

        CevikTeknikMetalDb_context db = new CevikTeknikMetalDb_context();
        public int cariid;
        public FrmCariDüzenleme()
        {
            InitializeComponent();
        }
       
        private void FrmCariDüzenleme_Load(object sender, EventArgs e)
        {
            Comboxlistele();
            FormDoldurma();

        }
        public void Comboxlistele()
        {
            
            paracmbx.DataSource = db.Parabirimis.ToList();
            paracmbx.ValueMember = "Parabirimiid";
            paracmbx.DisplayMember = "ParabirimiAdi";
            paracmbx.SelectedIndex = -1;
        }
        public void FormDoldurma()
        {
            try
            {
                var cari = db.Caris.FirstOrDefault(x => x.Cariid == cariid);

                if (cari != null)
                {
                    var para = cari.Parabirimiid != null ? db.Parabirimis.FirstOrDefault(x => x.Parabirimiid == (int)cari.Parabirimiid) : null;
                    adtx.Text = cari.CariAdi;
                    kodtx.Text = cari.CariKodu;
                    paracmbx.Text = para != null ? para.ParabirimiAdi : "";


                    if (cari.Cariislem=="Alıcı")
                    {
                        alıcıbtn.Checked = true;
                    }
                    if (cari.Cariislem=="Satıcı")
                    {
                        satıcıbtn.Checked = true;
                    }
                    if (cari.Cariislem== "Alıcı - Satıcı")
                    {
                        alıcısatıcıbtn.Checked = true;
                    }

                }

            }
            catch
            {

            }
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var güncelleme = db.Caris.Where(w => w.Cariid == cariid).FirstOrDefault();
                güncelleme.CariAdi = adtx.Text.ToString();
                güncelleme.CariKodu = kodtx.Text.ToString();
                güncelleme.Parabirimiid = (int)paracmbx.SelectedValue;

                if (alıcıbtn.Checked==true)
                {
                    güncelleme.Cariislem = alıcıbtn.Text.ToString(); 
                }
                if (satıcıbtn.Checked == true)
                {
                    güncelleme.Cariislem = satıcıbtn.Text.ToString();
                }
                if (alıcısatıcıbtn.Checked == true)
                {
                    güncelleme.Cariislem = alıcısatıcıbtn.Text.ToString();
                }


                db.SaveChanges();
                MessageBox.Show("İşlem Başarılı");
                Frmcari cr = (Frmcari)Application.OpenForms["Frmcari"];
                cr.id = cariid;
                cr.Listele();
            }

            catch
            {
                MessageBox.Show("Hatalı İşlem");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
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
    }
}
