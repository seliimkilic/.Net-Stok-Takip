
namespace CevikMetalTeknik
{
    partial class FrmStokGrub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokGrub));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.eklebtn = new DevExpress.XtraEditors.SimpleButton();
            this.silbtn = new DevExpress.XtraEditors.SimpleButton();
            this.dznbtn = new DevExpress.XtraEditors.SimpleButton();
            this.iptalbtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(16, 62);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(436, 324);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Stok Grub İd";
            this.gridColumn1.FieldName = "StokGrubid";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Stok Grub Kodu";
            this.gridColumn2.FieldName = "StokGrubKod";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Stok Grub Ad";
            this.gridColumn3.FieldName = "StokGrubAd";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // eklebtn
            // 
            this.eklebtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("eklebtn.ImageOptions.Image")));
            this.eklebtn.Location = new System.Drawing.Point(16, 22);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(90, 34);
            this.eklebtn.TabIndex = 1;
            this.eklebtn.Text = "EKLE";
            this.eklebtn.Click += new System.EventHandler(this.eklebtn_Click);
            // 
            // silbtn
            // 
            this.silbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("silbtn.ImageOptions.Image")));
            this.silbtn.Location = new System.Drawing.Point(249, 22);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(85, 34);
            this.silbtn.TabIndex = 2;
            this.silbtn.Text = "SİL";
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // dznbtn
            // 
            this.dznbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dznbtn.ImageOptions.Image")));
            this.dznbtn.Location = new System.Drawing.Point(130, 22);
            this.dznbtn.Name = "dznbtn";
            this.dznbtn.Size = new System.Drawing.Size(93, 34);
            this.dznbtn.TabIndex = 3;
            this.dznbtn.Text = "DÜZENLE";
            this.dznbtn.Click += new System.EventHandler(this.dznbtn_Click);
            // 
            // iptalbtn
            // 
            this.iptalbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("iptalbtn.ImageOptions.Image")));
            this.iptalbtn.Location = new System.Drawing.Point(358, 22);
            this.iptalbtn.Name = "iptalbtn";
            this.iptalbtn.Size = new System.Drawing.Size(94, 34);
            this.iptalbtn.TabIndex = 4;
            this.iptalbtn.Text = "İPTAL";
            this.iptalbtn.Click += new System.EventHandler(this.iptalbtn_Click);
            // 
            // FrmStokGrub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 406);
            this.Controls.Add(this.iptalbtn);
            this.Controls.Add(this.dznbtn);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.eklebtn);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmStokGrub";
            this.Text = "FrmStokGrub";
            this.Load += new System.EventHandler(this.FrmStokGrub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton eklebtn;
        private DevExpress.XtraEditors.SimpleButton silbtn;
        private DevExpress.XtraEditors.SimpleButton dznbtn;
        private DevExpress.XtraEditors.SimpleButton iptalbtn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}