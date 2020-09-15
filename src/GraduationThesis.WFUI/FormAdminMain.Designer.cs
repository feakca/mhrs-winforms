namespace GraduationThesis.WFUI
{
    partial class FormAdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemHospital = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDoctor = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemMedicine = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAddAdmin = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemResetPassword = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeletedData = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
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
            this.barButtonItemLogOut,
            this.barButtonItemHospital,
            this.barButtonItemDoctor,
            this.barButtonItemMedicine,
            this.barButtonItemAddAdmin,
            this.barButtonItemResetPassword,
            this.barButtonItemDeletedData});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1344, 150);
            // 
            // barButtonItemLogOut
            // 
            this.barButtonItemLogOut.Caption = "Çıkış";
            this.barButtonItemLogOut.Id = 1;
            this.barButtonItemLogOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemLogOut.ImageOptions.SvgImage")));
            this.barButtonItemLogOut.Name = "barButtonItemLogOut";
            this.barButtonItemLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemLogOut_ItemClick);
            // 
            // barButtonItemHospital
            // 
            this.barButtonItemHospital.Caption = "Hastaneler";
            this.barButtonItemHospital.Id = 2;
            this.barButtonItemHospital.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemHospital.ImageOptions.SvgImage")));
            this.barButtonItemHospital.Name = "barButtonItemHospital";
            this.barButtonItemHospital.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemHospital_ItemClick);
            // 
            // barButtonItemDoctor
            // 
            this.barButtonItemDoctor.Caption = "Doktorlar";
            this.barButtonItemDoctor.Id = 3;
            this.barButtonItemDoctor.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemDoctor.ImageOptions.SvgImage")));
            this.barButtonItemDoctor.Name = "barButtonItemDoctor";
            this.barButtonItemDoctor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDoctor_ItemClick);
            // 
            // barButtonItemMedicine
            // 
            this.barButtonItemMedicine.Caption = "İlaçlar";
            this.barButtonItemMedicine.Id = 4;
            this.barButtonItemMedicine.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemMedicine.ImageOptions.SvgImage")));
            this.barButtonItemMedicine.Name = "barButtonItemMedicine";
            this.barButtonItemMedicine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemMedicine_ItemClick);
            // 
            // barButtonItemAddAdmin
            // 
            this.barButtonItemAddAdmin.Caption = "Yönetici Ekle";
            this.barButtonItemAddAdmin.Id = 5;
            this.barButtonItemAddAdmin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemAddAdmin.ImageOptions.SvgImage")));
            this.barButtonItemAddAdmin.Name = "barButtonItemAddAdmin";
            this.barButtonItemAddAdmin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAddAdmin_ItemClick);
            // 
            // barButtonItemResetPassword
            // 
            this.barButtonItemResetPassword.Caption = "Parola Sıfırla";
            this.barButtonItemResetPassword.Id = 6;
            this.barButtonItemResetPassword.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemResetPassword.ImageOptions.SvgImage")));
            this.barButtonItemResetPassword.Name = "barButtonItemResetPassword";
            this.barButtonItemResetPassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemResetPassword_ItemClick);
            // 
            // barButtonItemDeletedData
            // 
            this.barButtonItemDeletedData.Caption = "Silinen Veriler";
            this.barButtonItemDeletedData.Id = 8;
            this.barButtonItemDeletedData.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemDeletedData.ImageOptions.SvgImage")));
            this.barButtonItemDeletedData.Name = "barButtonItemDeletedData";
            this.barButtonItemDeletedData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeletedData_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Seçenekler";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemLogOut);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Oturum";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemHospital);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemDoctor);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemMedicine);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemDeletedData);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemAddAdmin);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemResetPassword);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "İşlemler";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1344, 701);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin: Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdminMain_FormClosing);
            this.Load += new System.EventHandler(this.FormAdminMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLogOut;
        private DevExpress.XtraBars.BarButtonItem barButtonItemHospital;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDoctor;
        private DevExpress.XtraBars.BarButtonItem barButtonItemMedicine;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddAdmin;
        private DevExpress.XtraBars.BarButtonItem barButtonItemResetPassword;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDeletedData;
    }
}