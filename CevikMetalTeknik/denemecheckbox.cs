using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CevikMetalTeknik.Model;
using CevikMetalTeknik.Data;
using DevExpress.XtraRichEdit.Fields;

namespace CevikMetalTeknik
{
    public partial class denemecheckbox : Form
    {
        CevikTeknikMetalDb_context db = new CevikTeknikMetalDb_context();
        public denemecheckbox()
        {
            InitializeComponent();
            Listele();
            
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == 0 && e.RowIndex >= 0) // Sütun 0 bir checkbox sütunudur
        //    {
        //        // Tıklanan hücrenin değerini alın
        //        bool isChecked = (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

        //        // Değeri tersine çevirin
        //        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !isChecked;
        //    }
        //}
        public void Listele()
        {
            var liste = from cari in db.Caris
                        join para in db.Parabirimis on cari.Parabirimiid equals para.Parabirimiid into aa
                        from para in aa.DefaultIfEmpty()

                        select new
                        {
                            cari.Cariid,
                            cari.CariKodu,
                            cari.CariAdi,
                            cari.Cariislem,
                            cari.Cariislemtarih,
                            para.ParabirimiAdi


                        };
            dataGridView1.DataSource = liste.ToList();
        }
        private void denemecheckbox_Load(object sender, EventArgs e)
        {
         

        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
          
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridView1.Rows[selectedRowIndex].Cells[0];
            chk.Value = true;

        }
    }
}
