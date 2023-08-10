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
    public partial class FrmCariEkleme : Form
    {
        CevikTeknikMetalDb_context db = new CevikTeknikMetalDb_context();
        public FrmCariEkleme()
        {
            InitializeComponent();
        }

        public void comboxlistele()
        {
            db = new CevikTeknikMetalDb_context();
            parabirimicbmx.DataSource = db.Parabirimis.ToList();
            parabirimicbmx.ValueMember = "Parabirimiid";
            parabirimicbmx.DisplayMember = "ParabirimiAdi";
            parabirimicbmx.SelectedIndex = -1;
            parabirimicbmx.Text = "";
        }
        private void FrmCariEkleme_Load(object sender, EventArgs e)
        {
            comboxlistele();
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

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            try
            {



                string carikod = kodtx.Text;
                bool mevcut = db.Caris.Any(x => x.CariKodu == carikod);

                if (mevcut)
                {
                    MessageBox.Show("Aynı Cari Kullanımdadır.Lütfen Farklı Cari Kodu Giriniz...");
                }

                else
                {
                    if (alıcıbtn.Checked == true || satıcıbtn.Checked == true || alıcısatıcıbtn.Checked== true )
                    {
                Cari ekle = new Cari();
                ekle.Parabirimiid = (parabirimicbmx.Text != "" && parabirimicbmx.SelectedIndex > -1) ? (int)parabirimicbmx.SelectedValue : null;
                ekle.CariAdi = adtx.Text;
                ekle.CariKodu = kodtx.Text;
                ekle.Cariislemtarih = Convert.ToDateTime(dateTimePicker1.Value.ToString());

                        if (alıcıbtn.Checked)
                    {
                        ekle.Cariislem = alıcıbtn.Text.ToString();
                       
                    }
                    else if (satıcıbtn.Checked)
                    {
                        ekle.Cariislem = satıcıbtn.Text.ToString();
                      
                    }
                    else if (alıcısatıcıbtn.Checked)
                    {
                        ekle.Cariislem = alıcısatıcıbtn.Text.ToString();
                        
                    }    
                
                db.Caris.Add(ekle);
                db.SaveChanges();
                Frmcari cr = (Frmcari)Application.OpenForms["Frmcari"];
                cr.Listele();
                MessageBox.Show("İşlem Başarılı");
                this.Close();
                        
                    }
                        
                    else
                    {
                        MessageBox.Show("Lütfen İşlem Türünü Boş Bırakmayınız.");
                    }
                

            }

                }
               
            catch
            {
                //MessageBox.Show("Hatalı İşlem ");
            }
        }
    }
}
