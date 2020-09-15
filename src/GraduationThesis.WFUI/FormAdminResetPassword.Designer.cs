namespace GraduationThesis.WFUI
{
    partial class FormAdminResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminResetPassword));
            this.radioGroupType = new DevExpress.XtraEditors.RadioGroup();
            this.textEditSsn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonResetPassword = new DevExpress.XtraEditors.SimpleButton();
            this.labelControlName = new DevExpress.XtraEditors.LabelControl();
            this.textEditNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSsn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNewPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // radioGroupType
            // 
            this.radioGroupType.Location = new System.Drawing.Point(12, 12);
            this.radioGroupType.Name = "radioGroupType";
            this.radioGroupType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupType.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Doktor"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Üye"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Yönetici")});
            this.radioGroupType.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow;
            this.radioGroupType.Size = new System.Drawing.Size(179, 35);
            this.radioGroupType.TabIndex = 0;
            this.radioGroupType.SelectedIndexChanged += new System.EventHandler(this.radioGroupType_SelectedIndexChanged);
            // 
            // textEditSsn
            // 
            this.textEditSsn.Location = new System.Drawing.Point(294, 12);
            this.textEditSsn.Name = "textEditSsn";
            this.textEditSsn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditSsn.Properties.Appearance.Options.UseFont = true;
            this.textEditSsn.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d";
            this.textEditSsn.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditSsn.Size = new System.Drawing.Size(219, 24);
            this.textEditSsn.TabIndex = 1;
            this.textEditSsn.EditValueChanged += new System.EventHandler(this.textEditSsn_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(264, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 18);
            this.labelControl1.TabIndex = 999;
            this.labelControl1.Text = "TC:";
            // 
            // simpleButtonResetPassword
            // 
            this.simpleButtonResetPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonResetPassword.Appearance.Options.UseFont = true;
            this.simpleButtonResetPassword.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButtonResetPassword.ImageOptions.SvgImage")));
            this.simpleButtonResetPassword.Location = new System.Drawing.Point(294, 90);
            this.simpleButtonResetPassword.Name = "simpleButtonResetPassword";
            this.simpleButtonResetPassword.Size = new System.Drawing.Size(219, 52);
            this.simpleButtonResetPassword.TabIndex = 999;
            this.simpleButtonResetPassword.TabStop = false;
            this.simpleButtonResetPassword.Text = "Sıfırla";
            this.simpleButtonResetPassword.Click += new System.EventHandler(this.simpleButtonResetPassword_Click);
            // 
            // labelControlName
            // 
            this.labelControlName.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlName.Appearance.Options.UseFont = true;
            this.labelControlName.Location = new System.Drawing.Point(12, 112);
            this.labelControlName.Name = "labelControlName";
            this.labelControlName.Size = new System.Drawing.Size(131, 18);
            this.labelControlName.TabIndex = 999;
            this.labelControlName.Text = "Furkan Enes Akca";
            // 
            // textEditNewPassword
            // 
            this.textEditNewPassword.Location = new System.Drawing.Point(294, 51);
            this.textEditNewPassword.Name = "textEditNewPassword";
            this.textEditNewPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditNewPassword.Properties.Appearance.Options.UseFont = true;
            this.textEditNewPassword.Properties.UseSystemPasswordChar = true;
            this.textEditNewPassword.Size = new System.Drawing.Size(219, 24);
            this.textEditNewPassword.TabIndex = 2;
            this.textEditNewPassword.EditValueChanged += new System.EventHandler(this.textEditSsn_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(208, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 18);
            this.labelControl2.TabIndex = 999;
            this.labelControl2.Text = "Yeni Şifre:";
            // 
            // FormAdminResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(527, 160);
            this.Controls.Add(this.labelControlName);
            this.Controls.Add(this.simpleButtonResetPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditNewPassword);
            this.Controls.Add(this.textEditSsn);
            this.Controls.Add(this.radioGroupType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdminResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parola Sıfırla";
            this.Load += new System.EventHandler(this.FormAdminResetPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSsn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNewPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup radioGroupType;
        private DevExpress.XtraEditors.TextEdit textEditSsn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonResetPassword;
        private DevExpress.XtraEditors.LabelControl labelControlName;
        private DevExpress.XtraEditors.TextEdit textEditNewPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}