namespace GraduationThesis.WFUI
{
    partial class FormMemberMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMemberMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemInfo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAppointmentSet = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemMyAppointment = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemHospital = new DevExpress.XtraBars.BarButtonItem();
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
            this.barButtonItemAppointmentSet,
            this.barButtonItemMyAppointment,
            this.barButtonItemChangePassword,
            this.barButtonItemHospital});
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
            this.barButtonItemLogOut.Id = 2;
            this.barButtonItemLogOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemLogOut.ImageOptions.SvgImage")));
            this.barButtonItemLogOut.Name = "barButtonItemLogOut";
            this.barButtonItemLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemLogOut_ItemClick);
            // 
            // barButtonItemAppointmentSet
            // 
            this.barButtonItemAppointmentSet.Caption = "Randevu Al";
            this.barButtonItemAppointmentSet.Id = 3;
            this.barButtonItemAppointmentSet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemAppointmentSet.ImageOptions.SvgImage")));
            this.barButtonItemAppointmentSet.Name = "barButtonItemAppointmentSet";
            this.barButtonItemAppointmentSet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAppointmentSet_ItemClick);
            // 
            // barButtonItemMyAppointment
            // 
            this.barButtonItemMyAppointment.Caption = "Randevularım";
            this.barButtonItemMyAppointment.Id = 4;
            this.barButtonItemMyAppointment.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemMyAppointment.ImageOptions.SvgImage")));
            this.barButtonItemMyAppointment.Name = "barButtonItemMyAppointment";
            this.barButtonItemMyAppointment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemMyAppointment_ItemClick);
            // 
            // barButtonItemChangePassword
            // 
            this.barButtonItemChangePassword.Caption = "Şifre Değiştir";
            this.barButtonItemChangePassword.Id = 6;
            this.barButtonItemChangePassword.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemChangePassword.ImageOptions.SvgImage")));
            this.barButtonItemChangePassword.Name = "barButtonItemChangePassword";
            this.barButtonItemChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemChangePassword_ItemClick);
            // 
            // barButtonItemHospital
            // 
            this.barButtonItemHospital.Caption = "Hastaneler";
            this.barButtonItemHospital.Id = 7;
            this.barButtonItemHospital.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemHospital.ImageOptions.SvgImage")));
            this.barButtonItemHospital.Name = "barButtonItemHospital";
            this.barButtonItemHospital.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemHospital_ItemClick);
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
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemAppointmentSet);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemMyAppointment);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemHospital);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemChangePassword);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "İşlemler";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormMemberMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1344, 701);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormMemberMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye: Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMemberMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMemberMain_Load);
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
        private DevExpress.XtraBars.BarButtonItem barButtonItemInfo;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLogOut;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAppointmentSet;
        private DevExpress.XtraBars.BarButtonItem barButtonItemMyAppointment;
        private DevExpress.XtraBars.BarButtonItem barButtonItemChangePassword;
        private DevExpress.XtraBars.BarButtonItem barButtonItemHospital;
    }
}