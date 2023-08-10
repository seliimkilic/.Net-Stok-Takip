using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CevikMetalTeknik
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void cikisbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Uygulamayı kapatmak istediğinize emin misin?","Uygulama Çıkış", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                ////FrmAnasayfa ana = new FrmAnasayfa();
                //////ana.MdiParent = this;
                ////ana.Show();
            }
        }
        Frmstok st;
        Frmcari fc;
        Frmstokhareket sh;
        FrmTanımlamalar ft;
        private void stokbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(st==null || st.IsDisposed)
            {
            st  = new Frmstok();
            st.MdiParent = this;
             
            st.Show();
            }


        }

        private void caribtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fc == null || fc.IsDisposed)
            {
                fc = new Frmcari();
                fc.MdiParent = this;

                fc.Show();
            }
        }

        private void stokhareketbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sh == null || sh.IsDisposed)
            {
                sh = new Frmstokhareket();
                sh.MdiParent = this;

                sh.Show();
            }
        }

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            
        }

        private void anasayfabtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (st == null || st.IsDisposed)
            {
                st = new Frmstok();
                st.MdiParent = this;
               
                st.ShowDialog();
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ft == null || ft.IsDisposed)
            {
                ft = new FrmTanımlamalar();
                ft.MdiParent = this;

                ft.Show();
            }
        }
    }
}
