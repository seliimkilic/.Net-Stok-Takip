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
    public partial class FrmStokGrub : Form
    {
        CevikTeknikMetalDb_context db = new CevikTeknikMetalDb_context();
        public int id;
        public FrmStokGrub()
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
        public void veri ()
        {
            var liste = from stok in db.StokGrubs
                        
                        select new 
                        {

                            
                            stok.StokGrubid,
                            stok.StokGrubKod,
                            stok.StokGrubAd

                        };

            gridControl1.DataSource = liste.ToList();

        }
        private void FrmStokGrub_Load(object sender, EventArgs e)
        {
            veri();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            try
            {
                id = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "StokGrubid");

            }
            catch
            {

            }
            
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            FrmStkGrubEkleDüzenle ekle = new FrmStkGrubEkleDüzenle();
            ekle.ShowDialog();
        }

        private void dznbtn_Click(object sender, EventArgs e)
        {
            FrmStkGrubEkleDüzenle dzn = new FrmStkGrubEkleDüzenle();
            dzn.id = id;
            dzn.ShowDialog();
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var grub = db.StokGrubs.FirstOrDefault(x => x.StokGrubid == id);
                var stok = db.Stoks.FirstOrDefault(x => x.StokGrubid == id);

                if (stok == null)
                {
                    DialogResult soru = MessageBox.Show(grub.StokGrubid + " Stok Grubunuz Silinicek Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (soru == DialogResult.Yes)
                    {

                        if (grub != null)
                        {
                            db.StokGrubs.Remove(grub);
                            db.SaveChanges();
                            MessageBox.Show("İşlem Başarılı");
                            FrmStokGrub st = (FrmStokGrub)Application.OpenForms["FrmStokGrub"];
                            st.veri();
                        }
                    }

                }

                else
                {
                    MessageBox.Show(grub.StokGrubAd + " Silinemez.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {

            }
        }
    }
}
