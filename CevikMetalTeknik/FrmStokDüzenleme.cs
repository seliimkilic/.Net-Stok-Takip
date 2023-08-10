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
    public partial class FrmStokDüzenleme : Form
    {
        CevikTeknikMetalDb_context db = new CevikTeknikMetalDb_context();
        public int stokid;
        public FrmStokDüzenleme()
        {
            InitializeComponent();
        }
        public string a, b, c, d,f,g,k;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //adtx.Text = adtx.Text + comboBox2.SelectedValue.ToString();
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedIndex > -1)
                {
                    var carikodu = db.Caris.FirstOrDefault(x => x.Cariid == (int)comboBox2.SelectedValue);
                    if (carikodu != null)
                    {
                        comboBox1.Text = carikodu.CariAdi;
                    }
                }
            }
            catch
            {
                comboBox2.SelectedIndex = -1;

            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex > -1)
                {
                    var carikodu = db.Caris.FirstOrDefault(x => x.Cariid == (int)comboBox1.SelectedValue);
                    if (carikodu != null)
                    {
                        comboBox2.Text = carikodu.CariKodu;
                    }
                }
            }
            catch
            {
                comboBox1.SelectedIndex = -1;

            }
        }

        private void fiyattx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void resimscbtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox1.Text = openFileDialog1.FileName;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //adtx.Text = adtx.Text + comboBox1.SelectedValue.ToString();
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

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            try
            {

            var güncelleme = db.Stoks.Where(w => w.Stokid == stokid).FirstOrDefault();
            güncelleme.StokAdi = adtx.Text.ToString();
            güncelleme.StokKodu = kodtx.Text.ToString();
            güncelleme.Fiyat = double.Parse(fiyattx.Text);
            güncelleme.MevcutStok = mevcuttx.Text==""? 0: int.Parse(mevcuttx.Text);
            güncelleme.Parabirimiid = (int)comboBox3.SelectedValue;
            güncelleme.CariId = comboBox1.Text==""?null:(int)comboBox1.SelectedValue;
            güncelleme.StokGrubid =comboBox4.Text==""?null: (int)comboBox4.SelectedValue;
            güncelleme.StokResim = textBox1.Text.ToString(); 
            //güncelleme.CariId = int.Parse(comboBox1.Text);
           
                if (urunbtn.Checked==true)
                {
                    güncelleme.Urunislemturu = urunbtn.Text.ToString();
                }
            
                if (tedarikbtn.Checked==true)
                {
                    güncelleme.Urunislemturu = tedarikbtn.Text.ToString();
                }
            
            
            db.SaveChanges();
                
                MessageBox.Show("İşlem Başarılı");
                Frmstok st = (Frmstok)Application.OpenForms["Frmstok"];
                st.id = stokid;
                st.listele();
            }

            catch
            {
                MessageBox.Show("Hatalı İşlem");
            }

        }

        public void comboboxDoldur()
        {

            comboBox1.DataSource = db.Caris.ToList();
            comboBox1.ValueMember = "Cariid";
            comboBox1.DisplayMember = "CariAdi";

            comboBox2.DataSource = db.Caris.ToList();
            comboBox2.ValueMember = "Cariid";
            comboBox2.DisplayMember = "CariKodu";

            comboBox3.DataSource = db.Parabirimis.ToList();
            comboBox3.ValueMember = "Parabirimiid";
            comboBox3.DisplayMember = "ParabirimiAdi";

            comboBox4.DataSource = db.StokGrubs.ToList();
            comboBox4.ValueMember = "StokGrubid";
            comboBox4.DisplayMember = "StokGrubAd";

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;

        }

        public void FormDoldur()
        {
            try
            {
                
                var stok = db.Stoks.FirstOrDefault(x => x.Stokid == stokid);
    
                          if (stok != null)
                 {

                var para =stok.Parabirimiid!=null? db.Parabirimis.FirstOrDefault(x => x.Parabirimiid == (int)stok.Parabirimiid):null;
                var cari =stok.CariId!=null? db.Caris.FirstOrDefault(x => x.Cariid == (int)stok.CariId):null;
                var grub = stok.StokGrubid != null ? db.StokGrubs.FirstOrDefault(x => x.StokGrubid == (int)stok.StokGrubid) : null;

                adtx.Text = stok.StokAdi;
                kodtx.Text = stok.StokKodu;
                fiyattx.Text = stok.Fiyat.ToString();
                mevcuttx.Text = stok.MevcutStok.ToString();
                //mevcuttx.Text =stok != null? stok.MevcutStok.ToString():"";
                comboBox1.Text = cari!= null?cari.CariAdi:"";
                comboBox2.Text = cari != null ?cari.CariKodu : "";
                comboBox3.Text = para != null ?para.ParabirimiAdi : "";
                comboBox4.Text = grub != null ? grub.StokGrubAd : "";

                textBox1.Text = stok.StokResim; // dünde burda takıldı burda takılınca aşağıdaki bilgileri de doldurmuyor
                pictureBox1.ImageLocation = stok.StokResim;

                    if (stok.Urunislemturu == "Ürün")
                    {
                        urunbtn.Checked = true;
                    }
                    if (stok.Urunislemturu == "Tedarik")
                    {
                        tedarikbtn.Checked = true;
                    }


                 }

        }
            
            catch
            {
                MessageBox.Show("Hatalı İşlem");
            }
            
        }

        private void FrmStokDüzenleme_Load(object sender, EventArgs e)
        {
            
            comboboxDoldur();
            FormDoldur();

        }


    }
}
