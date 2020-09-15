namespace GraduationThesis.WFUI
{
    partial class FormMemberChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMemberChangePassword));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditOldPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditNewPasswordRepeat = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonChangePassword = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditOldPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNewPasswordRepeat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 18);
            this.labelControl1.TabIndex = 999;
            this.labelControl1.Text = "Eski Şifre:";
            // 
            // textEditOldPassword
            // 
            this.textEditOldPassword.Location = new System.Drawing.Point(167, 10);
            this.textEditOldPassword.Name = "textEditOldPassword";
            this.textEditOldPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditOldPassword.Properties.Appearance.Options.UseFont = true;
            this.textEditOldPassword.Properties.UseSystemPasswordChar = true;
            this.textEditOldPassword.Size = new System.Drawing.Size(170, 24);
            this.textEditOldPassword.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 18);
            this.labelControl2.TabIndex = 999;
            this.labelControl2.Text = "Yeni Şifre:";
            // 
            // textEditNewPassword
            // 
            this.textEditNewPassword.Location = new System.Drawing.Point(167, 40);
            this.textEditNewPassword.Name = "textEditNewPassword";
            this.textEditNewPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditNewPassword.Properties.Appearance.Options.UseFont = true;
            this.textEditNewPassword.Properties.UseSystemPasswordChar = true;
            this.textEditNewPassword.Size = new System.Drawing.Size(170, 24);
            this.textEditNewPassword.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(131, 18);
            this.labelControl3.TabIndex = 999;
            this.labelControl3.Text = "Eski Şifre Tekrar:";
            // 
            // textEditNewPasswordRepeat
            // 
            this.textEditNewPasswordRepeat.Location = new System.Drawing.Point(167, 70);
            this.textEditNewPasswordRepeat.Name = "textEditNewPasswordRepeat";
            this.textEditNewPasswordRepeat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditNewPasswordRepeat.Properties.Appearance.Options.UseFont = true;
            this.textEditNewPasswordRepeat.Properties.UseSystemPasswordChar = true;
            this.textEditNewPasswordRepeat.Size = new System.Drawing.Size(170, 24);
            this.textEditNewPasswordRepeat.TabIndex = 2;
            // 
            // simpleButtonChangePassword
            // 
            this.simpleButtonChangePassword.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonChangePassword.Appearance.Options.UseFont = true;
            this.simpleButtonChangePassword.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButtonChangePassword.ImageOptions.SvgImage")));
            this.simpleButtonChangePassword.Location = new System.Drawing.Point(167, 100);
            this.simpleButtonChangePassword.Name = "simpleButtonChangePassword";
            this.simpleButtonChangePassword.Size = new System.Drawing.Size(170, 43);
            this.simpleButtonChangePassword.TabIndex = 999;
            this.simpleButtonChangePassword.TabStop = false;
            this.simpleButtonChangePassword.Text = "Değiştir";
            this.simpleButtonChangePassword.Click += new System.EventHandler(this.simpleButtonChangePassword_Click);
            // 
            // FormMemberChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(349, 155);
            this.Controls.Add(this.simpleButtonChangePassword);
            this.Controls.Add(this.textEditNewPasswordRepeat);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEditNewPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEditOldPassword);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMemberChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Şifre Değiştir";
            this.Load += new System.EventHandler(this.FormMemberChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditOldPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNewPasswordRepeat.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditOldPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditNewPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditNewPasswordRepeat;
        private DevExpress.XtraEditors.SimpleButton simpleButtonChangePassword;
    }
}