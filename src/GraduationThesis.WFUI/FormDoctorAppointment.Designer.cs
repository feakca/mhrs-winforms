namespace GraduationThesis.WFUI
{
    partial class FormDoctorAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoctorAppointment));
            this.listBoxControlAppointment = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textEditSearchMedicine = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.listBoxControlMedicine = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.listBoxControlPrescription = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.textEditCityCounty = new DevExpress.XtraEditors.TextEdit();
            this.textEditBmi = new DevExpress.XtraEditors.TextEdit();
            this.textEditSmoke = new DevExpress.XtraEditors.TextEdit();
            this.textEditAge = new DevExpress.XtraEditors.TextEdit();
            this.textEditGender = new DevExpress.XtraEditors.TextEdit();
            this.textEditNameSurname = new DevExpress.XtraEditors.TextEdit();
            this.textEditSsn = new DevExpress.XtraEditors.TextEdit();
            this.pictureEditMember = new DevExpress.XtraEditors.PictureEdit();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.memoEditDescription = new DevExpress.XtraEditors.MemoEdit();
            this.simpleButtonAttended = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonNotAttended = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSearchMedicine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlPrescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCityCounty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBmi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSmoke.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNameSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSsn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditMember.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxControlAppointment
            // 
            this.listBoxControlAppointment.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxControlAppointment.Appearance.Options.UseFont = true;
            this.listBoxControlAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControlAppointment.Location = new System.Drawing.Point(2, 23);
            this.listBoxControlAppointment.Name = "listBoxControlAppointment";
            this.listBoxControlAppointment.Size = new System.Drawing.Size(256, 482);
            this.listBoxControlAppointment.TabIndex = 999;
            this.listBoxControlAppointment.TabStop = false;
            this.listBoxControlAppointment.SelectedIndexChanged += new System.EventHandler(this.listBoxControlAppointment_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.listBoxControlAppointment);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(260, 507);
            this.groupControl1.TabIndex = 999;
            this.groupControl1.Text = "Saat - İsim Soyisim";
            // 
            // textEditSearchMedicine
            // 
            this.textEditSearchMedicine.EditValue = "İlaç ara...";
            this.textEditSearchMedicine.Location = new System.Drawing.Point(5, 26);
            this.textEditSearchMedicine.Name = "textEditSearchMedicine";
            this.textEditSearchMedicine.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditSearchMedicine.Properties.Appearance.Options.UseFont = true;
            this.textEditSearchMedicine.Size = new System.Drawing.Size(250, 24);
            this.textEditSearchMedicine.TabIndex = 999;
            this.textEditSearchMedicine.TabStop = false;
            this.textEditSearchMedicine.EditValueChanged += new System.EventHandler(this.textEditSearchMedicine_EditValueChanged);
            this.textEditSearchMedicine.Enter += new System.EventHandler(this.textEditSearchMedicine_Enter);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.listBoxControlMedicine);
            this.groupControl2.Controls.Add(this.textEditSearchMedicine);
            this.groupControl2.Location = new System.Drawing.Point(1072, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(260, 507);
            this.groupControl2.TabIndex = 999;
            this.groupControl2.Text = "İlaçlar";
            // 
            // listBoxControlMedicine
            // 
            this.listBoxControlMedicine.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxControlMedicine.Appearance.Options.UseFont = true;
            this.listBoxControlMedicine.Location = new System.Drawing.Point(5, 56);
            this.listBoxControlMedicine.Name = "listBoxControlMedicine";
            this.listBoxControlMedicine.Size = new System.Drawing.Size(250, 446);
            this.listBoxControlMedicine.TabIndex = 999;
            this.listBoxControlMedicine.TabStop = false;
            this.listBoxControlMedicine.DoubleClick += new System.EventHandler(this.listBoxControlMedicine_DoubleClick);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.listBoxControlPrescription);
            this.groupControl3.Location = new System.Drawing.Point(806, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(260, 244);
            this.groupControl3.TabIndex = 999;
            this.groupControl3.Text = "Reçete";
            // 
            // listBoxControlPrescription
            // 
            this.listBoxControlPrescription.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxControlPrescription.Appearance.Options.UseFont = true;
            this.listBoxControlPrescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControlPrescription.Location = new System.Drawing.Point(2, 23);
            this.listBoxControlPrescription.Name = "listBoxControlPrescription";
            this.listBoxControlPrescription.Size = new System.Drawing.Size(256, 219);
            this.listBoxControlPrescription.TabIndex = 999;
            this.listBoxControlPrescription.TabStop = false;
            this.listBoxControlPrescription.DoubleClick += new System.EventHandler(this.listBoxControlPrescription_DoubleClick);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.labelControl6);
            this.groupControl4.Controls.Add(this.labelControl5);
            this.groupControl4.Controls.Add(this.labelControl4);
            this.groupControl4.Controls.Add(this.labelControl3);
            this.groupControl4.Controls.Add(this.labelControl2);
            this.groupControl4.Controls.Add(this.labelControl1);
            this.groupControl4.Controls.Add(this.labelControl13);
            this.groupControl4.Controls.Add(this.textEditCityCounty);
            this.groupControl4.Controls.Add(this.textEditBmi);
            this.groupControl4.Controls.Add(this.textEditSmoke);
            this.groupControl4.Controls.Add(this.textEditAge);
            this.groupControl4.Controls.Add(this.textEditGender);
            this.groupControl4.Controls.Add(this.textEditNameSurname);
            this.groupControl4.Controls.Add(this.textEditSsn);
            this.groupControl4.Controls.Add(this.pictureEditMember);
            this.groupControl4.Location = new System.Drawing.Point(278, 12);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(522, 244);
            this.groupControl4.TabIndex = 999;
            this.groupControl4.Text = "Hasta Bilgileri";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(205, 210);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 18);
            this.labelControl6.TabIndex = 999;
            this.labelControl6.Text = "İl / İlçe:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(205, 180);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 18);
            this.labelControl5.TabIndex = 999;
            this.labelControl5.Text = "BMI:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(205, 150);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 18);
            this.labelControl4.TabIndex = 999;
            this.labelControl4.Text = "Sigara:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(205, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 18);
            this.labelControl3.TabIndex = 999;
            this.labelControl3.Text = "Yaş:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(205, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 18);
            this.labelControl2.TabIndex = 999;
            this.labelControl2.Text = "Cinsiyet:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(205, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 18);
            this.labelControl1.TabIndex = 999;
            this.labelControl1.Text = "İsim Soyisim:";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(205, 30);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(24, 18);
            this.labelControl13.TabIndex = 999;
            this.labelControl13.Text = "TC:";
            // 
            // textEditCityCounty
            // 
            this.textEditCityCounty.Location = new System.Drawing.Point(321, 206);
            this.textEditCityCounty.Name = "textEditCityCounty";
            this.textEditCityCounty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditCityCounty.Properties.Appearance.Options.UseFont = true;
            this.textEditCityCounty.Properties.ReadOnly = true;
            this.textEditCityCounty.Size = new System.Drawing.Size(196, 24);
            this.textEditCityCounty.TabIndex = 999;
            this.textEditCityCounty.TabStop = false;
            // 
            // textEditBmi
            // 
            this.textEditBmi.Location = new System.Drawing.Point(321, 176);
            this.textEditBmi.Name = "textEditBmi";
            this.textEditBmi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditBmi.Properties.Appearance.Options.UseFont = true;
            this.textEditBmi.Properties.ReadOnly = true;
            this.textEditBmi.Size = new System.Drawing.Size(196, 24);
            this.textEditBmi.TabIndex = 999;
            this.textEditBmi.TabStop = false;
            // 
            // textEditSmoke
            // 
            this.textEditSmoke.Location = new System.Drawing.Point(321, 146);
            this.textEditSmoke.Name = "textEditSmoke";
            this.textEditSmoke.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditSmoke.Properties.Appearance.Options.UseFont = true;
            this.textEditSmoke.Properties.ReadOnly = true;
            this.textEditSmoke.Size = new System.Drawing.Size(196, 24);
            this.textEditSmoke.TabIndex = 999;
            this.textEditSmoke.TabStop = false;
            // 
            // textEditAge
            // 
            this.textEditAge.Location = new System.Drawing.Point(321, 116);
            this.textEditAge.Name = "textEditAge";
            this.textEditAge.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditAge.Properties.Appearance.Options.UseFont = true;
            this.textEditAge.Properties.ReadOnly = true;
            this.textEditAge.Size = new System.Drawing.Size(196, 24);
            this.textEditAge.TabIndex = 999;
            this.textEditAge.TabStop = false;
            // 
            // textEditGender
            // 
            this.textEditGender.Location = new System.Drawing.Point(321, 86);
            this.textEditGender.Name = "textEditGender";
            this.textEditGender.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditGender.Properties.Appearance.Options.UseFont = true;
            this.textEditGender.Properties.ReadOnly = true;
            this.textEditGender.Size = new System.Drawing.Size(196, 24);
            this.textEditGender.TabIndex = 999;
            this.textEditGender.TabStop = false;
            // 
            // textEditNameSurname
            // 
            this.textEditNameSurname.Location = new System.Drawing.Point(321, 56);
            this.textEditNameSurname.Name = "textEditNameSurname";
            this.textEditNameSurname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditNameSurname.Properties.Appearance.Options.UseFont = true;
            this.textEditNameSurname.Properties.ReadOnly = true;
            this.textEditNameSurname.Size = new System.Drawing.Size(196, 24);
            this.textEditNameSurname.TabIndex = 999;
            this.textEditNameSurname.TabStop = false;
            // 
            // textEditSsn
            // 
            this.textEditSsn.Location = new System.Drawing.Point(321, 26);
            this.textEditSsn.Name = "textEditSsn";
            this.textEditSsn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditSsn.Properties.Appearance.Options.UseFont = true;
            this.textEditSsn.Properties.ReadOnly = true;
            this.textEditSsn.Size = new System.Drawing.Size(196, 24);
            this.textEditSsn.TabIndex = 999;
            this.textEditSsn.TabStop = false;
            // 
            // pictureEditMember
            // 
            this.pictureEditMember.Location = new System.Drawing.Point(5, 26);
            this.pictureEditMember.Name = "pictureEditMember";
            this.pictureEditMember.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEditMember.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEditMember.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditMember.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEditMember.Size = new System.Drawing.Size(179, 213);
            this.pictureEditMember.TabIndex = 999;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.memoEditDescription);
            this.groupControl5.Location = new System.Drawing.Point(278, 262);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(522, 257);
            this.groupControl5.TabIndex = 999;
            this.groupControl5.Text = "Bulgular";
            // 
            // memoEditDescription
            // 
            this.memoEditDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEditDescription.Location = new System.Drawing.Point(2, 23);
            this.memoEditDescription.Name = "memoEditDescription";
            this.memoEditDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoEditDescription.Properties.Appearance.Options.UseFont = true;
            this.memoEditDescription.Size = new System.Drawing.Size(518, 232);
            this.memoEditDescription.TabIndex = 999;
            this.memoEditDescription.TabStop = false;
            // 
            // simpleButtonAttended
            // 
            this.simpleButtonAttended.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonAttended.Appearance.Options.UseFont = true;
            this.simpleButtonAttended.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButtonAttended.ImageOptions.SvgImage")));
            this.simpleButtonAttended.Location = new System.Drawing.Point(864, 286);
            this.simpleButtonAttended.Name = "simpleButtonAttended";
            this.simpleButtonAttended.Size = new System.Drawing.Size(153, 89);
            this.simpleButtonAttended.TabIndex = 999;
            this.simpleButtonAttended.TabStop = false;
            this.simpleButtonAttended.Tag = "";
            this.simpleButtonAttended.Text = "Geldi";
            this.simpleButtonAttended.Click += new System.EventHandler(this.simpleButtonAttended_Click);
            // 
            // simpleButtonNotAttended
            // 
            this.simpleButtonNotAttended.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonNotAttended.Appearance.Options.UseFont = true;
            this.simpleButtonNotAttended.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButtonNotAttended.ImageOptions.SvgImage")));
            this.simpleButtonNotAttended.Location = new System.Drawing.Point(864, 406);
            this.simpleButtonNotAttended.Name = "simpleButtonNotAttended";
            this.simpleButtonNotAttended.Size = new System.Drawing.Size(153, 88);
            this.simpleButtonNotAttended.TabIndex = 999;
            this.simpleButtonNotAttended.TabStop = false;
            this.simpleButtonNotAttended.Tag = "";
            this.simpleButtonNotAttended.Text = "Gelmedi";
            this.simpleButtonNotAttended.Click += new System.EventHandler(this.simpleButtonNotAttended_Click);
            // 
            // FormDoctorAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 531);
            this.Controls.Add(this.simpleButtonNotAttended);
            this.Controls.Add(this.simpleButtonAttended);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDoctorAppointment";
            this.Text = "Randevular";
            this.Load += new System.EventHandler(this.FormDoctorAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditSearchMedicine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlPrescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCityCounty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBmi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSmoke.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNameSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSsn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditMember.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBoxControlAppointment;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textEditSearchMedicine;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ListBoxControl listBoxControlMedicine;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.ListBoxControl listBoxControlPrescription;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEditMember;
        private DevExpress.XtraEditors.TextEdit textEditSsn;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit textEditCityCounty;
        private DevExpress.XtraEditors.TextEdit textEditBmi;
        private DevExpress.XtraEditors.TextEdit textEditSmoke;
        private DevExpress.XtraEditors.TextEdit textEditAge;
        private DevExpress.XtraEditors.TextEdit textEditGender;
        private DevExpress.XtraEditors.TextEdit textEditNameSurname;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.MemoEdit memoEditDescription;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAttended;
        private DevExpress.XtraEditors.SimpleButton simpleButtonNotAttended;
    }
}