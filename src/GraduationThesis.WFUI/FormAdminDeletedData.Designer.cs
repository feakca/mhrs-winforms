namespace GraduationThesis.WFUI
{
    partial class FormAdminDeletedData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminDeletedData));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridControlHospital = new DevExpress.XtraGrid.GridControl();
            this.gridViewHospital = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridControlDoctor = new DevExpress.XtraGrid.GridControl();
            this.gridViewDoctor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridControlMember = new DevExpress.XtraGrid.GridControl();
            this.gridViewMember = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridControlMedicine = new DevExpress.XtraGrid.GridControl();
            this.gridViewMedicine = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHospital)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDoctor)).BeginInit();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMember)).BeginInit();
            this.tabNavigationPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.tabNavigationPage4);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3,
            this.tabNavigationPage4});
            this.tabPane1.RegularSize = new System.Drawing.Size(1344, 531);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1344, 531);
            this.tabPane1.TabIndex = 999;
            this.tabPane1.TabStop = false;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Hastane";
            this.tabNavigationPage1.Controls.Add(this.gridControlHospital);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1344, 502);
            // 
            // gridControlHospital
            // 
            this.gridControlHospital.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHospital.Location = new System.Drawing.Point(0, 0);
            this.gridControlHospital.MainView = this.gridViewHospital;
            this.gridControlHospital.Name = "gridControlHospital";
            this.gridControlHospital.Size = new System.Drawing.Size(1344, 502);
            this.gridControlHospital.TabIndex = 999;
            this.gridControlHospital.TabStop = false;
            this.gridControlHospital.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHospital});
            // 
            // gridViewHospital
            // 
            this.gridViewHospital.GridControl = this.gridControlHospital;
            this.gridViewHospital.Name = "gridViewHospital";
            this.gridViewHospital.OptionsBehavior.Editable = false;
            this.gridViewHospital.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewHospital.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Doktor";
            this.tabNavigationPage2.Controls.Add(this.gridControlDoctor);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1344, 502);
            // 
            // gridControlDoctor
            // 
            this.gridControlDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDoctor.Location = new System.Drawing.Point(0, 0);
            this.gridControlDoctor.MainView = this.gridViewDoctor;
            this.gridControlDoctor.Name = "gridControlDoctor";
            this.gridControlDoctor.Size = new System.Drawing.Size(1344, 502);
            this.gridControlDoctor.TabIndex = 999;
            this.gridControlDoctor.TabStop = false;
            this.gridControlDoctor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDoctor});
            // 
            // gridViewDoctor
            // 
            this.gridViewDoctor.GridControl = this.gridControlDoctor;
            this.gridViewDoctor.Name = "gridViewDoctor";
            this.gridViewDoctor.OptionsBehavior.Editable = false;
            this.gridViewDoctor.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewDoctor.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Üye";
            this.tabNavigationPage3.Controls.Add(this.gridControlMember);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1344, 502);
            // 
            // gridControlMember
            // 
            this.gridControlMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMember.Location = new System.Drawing.Point(0, 0);
            this.gridControlMember.MainView = this.gridViewMember;
            this.gridControlMember.Name = "gridControlMember";
            this.gridControlMember.Size = new System.Drawing.Size(1344, 502);
            this.gridControlMember.TabIndex = 999;
            this.gridControlMember.TabStop = false;
            this.gridControlMember.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMember});
            // 
            // gridViewMember
            // 
            this.gridViewMember.GridControl = this.gridControlMember;
            this.gridViewMember.Name = "gridViewMember";
            this.gridViewMember.OptionsBehavior.Editable = false;
            this.gridViewMember.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewMember.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.Caption = "İlaç";
            this.tabNavigationPage4.Controls.Add(this.gridControlMedicine);
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.Size = new System.Drawing.Size(1344, 502);
            // 
            // gridControlMedicine
            // 
            this.gridControlMedicine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMedicine.Location = new System.Drawing.Point(0, 0);
            this.gridControlMedicine.MainView = this.gridViewMedicine;
            this.gridControlMedicine.Name = "gridControlMedicine";
            this.gridControlMedicine.Size = new System.Drawing.Size(1344, 502);
            this.gridControlMedicine.TabIndex = 999;
            this.gridControlMedicine.TabStop = false;
            this.gridControlMedicine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMedicine});
            // 
            // gridViewMedicine
            // 
            this.gridViewMedicine.GridControl = this.gridControlMedicine;
            this.gridViewMedicine.Name = "gridViewMedicine";
            this.gridViewMedicine.OptionsBehavior.Editable = false;
            this.gridViewMedicine.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewMedicine.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // FormAdminDeletedData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 531);
            this.Controls.Add(this.tabPane1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdminDeletedData";
            this.Text = "Silinen Veriler";
            this.Load += new System.EventHandler(this.FormAdminDeletedData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHospital)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDoctor)).EndInit();
            this.tabNavigationPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMember)).EndInit();
            this.tabNavigationPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMedicine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage4;
        private DevExpress.XtraGrid.GridControl gridControlHospital;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHospital;
        private DevExpress.XtraGrid.GridControl gridControlDoctor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDoctor;
        private DevExpress.XtraGrid.GridControl gridControlMember;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMember;
        private DevExpress.XtraGrid.GridControl gridControlMedicine;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMedicine;
    }
}