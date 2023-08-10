
namespace CevikMetalTeknik
{
    partial class Frmcari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcari));
            this.CariSilbtn = new DevExpress.XtraEditors.SimpleButton();
            this.CariDznbtn = new DevExpress.XtraEditors.SimpleButton();
            this.Carieklmbtn = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CariSilbtn
            // 
            this.CariSilbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CariSilbtn.ImageOptions.Image")));
            this.CariSilbtn.Location = new System.Drawing.Point(1186, 55);
            this.CariSilbtn.Name = "CariSilbtn";
            this.CariSilbtn.Size = new System.Drawing.Size(84, 38);
            this.CariSilbtn.TabIndex = 7;
            this.CariSilbtn.Text = "SİL";
            this.CariSilbtn.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // CariDznbtn
            // 
            this.CariDznbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CariDznbtn.ImageOptions.Image")));
            this.CariDznbtn.Location = new System.Drawing.Point(1051, 55);
            this.CariDznbtn.Name = "CariDznbtn";
            this.CariDznbtn.Size = new System.Drawing.Size(129, 38);
            this.CariDznbtn.TabIndex = 6;
            this.CariDznbtn.Text = "DÜZENLEME";
            this.CariDznbtn.Click += new System.EventHandler(this.CariDznbtn_Click);
            // 
            // Carieklmbtn
            // 
            this.Carieklmbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Carieklmbtn.ImageOptions.Image")));
            this.Carieklmbtn.Location = new System.Drawing.Point(949, 55);
            this.Carieklmbtn.Name = "Carieklmbtn";
            this.Carieklmbtn.Size = new System.Drawing.Size(96, 38);
            this.Carieklmbtn.TabIndex = 5;
            this.Carieklmbtn.Text = "EKLEME";
            this.Carieklmbtn.Click += new System.EventHandler(this.Carieklmbtn_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(71, 99);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1199, 527);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cari İd";
            this.gridColumn1.FieldName = "Cariid";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Cari Kodu";
            this.gridColumn4.FieldName = "CariKodu";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cari Adı";
            this.gridColumn2.FieldName = "CariAdi";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Para Birimi";
            this.gridColumn3.FieldName = "ParabirimiAdi";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cari İşlem Türü";
            this.gridColumn5.FieldName = "Cariislem";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "İşlem Tarihi";
            this.gridColumn6.FieldName = "Cariislemtarih";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // Frmcari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 681);
            this.Controls.Add(this.CariSilbtn);
            this.Controls.Add(this.CariDznbtn);
            this.Controls.Add(this.Carieklmbtn);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frmcari";
            this.Text = "Frmcari";
            this.Load += new System.EventHandler(this.Frmcari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton CariSilbtn;
        private DevExpress.XtraEditors.SimpleButton CariDznbtn;
        private DevExpress.XtraEditors.SimpleButton Carieklmbtn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}