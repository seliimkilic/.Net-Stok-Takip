
namespace CevikMetalTeknik
{
    partial class FrmParabirimiEkleDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParabirimiEkleDüzenle));
            this.adtx = new System.Windows.Forms.TextBox();
            this.simgetx = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.iptalbtn = new DevExpress.XtraEditors.SimpleButton();
            this.kaydetbtn = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adtx
            // 
            this.adtx.Location = new System.Drawing.Point(130, 40);
            this.adtx.Name = "adtx";
            this.adtx.Size = new System.Drawing.Size(120, 21);
            this.adtx.TabIndex = 0;
            // 
            // simgetx
            // 
            this.simgetx.Location = new System.Drawing.Point(130, 86);
            this.simgetx.Name = "simgetx";
            this.simgetx.Size = new System.Drawing.Size(120, 21);
            this.simgetx.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.iptalbtn);
            this.groupControl1.Controls.Add(this.kaydetbtn);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.adtx);
            this.groupControl1.Controls.Add(this.simgetx);
            this.groupControl1.Location = new System.Drawing.Point(28, 58);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(274, 218);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "groupControl1";
            // 
            // iptalbtn
            // 
            this.iptalbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("iptalbtn.ImageOptions.Image")));
            this.iptalbtn.Location = new System.Drawing.Point(168, 144);
            this.iptalbtn.Name = "iptalbtn";
            this.iptalbtn.Size = new System.Drawing.Size(82, 38);
            this.iptalbtn.TabIndex = 6;
            this.iptalbtn.Text = "İPTAL";
            this.iptalbtn.Click += new System.EventHandler(this.iptalbtn_Click);
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kaydetbtn.ImageOptions.Image")));
            this.kaydetbtn.Location = new System.Drawing.Point(52, 144);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(89, 38);
            this.kaydetbtn.TabIndex = 5;
            this.kaydetbtn.Text = "KAYDET";
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Para Birimi Simgesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Para Birimi Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(65, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Para Birimi Ekle-Düzenle";
            // 
            // FrmParabirimiEkleDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 303);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmParabirimiEkleDüzenle";
            this.Text = "FrmParabirimiEkleDüzenle";
            this.Load += new System.EventHandler(this.FrmParabirimiEkleDüzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adtx;
        private System.Windows.Forms.TextBox simgetx;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton iptalbtn;
        private DevExpress.XtraEditors.SimpleButton kaydetbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}