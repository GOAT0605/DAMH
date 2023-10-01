namespace DEV_damh1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnMA = new DevExpress.XtraBars.BarButtonItem();
            this.btnNL = new DevExpress.XtraBars.BarButtonItem();
            this.btnPGM = new DevExpress.XtraBars.BarButtonItem();
            this.btnHD = new DevExpress.XtraBars.BarButtonItem();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnNV,
            this.btnKH,
            this.btnMA,
            this.btnNL,
            this.btnPGM,
            this.btnHD});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(884, 193);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNV, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKH, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMA, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNL, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPGM, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHD, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Danh Mục";
            // 
            // btnNV
            // 
            this.btnNV.Caption = "Nhân Viên";
            this.btnNV.Id = 1;
            this.btnNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNV.ImageOptions.Image")));
            this.btnNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNV.ImageOptions.LargeImage")));
            this.btnNV.Name = "btnNV";
            this.btnNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNV_ItemClick);
            // 
            // btnKH
            // 
            this.btnKH.Caption = "Khách Hàng";
            this.btnKH.Id = 2;
            this.btnKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKH.ImageOptions.Image")));
            this.btnKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKH.ImageOptions.LargeImage")));
            this.btnKH.Name = "btnKH";
            this.btnKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKH_ItemClick);
            // 
            // btnMA
            // 
            this.btnMA.Caption = "Món Ăn";
            this.btnMA.Id = 3;
            this.btnMA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMA.ImageOptions.Image")));
            this.btnMA.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMA.ImageOptions.LargeImage")));
            this.btnMA.Name = "btnMA";
            this.btnMA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMA_ItemClick);
            // 
            // btnNL
            // 
            this.btnNL.Caption = "Nguyên Liệu";
            this.btnNL.Id = 4;
            this.btnNL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNL.ImageOptions.Image")));
            this.btnNL.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNL.ImageOptions.LargeImage")));
            this.btnNL.Name = "btnNL";
            this.btnNL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNL_ItemClick);
            // 
            // btnPGM
            // 
            this.btnPGM.Caption = "Phiếu Gọi Món";
            this.btnPGM.Id = 5;
            this.btnPGM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPGM.ImageOptions.Image")));
            this.btnPGM.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPGM.ImageOptions.LargeImage")));
            this.btnPGM.Name = "btnPGM";
            this.btnPGM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPGM_ItemClick);
            // 
            // btnHD
            // 
            this.btnHD.Caption = "Hóa Đơn";
            this.btnHD.Id = 6;
            this.btnHD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHD.ImageOptions.Image")));
            this.btnHD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHD.ImageOptions.LargeImage")));
            this.btnHD.Name = "btnHD";
            this.btnHD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHD_ItemClick);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 443);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnNV;
        private DevExpress.XtraBars.BarButtonItem btnKH;
        private DevExpress.XtraBars.BarButtonItem btnMA;
        private DevExpress.XtraBars.BarButtonItem btnNL;
        private DevExpress.XtraBars.BarButtonItem btnPGM;
        private DevExpress.XtraBars.BarButtonItem btnHD;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
    }
}

