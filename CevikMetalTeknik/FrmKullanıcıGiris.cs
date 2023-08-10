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
    public partial class FrmKullanıcıGiris : Form
    {
        public FrmKullanıcıGiris()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void kullanicitx_Click(object sender, EventArgs e)
        {
            kullanicitx.Text = "";
        }

        private void sifretx_Click(object sender, EventArgs e)
        {
            sifretx.Text = "";
        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            if (kullanicitx.Text==""||sifretx.Text=="")
            {
                MessageBox.Show("Kullanıcı Adı Ve/Veya Şifre Boş Geçilemez.", "Uyarı");
            }
            else
            {
                if (kullanicitx.Text=="admin" && sifretx.Text=="123")
                {
                    AnaFormDeneme frm = new AnaFormDeneme();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    
                    MessageBox.Show("Kullanıcı Adı Ve/Veya Şifre Yanlış","Uyarı");
                }
            }
        }
    }
}
