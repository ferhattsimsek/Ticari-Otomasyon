﻿namespace TicariOtomasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnanasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.btnurunler = new DevExpress.XtraBars.BarButtonItem();
            this.btnstoklar = new DevExpress.XtraBars.BarButtonItem();
            this.btnmusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.btnfirmalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnpersoneller = new DevExpress.XtraBars.BarButtonItem();
            this.btngiderler = new DevExpress.XtraBars.BarButtonItem();
            this.btnkasa = new DevExpress.XtraBars.BarButtonItem();
            this.btnnotlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnbankalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnrehber = new DevExpress.XtraBars.BarButtonItem();
            this.btnfaturalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnayarlar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnanasayfa,
            this.btnurunler,
            this.btnstoklar,
            this.btnmusteriler,
            this.btnfirmalar,
            this.btnpersoneller,
            this.btngiderler,
            this.btnkasa,
            this.btnnotlar,
            this.btnbankalar,
            this.btnrehber,
            this.btnfaturalar,
            this.btnayarlar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 329;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(1540, 183);
            // 
            // btnanasayfa
            // 
            this.btnanasayfa.Caption = "ANA SAYFA";
            this.btnanasayfa.Id = 1;
            this.btnanasayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnanasayfa.ImageOptions.Image")));
            this.btnanasayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnanasayfa.ImageOptions.LargeImage")));
            this.btnanasayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnanasayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnanasayfa.Name = "btnanasayfa";
            // 
            // btnurunler
            // 
            this.btnurunler.Caption = "ÜRÜNLER";
            this.btnurunler.Id = 2;
            this.btnurunler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnurunler.ImageOptions.Image")));
            this.btnurunler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnurunler.ImageOptions.LargeImage")));
            this.btnurunler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnurunler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnurunler.Name = "btnurunler";
            this.btnurunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnurunler_ItemClick);
            // 
            // btnstoklar
            // 
            this.btnstoklar.Caption = "STOKLAR";
            this.btnstoklar.Id = 3;
            this.btnstoklar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnstoklar.ImageOptions.Image")));
            this.btnstoklar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnstoklar.ImageOptions.LargeImage")));
            this.btnstoklar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstoklar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnstoklar.Name = "btnstoklar";
            // 
            // btnmusteriler
            // 
            this.btnmusteriler.Caption = "MÜŞTERİLER";
            this.btnmusteriler.Id = 4;
            this.btnmusteriler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnmusteriler.ImageOptions.Image")));
            this.btnmusteriler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnmusteriler.ImageOptions.LargeImage")));
            this.btnmusteriler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmusteriler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnmusteriler.Name = "btnmusteriler";
            this.btnmusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnmusteriler_ItemClick);
            // 
            // btnfirmalar
            // 
            this.btnfirmalar.Caption = "FİRMALAR";
            this.btnfirmalar.Id = 5;
            this.btnfirmalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnfirmalar.ImageOptions.Image")));
            this.btnfirmalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnfirmalar.ImageOptions.LargeImage")));
            this.btnfirmalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfirmalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnfirmalar.Name = "btnfirmalar";
            this.btnfirmalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnfirmalar_ItemClick);
            // 
            // btnpersoneller
            // 
            this.btnpersoneller.Caption = "PERSONELLER";
            this.btnpersoneller.Id = 6;
            this.btnpersoneller.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnpersoneller.ImageOptions.Image")));
            this.btnpersoneller.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnpersoneller.ImageOptions.LargeImage")));
            this.btnpersoneller.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpersoneller.ItemAppearance.Normal.Options.UseFont = true;
            this.btnpersoneller.Name = "btnpersoneller";
            this.btnpersoneller.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnpersoneller_ItemClick);
            // 
            // btngiderler
            // 
            this.btngiderler.Caption = "GİDERLER";
            this.btngiderler.Id = 7;
            this.btngiderler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btngiderler.ImageOptions.Image")));
            this.btngiderler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btngiderler.ImageOptions.LargeImage")));
            this.btngiderler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiderler.ItemAppearance.Normal.Options.UseFont = true;
            this.btngiderler.Name = "btngiderler";
            this.btngiderler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btngiderler_ItemClick);
            // 
            // btnkasa
            // 
            this.btnkasa.Caption = "KASA";
            this.btnkasa.Id = 8;
            this.btnkasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkasa.ImageOptions.Image")));
            this.btnkasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnkasa.ImageOptions.LargeImage")));
            this.btnkasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkasa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnkasa.Name = "btnkasa";
            // 
            // btnnotlar
            // 
            this.btnnotlar.Caption = "NOTLAR";
            this.btnnotlar.Id = 9;
            this.btnnotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnnotlar.ImageOptions.Image")));
            this.btnnotlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnnotlar.ImageOptions.LargeImage")));
            this.btnnotlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnnotlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnnotlar.Name = "btnnotlar";
            // 
            // btnbankalar
            // 
            this.btnbankalar.Caption = "BANKALAR";
            this.btnbankalar.Id = 10;
            this.btnbankalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnbankalar.ImageOptions.Image")));
            this.btnbankalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnbankalar.ImageOptions.LargeImage")));
            this.btnbankalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbankalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnbankalar.Name = "btnbankalar";
            // 
            // btnrehber
            // 
            this.btnrehber.Caption = "REHBER";
            this.btnrehber.Id = 11;
            this.btnrehber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnrehber.ImageOptions.Image")));
            this.btnrehber.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnrehber.ImageOptions.LargeImage")));
            this.btnrehber.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrehber.ItemAppearance.Normal.Options.UseFont = true;
            this.btnrehber.Name = "btnrehber";
            this.btnrehber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnrehber_ItemClick);
            // 
            // btnfaturalar
            // 
            this.btnfaturalar.Caption = "FATURALAR";
            this.btnfaturalar.Id = 12;
            this.btnfaturalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnfaturalar.ImageOptions.Image")));
            this.btnfaturalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnfaturalar.ImageOptions.LargeImage")));
            this.btnfaturalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfaturalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnfaturalar.Name = "btnfaturalar";
            // 
            // btnayarlar
            // 
            this.btnayarlar.Caption = "AYARLAR";
            this.btnayarlar.Id = 13;
            this.btnayarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnayarlar.ImageOptions.Image")));
            this.btnayarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnayarlar.ImageOptions.LargeImage")));
            this.btnayarlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnayarlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnayarlar.Name = "btnayarlar";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "TİCARİ OTOMASYON";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnanasayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnurunler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnstoklar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnmusteriler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnfirmalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnpersoneller);
            this.ribbonPageGroup1.ItemLinks.Add(this.btngiderler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnkasa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnnotlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnbankalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnrehber);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnfaturalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnayarlar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 846);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnanasayfa;
        private DevExpress.XtraBars.BarButtonItem btnurunler;
        private DevExpress.XtraBars.BarButtonItem btnstoklar;
        private DevExpress.XtraBars.BarButtonItem btnmusteriler;
        private DevExpress.XtraBars.BarButtonItem btnfirmalar;
        private DevExpress.XtraBars.BarButtonItem btnpersoneller;
        private DevExpress.XtraBars.BarButtonItem btngiderler;
        private DevExpress.XtraBars.BarButtonItem btnkasa;
        private DevExpress.XtraBars.BarButtonItem btnnotlar;
        private DevExpress.XtraBars.BarButtonItem btnbankalar;
        private DevExpress.XtraBars.BarButtonItem btnrehber;
        private DevExpress.XtraBars.BarButtonItem btnfaturalar;
        private DevExpress.XtraBars.BarButtonItem btnayarlar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

