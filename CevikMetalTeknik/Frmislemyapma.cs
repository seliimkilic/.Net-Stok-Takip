using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CevikMetalTeknik;
using CevikMetalTeknik.Data;
using CevikMetalTeknik.Model;

namespace CevikMetalTeknikt
{
    public partial class Frmislemyapma : Form
    {
        public int stokid;
        public Frmislemyapma()
        {
            InitializeComponent();
        }
        CevikTeknikMetalDb_context db = new CevikTeknikMetalDb_context();

        //public void toplamtutar()
        //{

        //    try
        //    {
        //        int sayı1 = int.Parse(stkfyttx.Text);
        //        int sayı2 = int.Parse(stkadtx.Text);
        //        int outcome;
        //        outcome = sayı1 * sayı2;
        //        tpltx.Text = stkadtx.Text + " * " + stkfyttx.Text;
        //        tpltx.Text = outcome.ToString();
        //    }
        //    catch { }
        //}

        public void fromdlr()
        {

            try
            {
                var stok = db.Stoks.FirstOrDefault(x => x.Stokid == stokid);

                if (stok != null)
                {

                    var stokk = stok.Stokid != null ? db.Stoks.FirstOrDefault(x => x.Stokid == (int)stok.Stokid) : null;
                    var cari = stok.CariId != null ? db.Caris.FirstOrDefault(x => x.Cariid == (int)stok.CariId) : null;
                    comboBox1.Text = stok != null ? stok.StokAdi : "";
                    comboBox2.Text = cari != null ? cari.CariAdi : "";
                    mevcttx.Text = stok.MevcutStok.ToString();
                    stkfyttx.Text = stok.Fiyat.ToString();
                }

            }
            catch
            {

            }


        }
        public void cmbxdoldurma()
        {
            
            db = new CevikTeknikMetalDb_context();
            comboBox1.DataSource = db.Stoks.ToList();
            comboBox1.DisplayMember = "StokAdi";
            comboBox1.ValueMember = "Stokid";
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "";

            comboBox2.DataSource = db.Caris.ToList();
            comboBox2.DisplayMember = "CariAdi";
            comboBox2.ValueMember = "Cariid";
            comboBox2.SelectedIndex = -1;
            comboBox2.Text = "";

            comboBox3.DataSource = db.Caris.ToList();
            comboBox3.DisplayMember = "CariAdi";
            comboBox3.ValueMember = "Cariid";
            comboBox3.SelectedIndex = -1;
            comboBox3.Text = "";

        }

        private void Frmislemyapma_Load(object sender, EventArgs e)
        {
            cmbxdoldurma();
            fromdlr();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mevcttx.Text = comboBox1.SelectedValue.ToString();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            { 
                stkadtx.Enabled = true;
                comboBox3.Enabled = true;

            }
            else
            {
                stkadtx.Enabled = false;
                comboBox3.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                stkadtx.Enabled = false;
                comboBox3.Enabled = false;
            }
            else
            {
                stkadtx.Enabled = true;
                comboBox3.Enabled = true;
            }
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedValue==null)
                {
                    MessageBox.Show("Lütfen İşlem Yapılacak Firmayı Seçin");
                }
            
            else
           
            {
                try
            {
               
               
                int stokid = int.Parse(comboBox1.SelectedValue.ToString());
                var stok = db.Stoks.FirstOrDefault(x => x.Stokid == stokid);
                Hareket islem = new Hareket();
                islem.Stokid = stokid;
                islem.İslemTarihi = Convert.ToDateTime(dateTimePicker1.Value.ToString());
                islem.Acıklama = acıklamatx.Text;
                

                if (radioButton1.Checked == true)
                {
                    islem.Giris = int.Parse(stkadtx.Text);
                    islem.İslemYapılanCariAd = comboBox3.Text;
                    db.Harekets.Add(islem);
                    stok.MevcutStok += int.Parse(stkadtx.Text);
                    db.SaveChanges();
                }
                else
                {
                    islem.Cikis = int.Parse(stkadtx.Text);
                    islem.İslemYapılanCariAd1 = comboBox3.Text;
                    db.Harekets.Add(islem);
                    db.SaveChanges();
                    stok.MevcutStok -= int.Parse(stkadtx.Text);
                    db.SaveChanges();
                }

                }
                

            catch

            {

            MessageBox.Show("Hatalı giriş oldu ");
            }

            Frmstokhareket st = (Frmstokhareket)Application.OpenForms["Frmstokhareket"];
            st.id = stokid;
            st.listele();     
            MessageBox.Show("İşlem Başarılı");
            this.Close();
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

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stkadtx_Click(object sender, EventArgs e)
        {
           
        }
    }
}
