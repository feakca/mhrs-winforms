namespace GraduationThesis.WFUI
{
    partial class FormMemberHospital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMemberHospital));
            this.gridControlHospital = new DevExpress.XtraGrid.GridControl();
            this.gridViewHospital = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHospital)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlHospital
            // 
            this.gridControlHospital.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHospital.Location = new System.Drawing.Point(0, 0);
            this.gridControlHospital.MainView = this.gridViewHospital;
            this.gridControlHospital.Name = "gridControlHospital";
            this.gridControlHospital.Size = new System.Drawing.Size(1344, 531);
            this.gridControlHospital.TabIndex = 1000;
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
            // 
            // FormMemberHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 531);
            this.Controls.Add(this.gridControlHospital);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMemberHospital";
            this.Text = "Hastaneler";
            this.Load += new System.EventHandler(this.FormMemberHospital_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHospital)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlHospital;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHospital;
    }
}