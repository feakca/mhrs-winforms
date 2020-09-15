namespace GraduationThesis.WFUI
{
    partial class FormLogInForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogInForgotPassword));
            this.simpleButtonResetPassword = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.textEditSsn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEditPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textEditMail = new DevExpress.XtraEditors.TextEdit();
            this.dateEditBirthday = new DevExpress.XtraEditors.DateEdit();
            this.textEditNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditNewPasswordRepeat = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSsn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNewPasswordRepeat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonResetPassword
            // 
            this.simpleButtonResetPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonResetPassword.Appearance.Options.UseFont = true;
            this.simpleButtonResetPassword.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButtonResetPassword.ImageOptions.SvgImage")));
            this.simpleButtonResetPassword.Location = new System.Drawing.Point(142, 233);
            this.simpleButtonResetPassword.Name = "simpleButtonResetPassword";
            this.simpleButtonResetPassword.Size = new System.Drawing.Size(173, 40);
            this.simpleButtonResetPassword.TabIndex = 999;
            this.simpleButtonResetPassword.TabStop = false;
            this.simpleButtonResetPassword.Text = "Sıfırla";
            this.simpleButtonResetPassword.Click += new System.EventHandler(this.simpleButtonResetPassword_Click);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(12, 12);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(28, 16);
            this.labelControl12.TabIndex = 999;
            this.labelControl12.Text = "TC*:";
            // 
            // textEditSsn
            // 
            this.textEditSsn.Location = new System.Drawing.Point(142, 9);
            this.textEditSsn.Name = "textEditSsn";
            this.textEditSsn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditSsn.Properties.Appearance.Options.UseFont = true;
            this.textEditSsn.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d";
            this.textEditSsn.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditSsn.Size = new System.Drawing.Size(173, 22);
            this.textEditSsn.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 40);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 16);
            this.labelControl3.TabIndex = 999;
            this.labelControl3.Text = "İsim*:";
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(142, 37);
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditName.Properties.Appearance.Options.UseFont = true;
            this.textEditName.Properties.Mask.EditMask = "\\p{L}+[ ]?\\p{L}+";
            this.textEditName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditName.Properties.Mask.ShowPlaceHolders = false;
            this.textEditName.Size = new System.Drawing.Size(173, 22);
            this.textEditName.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 68);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 16);
            this.labelControl4.TabIndex = 999;
            this.labelControl4.Text = "Soyisim*:";
            // 
            // textEditSurname
            // 
            this.textEditSurname.Location = new System.Drawing.Point(142, 65);
            this.textEditSurname.Name = "textEditSurname";
            this.textEditSurname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditSurname.Properties.Appearance.Options.UseFont = true;
            this.textEditSurname.Properties.Mask.EditMask = "\\p{L}+";
            this.textEditSurname.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditSurname.Size = new System.Drawing.Size(173, 22);
            this.textEditSurname.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 96);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 16);
            this.labelControl5.TabIndex = 999;
            this.labelControl5.Text = "Telefon:";
            // 
            // textEditPhone
            // 
            this.textEditPhone.Location = new System.Drawing.Point(142, 93);
            this.textEditPhone.Name = "textEditPhone";
            this.textEditPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditPhone.Properties.Appearance.Options.UseFont = true;
            this.textEditPhone.Properties.Mask.EditMask = "\\+90 (\\(\\d\\d\\d\\) )\\d\\d\\d-\\d\\d-\\d\\d";
            this.textEditPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditPhone.Size = new System.Drawing.Size(173, 22);
            this.textEditPhone.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 124);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(30, 16);
            this.labelControl6.TabIndex = 999;
            this.labelControl6.Text = "Mail:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(12, 152);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(57, 16);
            this.labelControl7.TabIndex = 999;
            this.labelControl7.Text = "D. Tarihi:";
            // 
            // textEditMail
            // 
            this.textEditMail.Location = new System.Drawing.Point(142, 121);
            this.textEditMail.Name = "textEditMail";
            this.textEditMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditMail.Properties.Appearance.Options.UseFont = true;
            this.textEditMail.Size = new System.Drawing.Size(173, 22);
            this.textEditMail.TabIndex = 4;
            // 
            // dateEditBirthday
            // 
            this.dateEditBirthday.EditValue = null;
            this.dateEditBirthday.Location = new System.Drawing.Point(142, 149);
            this.dateEditBirthday.Name = "dateEditBirthday";
            this.dateEditBirthday.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditBirthday.Properties.Appearance.Options.UseFont = true;
            this.dateEditBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBirthday.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateEditBirthday.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEditBirthday.Size = new System.Drawing.Size(173, 22);
            this.dateEditBirthday.TabIndex = 999;
            this.dateEditBirthday.TabStop = false;
            // 
            // textEditNewPassword
            // 
            this.textEditNewPassword.Location = new System.Drawing.Point(142, 177);
            this.textEditNewPassword.Name = "textEditNewPassword";
            this.textEditNewPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditNewPassword.Properties.Appearance.Options.UseFont = true;
            this.textEditNewPassword.Properties.UseSystemPasswordChar = true;
            this.textEditNewPassword.Size = new System.Drawing.Size(173, 22);
            this.textEditNewPassword.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 180);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 16);
            this.labelControl2.TabIndex = 999;
            this.labelControl2.Text = "Yeni Şifre*:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 208);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(121, 16);
            this.labelControl1.TabIndex = 999;
            this.labelControl1.Text = "Yeni Şifre Tekrar*:";
            // 
            // textEditNewPasswordRepeat
            // 
            this.textEditNewPasswordRepeat.Location = new System.Drawing.Point(142, 205);
            this.textEditNewPasswordRepeat.Name = "textEditNewPasswordRepeat";
            this.textEditNewPasswordRepeat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditNewPasswordRepeat.Properties.Appearance.Options.UseFont = true;
            this.textEditNewPasswordRepeat.Properties.UseSystemPasswordChar = true;
            this.textEditNewPasswordRepeat.Size = new System.Drawing.Size(173, 22);
            this.textEditNewPasswordRepeat.TabIndex = 6;
            // 
            // FormLogInForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(327, 284);
            this.Controls.Add(this.textEditNewPasswordRepeat);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditNewPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButtonResetPassword);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.textEditSsn);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEditName);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textEditSurname);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.textEditPhone);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.textEditMail);
            this.Controls.Add(this.dateEditBirthday);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogInForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Şifremi Unuttum";
            this.Load += new System.EventHandler(this.FormLogInForgotPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditSsn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNewPasswordRepeat.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonResetPassword;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit textEditSsn;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditSurname;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEditPhone;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textEditMail;
        private DevExpress.XtraEditors.DateEdit dateEditBirthday;
        private DevExpress.XtraEditors.TextEdit textEditNewPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditNewPasswordRepeat;
    }
}