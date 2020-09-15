namespace GraduationThesis.WFUI
{
    partial class FormDoctorMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoctorMedicine));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlMedicine = new DevExpress.XtraGrid.GridControl();
            this.gridViewMedicine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBoxEditType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.radioGroupSsi = new DevExpress.XtraEditors.RadioGroup();
            this.memoEditDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupSsi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlMedicine);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(968, 507);
            this.groupControl2.TabIndex = 999;
            this.groupControl2.Text = "İlaç Listesi";
            // 
            // gridControlMedicine
            // 
            this.gridControlMedicine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMedicine.Location = new System.Drawing.Point(2, 23);
            this.gridControlMedicine.MainView = this.gridViewMedicine;
            this.gridControlMedicine.Name = "gridControlMedicine";
            this.gridControlMedicine.Size = new System.Drawing.Size(964, 482);
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
            this.gridViewMedicine.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewMedicine_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBoxEditType);
            this.groupControl1.Controls.Add(this.radioGroupSsi);
            this.groupControl1.Controls.Add(this.memoEditDescription);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textEditName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Location = new System.Drawing.Point(986, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(346, 507);
            this.groupControl1.TabIndex = 999;
            this.groupControl1.Text = "Bilgiler";
            // 
            // comboBoxEditType
            // 
            this.comboBoxEditType.Location = new System.Drawing.Point(113, 56);
            this.comboBoxEditType.Name = "comboBoxEditType";
            this.comboBoxEditType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEditType.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditType.Properties.ReadOnly = true;
            this.comboBoxEditType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditType.Size = new System.Drawing.Size(225, 24);
            this.comboBoxEditType.TabIndex = 999;
            this.comboBoxEditType.TabStop = false;
            // 
            // radioGroupSsi
            // 
            this.radioGroupSsi.Location = new System.Drawing.Point(113, 86);
            this.radioGroupSsi.Name = "radioGroupSsi";
            this.radioGroupSsi.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupSsi.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupSsi.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Bilinmiyor"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Evet"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Hayır")});
            this.radioGroupSsi.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow;
            this.radioGroupSsi.Properties.ReadOnly = true;
            this.radioGroupSsi.Size = new System.Drawing.Size(225, 33);
            this.radioGroupSsi.TabIndex = 999;
            this.radioGroupSsi.TabStop = false;
            // 
            // memoEditDescription
            // 
            this.memoEditDescription.Location = new System.Drawing.Point(113, 125);
            this.memoEditDescription.Name = "memoEditDescription";
            this.memoEditDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoEditDescription.Properties.Appearance.Options.UseFont = true;
            this.memoEditDescription.Properties.ReadOnly = true;
            this.memoEditDescription.Size = new System.Drawing.Size(225, 206);
            this.memoEditDescription.TabIndex = 999;
            this.memoEditDescription.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 127);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 18);
            this.labelControl2.TabIndex = 999;
            this.labelControl2.Text = "Açıklama:";
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(113, 26);
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditName.Properties.Appearance.Options.UseFont = true;
            this.textEditName.Properties.ReadOnly = true;
            this.textEditName.Size = new System.Drawing.Size(225, 24);
            this.textEditName.TabIndex = 999;
            this.textEditName.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(7, 92);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 18);
            this.labelControl1.TabIndex = 999;
            this.labelControl1.Text = "SGK:";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(7, 59);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(28, 18);
            this.labelControl15.TabIndex = 999;
            this.labelControl15.Text = "Tip:";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(7, 29);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(38, 18);
            this.labelControl14.TabIndex = 999;
            this.labelControl14.Text = "İsim:";
            // 
            // FormDoctorMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 531);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDoctorMedicine";
            this.Text = "İlaçlar";
            this.Load += new System.EventHandler(this.FormDoctorMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupSsi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlMedicine;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMedicine;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditType;
        private DevExpress.XtraEditors.RadioGroup radioGroupSsi;
        private DevExpress.XtraEditors.MemoEdit memoEditDescription;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
    }
}