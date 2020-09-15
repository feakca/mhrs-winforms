namespace GraduationThesis.WFUI
{
    partial class FormDoctorMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoctorMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemInfo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAppointment = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAppointmentHistory = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemMedicine = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemChangePassword = new DevExpress.XtraBars.BarButtonItem();
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
            this.barButtonItemInfo,
            this.barButtonItemLogOut,
            this.barButtonItemAppointment,
            this.barButtonItemAppointmentHistory,
            this.barButtonItemMedicine,
            this.barButtonItemChangePassword});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1344, 150);
            // 
            // barButtonItemInfo
            // 
            this.barButtonItemInfo.Caption = "Bilgiler";
            this.barButtonItemInfo.Id = 1;
            this.barButtonItemInfo.Name = "barButtonItemInfo";
            this.barButtonItemInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemInfo_ItemClick);
            // 
            // barButtonItemLogOut
            // 
            this.barButtonItemLogOut.Caption = "Çıkış";
            this.barButtonItemLogOut.Id = 3;
            this.barButtonItemLogOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemLogOut.ImageOptions.SvgImage")));
            this.barButtonItemLogOut.Name = "barButtonItemLogOut";
            this.barButtonItemLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemLogOut_ItemClick);
            // 
            // barButtonItemAppointment
            // 
            this.barButtonItemAppointment.Caption = "Randevular";
            this.barButtonItemAppointment.Id = 4;
            this.barButtonItemAppointment.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemAppointment.ImageOptions.SvgImage")));
            this.barButtonItemAppointment.Name = "barButtonItemAppointment";
            this.barButtonItemAppointment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAppointment_ItemClick);
            // 
            // barButtonItemAppointmentHistory
            // 
            this.barButtonItemAppointmentHistory.Caption = "Geçmiş Randevular";
            this.barButtonItemAppointmentHistory.Id = 5;
            this.barButtonItemAppointmentHistory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemAppointmentHistory.ImageOptions.SvgImage")));
            this.barButtonItemAppointmentHistory.Name = "barButtonItemAppointmentHistory";
            this.barButtonItemAppointmentHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAppointmentHistory_ItemClick);
            // 
            // barButtonItemMedicine
            // 
            this.barButtonItemMedicine.Caption = "İlaçlar";
            this.barButtonItemMedicine.Id = 6;
            this.barButtonItemMedicine.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemMedicine.ImageOptions.SvgImage")));
            this.barButtonItemMedicine.Name = "barButtonItemMedicine";
            this.barButtonItemMedicine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemMedicine_ItemClick);
            // 
            // barButtonItemChangePassword
            // 
            this.barButtonItemChangePassword.Caption = "Şifre Değiştir";
            this.barButtonItemChangePassword.Id = 7;
            this.barButtonItemChangePassword.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemChangePassword.ImageOptions.SvgImage")));
            this.barButtonItemChangePassword.Name = "barButtonItemChangePassword";
            this.barButtonItemChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemChangePassword_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemInfo);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemLogOut);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Oturum";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemAppointment);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemAppointmentHistory);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemMedicine);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemChangePassword);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "İşlemler";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormDoctorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1344, 701);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormDoctorMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor: Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDoctorMain_FormClosing);
            this.Load += new System.EventHandler(this.FormDoctorMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemInfo;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLogOut;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAppointment;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAppointmentHistory;
        private DevExpress.XtraBars.BarButtonItem barButtonItemMedicine;
        private DevExpress.XtraBars.BarButtonItem barButtonItemChangePassword;
    }
}

