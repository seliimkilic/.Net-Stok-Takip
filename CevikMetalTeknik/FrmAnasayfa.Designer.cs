
namespace CevikMetalTeknik
{
    partial class FrmAnasayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnasayfa));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.anasayfabtn = new DevExpress.XtraBars.BarButtonItem();
            this.stokbtn = new DevExpress.XtraBars.BarButtonItem();
            this.caribtn = new DevExpress.XtraBars.BarButtonItem();
            this.stokhareketbtn = new DevExpress.XtraBars.BarButtonItem();
            this.cikisbtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.anasayfabtn,
            this.stokbtn,
            this.caribtn,
            this.stokhareketbtn,
            this.cikisbtn,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1263, 150);
            // 
            // anasayfabtn
            // 
            this.anasayfabtn.Caption = "ANASAYFA";
            this.anasayfabtn.Id = 1;
            this.anasayfabtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("anasayfabtn.ImageOptions.Image")));
            this.anasayfabtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("anasayfabtn.ImageOptions.LargeImage")));
            this.anasayfabtn.Name = "anasayfabtn";
            this.anasayfabtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.anasayfabtn_ItemClick);
            // 
            // stokbtn
            // 
            this.stokbtn.Caption = "STOK";
            this.stokbtn.Id = 2;
            this.stokbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("stokbtn.ImageOptions.Image")));
            this.stokbtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("stokbtn.ImageOptions.LargeImage")));
            this.stokbtn.Name = "stokbtn";
            this.stokbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.stokbtn_ItemClick);
            // 
            // caribtn
            // 
            this.caribtn.Caption = "CARİ";
            this.caribtn.Id = 3;
            this.caribtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("caribtn.ImageOptions.Image")));
            this.caribtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("caribtn.ImageOptions.LargeImage")));
            this.caribtn.Name = "caribtn";
            this.caribtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.caribtn_ItemClick);
            // 
            // stokhareketbtn
            // 
            this.stokhareketbtn.Caption = "STOK HAREKETLERİ";
            this.stokhareketbtn.Id = 4;
            this.stokhareketbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("stokhareketbtn.ImageOptions.Image")));
            this.stokhareketbtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("stokhareketbtn.ImageOptions.LargeImage")));
            this.stokhareketbtn.Name = "stokhareketbtn";
            this.stokhareketbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.stokhareketbtn_ItemClick);
            // 
            // cikisbtn
            // 
            this.cikisbtn.Caption = "ÇIKIŞ";
            this.cikisbtn.Id = 5;
            this.cikisbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cikisbtn.ImageOptions.Image")));
            this.cikisbtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cikisbtn.ImageOptions.LargeImage")));
            this.cikisbtn.Name = "cikisbtn";
            this.cikisbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cikisbtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ANASAYFA";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.anasayfabtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.stokbtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.caribtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.stokhareketbtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.cikisbtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "CEVİK TEKNİK METAL";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "TANIMLAMALAR";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 625);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmAnasayfa";
            this.Text = "FrmAnasayfa";
            this.Load += new System.EventHandler(this.FrmAnasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem anasayfabtn;
        private DevExpress.XtraBars.BarButtonItem stokbtn;
        private DevExpress.XtraBars.BarButtonItem caribtn;
        private DevExpress.XtraBars.BarButtonItem stokhareketbtn;
        private DevExpress.XtraBars.BarButtonItem cikisbtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}