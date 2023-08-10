
namespace CevikMetalTeknik
{
    partial class FrmParabirimiTanımlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParabirimiTanımlama));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Eklebtn = new DevExpress.XtraEditors.SimpleButton();
            this.Dznbtn = new DevExpress.XtraEditors.SimpleButton();
            this.silbtn = new DevExpress.XtraEditors.SimpleButton();
            this.iptalbtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 51);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 387);
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
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Para Birimi İD";
            this.gridColumn1.FieldName = "Parabirimiid";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Para Birimi Adı";
            this.gridColumn2.FieldName = "ParabirimiAdi";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Para Birimi Simgesi";
            this.gridColumn3.FieldName = "Simge";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // Eklebtn
            // 
            this.Eklebtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Eklebtn.ImageOptions.Image")));
            this.Eklebtn.Location = new System.Drawing.Point(12, 5);
            this.Eklebtn.Name = "Eklebtn";
            this.Eklebtn.Size = new System.Drawing.Size(75, 40);
            this.Eklebtn.TabIndex = 1;
            this.Eklebtn.Text = "EKLE";
            this.Eklebtn.Click += new System.EventHandler(this.Eklebtn_Click);
            // 
            // Dznbtn
            // 
            this.Dznbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Dznbtn.ImageOptions.Image")));
            this.Dznbtn.Location = new System.Drawing.Point(104, 5);
            this.Dznbtn.Name = "Dznbtn";
            this.Dznbtn.Size = new System.Drawing.Size(111, 40);
            this.Dznbtn.TabIndex = 2;
            this.Dznbtn.Text = "DÜZENLEME";
            this.Dznbtn.Click += new System.EventHandler(this.Dznbtn_Click);
            // 
            // silbtn
            // 
            this.silbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("silbtn.ImageOptions.Image")));
            this.silbtn.Location = new System.Drawing.Point(232, 5);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(82, 40);
            this.silbtn.TabIndex = 3;
            this.silbtn.Text = "SİL";
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // iptalbtn
            // 
            this.iptalbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("iptalbtn.ImageOptions.Image")));
            this.iptalbtn.Location = new System.Drawing.Point(337, 5);
            this.iptalbtn.Name = "iptalbtn";
            this.iptalbtn.Size = new System.Drawing.Size(75, 40);
            this.iptalbtn.TabIndex = 4;
            this.iptalbtn.Text = "İPTAL";
            this.iptalbtn.Click += new System.EventHandler(this.iptalbtn_Click);
            // 
            // FrmParabirimiTanımlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.iptalbtn);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.Dznbtn);
            this.Controls.Add(this.Eklebtn);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmParabirimiTanımlama";
            this.Text = "FrmParabirimiTanımlama";
            this.Load += new System.EventHandler(this.FrmParabirimiTanımlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Eklebtn;
        private DevExpress.XtraEditors.SimpleButton Dznbtn;
        private DevExpress.XtraEditors.SimpleButton silbtn;
        private DevExpress.XtraEditors.SimpleButton iptalbtn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}