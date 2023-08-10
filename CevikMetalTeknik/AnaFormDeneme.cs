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
    public partial class AnaFormDeneme : Form
    {
        public AnaFormDeneme()
        {
            InitializeComponent();
        }
        // dev express araçlarını oldukça az kullanın 
        Frmstok st;
        Frmcari cr;
        Frmstokhareket fh;
        FrmTanımlamalar ft;
        denemecheckbox aa;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (st == null || st.IsDisposed)
            {
                st = new Frmstok();
                st.MdiParent = this;
                panelControl2.Controls.Add(st);
                st.Show();
            }

        }

        private void AnaFormDeneme_Load(object sender, EventArgs e)
        {
            
        }

        private void caribtn_Click(object sender, EventArgs e)
        {
            if (cr == null || cr.IsDisposed)
            {
                cr = new Frmcari();
                cr.MdiParent = this;
                panelControl2.Controls.Add(cr);
                cr.Show();
            }
        }

        private void hareketbtn_Click(object sender, EventArgs e)
        {
            if (fh == null || fh.IsDisposed)
            {
                fh = new Frmstokhareket();
                fh.MdiParent = this;
                panelControl2.Controls.Add(fh);
                fh.Show();
            }
        }

        private void tanımlamalarbtn_Click(object sender, EventArgs e)
        {
            if (ft == null || ft.IsDisposed)
            {
                ft = new FrmTanımlamalar();
                ft.MdiParent = this;
                panelControl2.Controls.Add(ft);
                ft.Show();
            }
        }

        private void iptalbtn_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Uygulamayı kapatmak istediğinize emin misin?", "Uygulama Çıkış", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
              
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (aa == null || aa.IsDisposed)
            {
                aa = new denemecheckbox();
                aa.MdiParent = this;
                panelControl2.Controls.Add(aa);
                aa.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
