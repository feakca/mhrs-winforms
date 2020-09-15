namespace GraduationThesis.WFUI
{
    partial class FormAdminAddAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminAddAdmin));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlNextAdmin = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonAddAdmin = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 18);
            this.labelControl1.TabIndex = 999;
            this.labelControl1.Text = "Kullanıcı Adı:";
            // 
            // labelControlNextAdmin
            // 
            this.labelControlNextAdmin.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlNextAdmin.Appearance.Options.UseFont = true;
            this.labelControlNextAdmin.Location = new System.Drawing.Point(131, 12);
            this.labelControlNextAdmin.Name = "labelControlNextAdmin";
            this.labelControlNextAdmin.Size = new System.Drawing.Size(110, 18);
            this.labelControlNextAdmin.TabIndex = 999;
            this.labelControlNextAdmin.Text = "00000000000";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 18);
            this.labelControl3.TabIndex = 999;
            this.labelControl3.Text = "Şifre:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(201, 36);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 18);
            this.labelControl4.TabIndex = 999;
            this.labelControl4.Text = "demo";
            // 
            // simpleButtonAddAdmin
            // 
            this.simpleButtonAddAdmin.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonAddAdmin.Appearance.Options.UseFont = true;
            this.simpleButtonAddAdmin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButtonAddAdmin.ImageOptions.SvgImage")));
            this.simpleButtonAddAdmin.Location = new System.Drawing.Point(12, 74);
            this.simpleButtonAddAdmin.Name = "simpleButtonAddAdmin";
            this.simpleButtonAddAdmin.Size = new System.Drawing.Size(229, 36);
            this.simpleButtonAddAdmin.TabIndex = 999;
            this.simpleButtonAddAdmin.TabStop = false;
            this.simpleButtonAddAdmin.Tag = "";
            this.simpleButtonAddAdmin.Text = "Onayla";
            this.simpleButtonAddAdmin.Click += new System.EventHandler(this.simpleButtonAddAdmin_Click);
            // 
            // FormAdminAddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(253, 136);
            this.Controls.Add(this.simpleButtonAddAdmin);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControlNextAdmin);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdminAddAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yönetici Ekle";
            this.Load += new System.EventHandler(this.FormAdminAddAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControlNextAdmin;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAddAdmin;
    }
}