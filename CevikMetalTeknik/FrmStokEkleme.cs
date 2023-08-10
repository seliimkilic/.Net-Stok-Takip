using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CevikMetalTeknik.Data;
using CevikMetalTeknik.Model;

namespace CevikMetalTeknik
{
    public partial class FrmStokEkleme : Form
    {
        private denemeresim dene;
        private Image originalImage;
        private Image zoomedImage;
        private float zoomFactor = 2.0f; // Büyütme faktörü
        public FrmStokEkleme()
        {
            InitializeComponent();
            dene = new denemeresim();
        }
        CevikTeknikMetalDb_context db = new CevikTeknikMetalDb_context();
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

        private void FrmStokEkleme_Load(object sender, EventArgs e)
        {

           

            db = new CevikTeknikMetalDb_context();
            comboBox1.DataSource = db.Caris.ToList();
            comboBox1.ValueMember = "Cariid";
            comboBox1.DisplayMember = "CariAdi";
            comboBox1.SelectedIndex = -1;

            comboBox2.DataSource = db.Caris.ToList();
            comboBox2.ValueMember = "Cariid";
            comboBox2.DisplayMember = "CariKodu";
            comboBox2.SelectedIndex = -1;

            parabirimi.DataSource = db.Parabirimis.ToList();
            parabirimi.ValueMember = "Parabirimiid";
            parabirimi.DisplayMember = "ParabirimiAdi";
            parabirimi.SelectedIndex = -1;

            comboBox3.DataSource = db.StokGrubs.ToList();
            comboBox3.ValueMember = "StokGrubid";
            comboBox3.DisplayMember = "StokGrubAd";
            comboBox3.SelectedIndex = -1;



            comboBox2.Text = "";
            comboBox1.Text = "";
            parabirimi.Text = "";
            comboBox3.Text = "";
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {

            
           
            db=new CevikTeknikMetalDb_context();
               try
            {
                string stokkod = kodtx.Text;
                bool mevcut = db.Stoks.Any(x=>x.StokKodu==stokkod);
                if(mevcut)
                {
                    MessageBox.Show("Aynı Kod Kullanımdadır.Lütfen Farklı Stok Kodu Giriniz.");
                }
                else  
                {
                     if (urunbtn.Checked == true || tedarikbtn.Checked == true)
                    {
                        Stok ekle = new Stok();
                        ekle.Parabirimiid = (parabirimi.Text != "" && parabirimi.SelectedIndex > -1) ? (int)parabirimi.SelectedValue : null;
                        ekle.CariId = (comboBox1.Text != "" && comboBox1.SelectedIndex > -1) ? (int)comboBox1.SelectedValue : null;
                        ekle.StokGrubid = (comboBox3.Text != "" && comboBox3.SelectedIndex > -1) ? (int)comboBox3.SelectedValue : null;
                        ekle.StokAdi = adtx.Text;
                        ekle.StokKodu = kodtx.Text;
                        ekle.Fiyat = double.Parse(fiyattx.Text);
                        if (pictureBox1.Image != null)
                        {
                        ekle.StokResim = textBox1.Text ;
                        MemoryStream ms1 = new MemoryStream();
                        pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                        ekle.StokResim1 = ms1.ToArray();

                        }
                          

                        if (urunbtn.Checked)
                        {
                            ekle.Urunislemturu = urunbtn.Text.ToString();
                        }
                        else if (tedarikbtn.Checked)
                        {
                            ekle.Urunislemturu = tedarikbtn.Text.ToString();
                        }


                        db.Stoks.Add(ekle);
                        db.SaveChanges();
                        Frmstok st = (Frmstok)Application.OpenForms["Frmstok"];
                        st.listele();
                        MessageBox.Show("İşlem Başarılı");
                        this.Close();

                    }
                
                else
                {
                    MessageBox.Show("ÜRÜN İŞLEM TÜRÜ ŞECİLMEDİ...");
                }
            }
                }
                
            catch
            {
                MessageBox.Show("Hatalı İşlem ");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedIndex>-1)
                {
                    var carikodu = db.Caris.FirstOrDefault(x => x.Cariid == (int)comboBox2.SelectedValue);
                    if (carikodu!= null)
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

        private void urunbtn_CheckedChanged(object sender, EventArgs e)
        {
           
           
        }

        private void tedarikbtn_CheckedChanged(object sender, EventArgs e)
        {

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

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmStokEkleme_MouseEnter(object sender, EventArgs e)
        {

            //pictureBox1.Width *= 2;
            //pictureBox1.Height *= 2;
            //pictureBox1.Left -= pictureBox1.Width / 4;
            //pictureBox1.Top -= pictureBox1.Height / 4;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dene.SetImage(pictureBox1.Image);
            dene.ShowDialog();
            return;
        }
    }
}
