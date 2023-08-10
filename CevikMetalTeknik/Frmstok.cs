using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using CevikMetalTeknik.Data;
using DevExpress.XtraGrid.Views.Grid;

namespace CevikMetalTeknik
{
    public partial class Frmstok : Form
        
    {
        public int id =0;

        CevikTeknikMetalDb_context db = new CevikTeknikMetalDb_context();
        public Frmstok()
        {
            InitializeComponent();
        }

        private void Frmstok_Load(object sender, EventArgs e)
        {
            listele();

        }

        public void listele() 
                           
        {
            var liste = from stok in db.Stoks
                        join cari in db.Caris on stok.CariId equals cari.Cariid into aa
                        from cari in aa.DefaultIfEmpty()
                        join para in db.Parabirimis on stok.Parabirimiid equals para.Parabirimiid into p
                        from para in p.DefaultIfEmpty()
                        join hareket in db.Harekets on stok.Stokid equals hareket.Stokid into h
                        from hareket in h.DefaultIfEmpty()
                        join grub in db.StokGrubs on stok.StokGrubid equals grub.StokGrubid into hh
                        from grub in hh.DefaultIfEmpty()

                        select new
                        {
                            stok.Stokid,
                            stok.StokKodu,
                            stok.StokAdi,
                            kodu = cari.CariKodu,
                            cariad = cari.CariAdi,
                            stok.Fiyat,
                            para.ParabirimiAdi,
                            stok.MevcutStok,
                            stok.Urunislemturu,
                            stok.StokResim,
                            grub.StokGrubAd,
                            //stok.Giris,
                            //stok.Cikis,
                            //hareket.Giris,
                            //hareket.Cikis,
                            


                            toplamg = db.Harekets.Where(x => x.Stokid == stok.Stokid).Sum(x => x.Giris),
                           toplamc= db.Harekets.Where(x => x.Stokid == stok.Stokid).Sum(x => x.Cikis)

                        };
            
            gridControl1.DataSource = liste.Distinct().ToList();
             
            
        }
         
        private void eklebtn_Click(object sender, EventArgs e)
        {
            FrmStokEkleme ekle = new FrmStokEkleme(); 
            ekle.ShowDialog();
        }

        private void dznbtn_Click(object sender, EventArgs e)
        {// editable true olduğunda seçim yapmana izin vermez

            FrmStokDüzenleme dzn = new FrmStokDüzenleme();
            dzn.stokid = id;
            dzn.ShowDialog();
            
            //FrmStokDüzenleme sd = new FrmStokDüzenleme();
            //sd.a = gridView1.GetFocusedRowCellValue("StokAdi").ToString();
            //sd.b = gridView1.GetFocusedRowCellValue("StokKodu").ToString();
            //sd.c = gridView1.GetFocusedRowCellValue("Fiyat").ToString();
            //sd.d = gridView1.GetFocusedRowCellValue("MevcutStok").ToString();
            //sd.f = gridView1.GetFocusedRowCellValue("CariId").ToString();
            //sd.g = gridView1.GetFocusedRowCellValue("CariKodu").ToString();
            //sd.k = gridView1.GetFocusedRowCellValue("Parabirimiid").ToString();



        }

        private void gridView1_Click(object sender, EventArgs e)
        {
               try
            {
                id = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Stokid");//try bloğu

            }
            catch
            {

            }
          

        }

        private void silbtn_Click(object sender, EventArgs e)//SİLME KISMI
        {
            try
            {
                var stok = db.Stoks.FirstOrDefault(x => x.Stokid == id);
                var hareket = db.Harekets.FirstOrDefault(x => x.Stokid == id);  // stok her hangi bir hareket görmüş mü
                if (hareket == null)                                            // stok herhangi bir hareket görmediyse sil
                {
                    DialogResult soru = MessageBox.Show(stok.StokAdi + " Stoğunu Silinicek Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (soru == DialogResult.Yes)
                    {
                        
                        if (stok != null)
                        {
                            db.Stoks.Remove(stok);
                            db.SaveChanges();
                            MessageBox.Show("İşlem Başarılı");
                            Frmstok st = (Frmstok)Application.OpenForms["Frmstok"];
                            st.listele();
                        }
                    }

                    }

                else
                {
                    MessageBox.Show(stok.StokAdi + " Silinemez.","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            }
            catch 
            {

            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)///Renklendirme kısmı
        {
            try
            { 
                GridView view = sender as GridView;

                if (e.Column.FieldName == "Urunislemturu")
                {
                    string value = view.GetRowCellValue(e.RowHandle, "Urunislemturu") != null ? view.GetRowCellValue(e.RowHandle, "Urunislemturu").ToString() : "0";
                    
                    if (value == "Ürün")
                    { e.Appearance.BackColor = System.Drawing.Color.Green; }
                    if (value == "Tedarik")
                    { e.Appearance.BackColor = System.Drawing.Color.Red; }

                }
            }
            catch
            {


            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
