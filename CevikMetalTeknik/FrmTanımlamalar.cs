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
    public partial class FrmTanımlamalar : Form
    {
        public FrmTanımlamalar()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmParabirimiTanımlama ekle = new FrmParabirimiTanımlama();
            ekle.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmStokGrub ekle = new FrmStokGrub();
            ekle.ShowDialog();
        }

        private void FrmTanımlamalar_Load(object sender, EventArgs e)
        {

        }
    }
}
