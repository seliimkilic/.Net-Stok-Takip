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
    public partial class FrmParabirimiTanımlama : Form
    {
        CevikTeknikMetalDb_context db = new CevikTeknikMetalDb_context();
        public int id;
        public FrmParabirimiTanımlama()
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

        private void FrmParabirimiTanımlama_Load(object sender, EventArgs e)
        {
            veri();
        }
        public void veri()
        {
          var veri = from para in db.Parabirimis
                            
                            select new
                            {
                                para.Parabirimiid,
                                para.ParabirimiAdi,
                                para.Simge
                            };

            gridControl1.DataSource = veri.ToList();

        }

        private void Eklebtn_Click(object sender, EventArgs e)
        {
            FrmParabirimiEkleDüzenle ekle = new FrmParabirimiEkleDüzenle();
            ekle.ShowDialog();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            id = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Parabirimiid");
        }

        private void Dznbtn_Click(object sender, EventArgs e)
        {
            FrmParabirimiEkleDüzenle dzn = new FrmParabirimiEkleDüzenle();
            dzn.id = id;
            dzn.ShowDialog();
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var para = db.Parabirimis.FirstOrDefault(x => x.Parabirimiid == id);
                var stok = db.Stoks.FirstOrDefault(x => x.Parabirimiid == id);
                  
                if (stok == null)                                           
                {
                    DialogResult soru = MessageBox.Show(para.ParabirimiAdi + " Stoğunu Silinicek Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (soru == DialogResult.Yes)
                    {

                        if (para != null)
                        {
                            db.Parabirimis.Remove(para);
                            db.SaveChanges();
                            MessageBox.Show("İşlem Başarılı");
                            FrmParabirimiTanımlama st = (FrmParabirimiTanımlama)Application.OpenForms["FrmParabirimiTanımlama"];
                            st.veri();
                        }
                    }

                }

                else
                {
                    MessageBox.Show(para.ParabirimiAdi + " Silinemez.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {

            }
        }
    }
}
