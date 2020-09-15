namespace GraduationThesis.WFUI
{
    partial class FormDoctorAppointmentHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoctorAppointmentHistory));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlAppointmentHistory = new DevExpress.XtraGrid.GridControl();
            this.gridViewAppointmentHistory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditAppointmentHistory = new DevExpress.XtraEditors.DateEdit();
            this.memoEditDescription = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAppointmentHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAppointmentHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAppointmentHistory.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAppointmentHistory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlAppointmentHistory);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1042, 507);
            this.groupControl1.TabIndex = 999;
            this.groupControl1.Text = "Geçmiş Randevular";
            // 
            // gridControlAppointmentHistory
            // 
            this.gridControlAppointmentHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAppointmentHistory.Location = new System.Drawing.Point(2, 23);
            this.gridControlAppointmentHistory.MainView = this.gridViewAppointmentHistory;
            this.gridControlAppointmentHistory.Name = "gridControlAppointmentHistory";
            this.gridControlAppointmentHistory.Size = new System.Drawing.Size(1038, 482);
            this.gridControlAppointmentHistory.TabIndex = 999;
            this.gridControlAppointmentHistory.TabStop = false;
            this.gridControlAppointmentHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAppointmentHistory});
            // 
            // gridViewAppointmentHistory
            // 
            this.gridViewAppointmentHistory.GridControl = this.gridControlAppointmentHistory;
            this.gridViewAppointmentHistory.Name = "gridViewAppointmentHistory";
            this.gridViewAppointmentHistory.OptionsBehavior.Editable = false;
            this.gridViewAppointmentHistory.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewAppointmentHistory.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewAppointmentHistory_FocusedRowChanged);
            this.gridViewAppointmentHistory.DoubleClick += new System.EventHandler(this.gridViewAppointmentHistory_DoubleClick);
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Location = new System.Drawing.Point(1060, 15);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(44, 18);
            this.labelControl19.TabIndex = 999;
            this.labelControl19.Text = "Tarih:";
            // 
            // dateEditAppointmentHistory
            // 
            this.dateEditAppointmentHistory.EditValue = null;
            this.dateEditAppointmentHistory.Location = new System.Drawing.Point(1110, 12);
            this.dateEditAppointmentHistory.Name = "dateEditAppointmentHistory";
            this.dateEditAppointmentHistory.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditAppointmentHistory.Properties.Appearance.Options.UseFont = true;
            this.dateEditAppointmentHistory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditAppointmentHistory.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditAppointmentHistory.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateEditAppointmentHistory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEditAppointmentHistory.Size = new System.Drawing.Size(222, 24);
            this.dateEditAppointmentHistory.TabIndex = 999;
            this.dateEditAppointmentHistory.TabStop = false;
            this.dateEditAppointmentHistory.DateTimeChanged += new System.EventHandler(this.dateEditAppointmentHistory_DateTimeChanged);
            // 
            // memoEditDescription
            // 
            this.memoEditDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEditDescription.Location = new System.Drawing.Point(2, 23);
            this.memoEditDescription.Name = "memoEditDescription";
            this.memoEditDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoEditDescription.Properties.Appearance.Options.UseFont = true;
            this.memoEditDescription.Properties.ReadOnly = true;
            this.memoEditDescription.Size = new System.Drawing.Size(268, 452);
            this.memoEditDescription.TabIndex = 999;
            this.memoEditDescription.TabStop = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.memoEditDescription);
            this.groupControl2.Location = new System.Drawing.Point(1060, 42);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(272, 477);
            this.groupControl2.TabIndex = 999;
            this.groupControl2.Text = "Bulgular";
            // 
            // FormDoctorAppointmentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 531);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.dateEditAppointmentHistory);
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDoctorAppointmentHistory";
            this.Text = "Geçmiş Randevular";
            this.Load += new System.EventHandler(this.FormDoctorAppointmentHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAppointmentHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAppointmentHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAppointmentHistory.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAppointmentHistory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlAppointmentHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAppointmentHistory;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.DateEdit dateEditAppointmentHistory;
        private DevExpress.XtraEditors.MemoEdit memoEditDescription;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}