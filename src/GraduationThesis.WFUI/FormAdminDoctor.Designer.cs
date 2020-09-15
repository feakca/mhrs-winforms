namespace GraduationThesis.WFUI
{
    partial class FormAdminDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminDoctor));
            this.xtraOpenFileDialogUpdatePic = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.simpleButtonNewDoctor = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonUpdateDoctor = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonUpdatePic = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEditDoctor = new DevExpress.XtraEditors.PictureEdit();
            this.textEditCityCounty = new DevExpress.XtraEditors.TextEdit();
            this.textEditAgeRange = new DevExpress.XtraEditors.TextEdit();
            this.textEditAge = new DevExpress.XtraEditors.TextEdit();
            this.textEditNameSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEditExpertise = new DevExpress.XtraEditors.TextEdit();
            this.gridControlDoctor = new DevExpress.XtraGrid.GridControl();
            this.gridViewDoctor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditSsn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.textEditAppellation = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dateEditBirthday = new DevExpress.XtraEditors.DateEdit();
            this.textEditMail = new DevExpress.XtraEditors.TextEdit();
            this.textEditPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditDoctor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCityCounty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAgeRange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNameSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditExpertise.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSsn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAppellation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraOpenFileDialogUpdatePic
            // 
            this.xtraOpenFileDialogUpdatePic.Filter = "Resim | *.jpg; *.jpeg; *.png";
            this.xtraOpenFileDialogUpdatePic.Title = "Profil fotoğrafınızı seçiniz:";
            // 
            // simpleButtonNewDoctor
            // 
            this.simpleButtonNewDoctor.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonNewDoctor.Appearance.Options.UseFont = true;
            this.simpleButtonNewDoctor.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButtonNewDoctor.ImageOptions.SvgImage")));
            this.simpleButtonNewDoctor.Location = new System.Drawing.Point(129, 454);
            this.simpleButtonNewDoctor.Name = "simpleButtonNewDoctor";
            this.simpleButtonNewDoctor.Size = new System.Drawing.Size(100, 36);
            this.simpleButtonNewDoctor.TabIndex = 999;
            this.simpleButtonNewDoctor.TabStop = false;
            this.simpleButtonNewDoctor.Tag = "";
            this.simpleButtonNewDoctor.Text = "Yeni";
            this.simpleButtonNewDoctor.Click += new System.EventHandler(this.simpleButtonNewDoctor_Click);
            // 
            // simpleButtonUpdateDoctor
            // 
            this.simpleButtonUpdateDoctor.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonUpdateDoctor.Appearance.Options.UseFont = true;
            this.simpleButtonUpdateDoctor.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButtonUpdateDoctor.ImageOptions.SvgImage")));
            this.simpleButtonUpdateDoctor.Location = new System.Drawing.Point(238, 454);
            this.simpleButtonUpdateDoctor.Name = "simpleButtonUpdateDoctor";
            this.simpleButtonUpdateDoctor.Size = new System.Drawing.Size(100, 36);
            this.simpleButtonUpdateDoctor.TabIndex = 999;
            this.simpleButtonUpdateDoctor.TabStop = false;
            this.simpleButtonUpdateDoctor.Tag = "";
            this.simpleButtonUpdateDoctor.Text = "Güncelle";
            this.simpleButtonUpdateDoctor.Click += new System.EventHandler(this.simpleButtonUpdateDoctor_Click);
            // 
            // simpleButtonUpdatePic
            // 
            this.simpleButtonUpdatePic.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonUpdatePic.Appearance.Options.UseFont = true;
            this.simpleButtonUpdatePic.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButtonUpdatePic.ImageOptions.SvgImage")));
            this.simpleButtonUpdatePic.Location = new System.Drawing.Point(7, 62);
            this.simpleButtonUpdatePic.Name = "simpleButtonUpdatePic";
            this.simpleButtonUpdatePic.Size = new System.Drawing.Size(116, 61);
            this.simpleButtonUpdatePic.TabIndex = 999;
            this.simpleButtonUpdatePic.TabStop = false;
            this.simpleButtonUpdatePic.Text = "Resmi\r\nGüncelle";
            this.simpleButtonUpdatePic.Click += new System.EventHandler(this.simpleButtonUpdatePic_Click);
            // 
            // pictureEditDoctor
            // 
            this.pictureEditDoctor.Location = new System.Drawing.Point(129, 26);
            this.pictureEditDoctor.Name = "pictureEditDoctor";
            this.pictureEditDoctor.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEditDoctor.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEditDoctor.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditDoctor.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEditDoctor.Size = new System.Drawing.Size(209, 122);
            this.pictureEditDoctor.TabIndex = 999;
            // 
            // textEditCityCounty
            // 
            this.textEditCityCounty.Location = new System.Drawing.Point(129, 424);
            this.textEditCityCounty.Name = "textEditCityCounty";
            this.textEditCityCounty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditCityCounty.Properties.Appearance.Options.UseFont = true;
            this.textEditCityCounty.Properties.ReadOnly = true;
            this.textEditCityCounty.Size = new System.Drawing.Size(209, 24);
            this.textEditCityCounty.TabIndex = 999;
            this.textEditCityCounty.TabStop = false;
            // 
            // textEditAgeRange
            // 
            this.textEditAgeRange.Location = new System.Drawing.Point(129, 244);
            this.textEditAgeRange.Name = "textEditAgeRange";
            this.textEditAgeRange.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditAgeRange.Properties.Appearance.Options.UseFont = true;
            this.textEditAgeRange.Properties.ReadOnly = true;
            this.textEditAgeRange.Size = new System.Drawing.Size(209, 24);
            this.textEditAgeRange.TabIndex = 999;
            this.textEditAgeRange.TabStop = false;
            // 
            // textEditAge
            // 
            this.textEditAge.Location = new System.Drawing.Point(129, 334);
            this.textEditAge.Name = "textEditAge";
            this.textEditAge.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditAge.Properties.Appearance.Options.UseFont = true;
            this.textEditAge.Properties.ReadOnly = true;
            this.textEditAge.Size = new System.Drawing.Size(209, 24);
            this.textEditAge.TabIndex = 999;
            this.textEditAge.TabStop = false;
            // 
            // textEditNameSurname
            // 
            this.textEditNameSurname.Location = new System.Drawing.Point(129, 274);
            this.textEditNameSurname.Name = "textEditNameSurname";
            this.textEditNameSurname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditNameSurname.Properties.Appearance.Options.UseFont = true;
            this.textEditNameSurname.Properties.ReadOnly = true;
            this.textEditNameSurname.Size = new System.Drawing.Size(209, 24);
            this.textEditNameSurname.TabIndex = 999;
            this.textEditNameSurname.TabStop = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(7, 427);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 18);
            this.labelControl6.TabIndex = 999;
            this.labelControl6.Text = "İl / İlçe:";
            // 
            // textEditExpertise
            // 
            this.textEditExpertise.Location = new System.Drawing.Point(129, 214);
            this.textEditExpertise.Name = "textEditExpertise";
            this.textEditExpertise.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditExpertise.Properties.Appearance.Options.UseFont = true;
            this.textEditExpertise.Properties.ReadOnly = true;
            this.textEditExpertise.Size = new System.Drawing.Size(209, 24);
            this.textEditExpertise.TabIndex = 999;
            this.textEditExpertise.TabStop = false;
            // 
            // gridControlDoctor
            // 
            this.gridControlDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDoctor.Location = new System.Drawing.Point(2, 23);
            this.gridControlDoctor.MainView = this.gridViewDoctor;
            this.gridControlDoctor.Name = "gridControlDoctor";
            this.gridControlDoctor.Size = new System.Drawing.Size(964, 482);
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
            this.gridViewDoctor.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewDoctor_FocusedRowChanged);
            this.gridViewDoctor.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridViewDoctor_CustomUnboundColumnData);
            this.gridViewDoctor.DoubleClick += new System.EventHandler(this.gridViewDoctor_DoubleClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlDoctor);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(968, 507);
            this.groupControl2.TabIndex = 999;
            this.groupControl2.Text = "Doktor Listesi";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(7, 307);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 18);
            this.labelControl4.TabIndex = 999;
            this.labelControl4.Text = "D. Tarihi:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(7, 337);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 18);
            this.labelControl5.TabIndex = 999;
            this.labelControl5.Text = "Yaş:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 247);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 18);
            this.labelControl2.TabIndex = 999;
            this.labelControl2.Text = "Yaş Aralığı:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(7, 277);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 18);
            this.labelControl3.TabIndex = 999;
            this.labelControl3.Text = "İsim Soyisim:";
            // 
            // textEditSsn
            // 
            this.textEditSsn.Location = new System.Drawing.Point(129, 154);
            this.textEditSsn.Name = "textEditSsn";
            this.textEditSsn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditSsn.Properties.Appearance.Options.UseFont = true;
            this.textEditSsn.Properties.ReadOnly = true;
            this.textEditSsn.Size = new System.Drawing.Size(209, 24);
            this.textEditSsn.TabIndex = 999;
            this.textEditSsn.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(7, 217);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 18);
            this.labelControl1.TabIndex = 999;
            this.labelControl1.Text = "Uzmanlık:";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(7, 187);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(52, 18);
            this.labelControl15.TabIndex = 999;
            this.labelControl15.Text = "Ünvan:";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(7, 157);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(24, 18);
            this.labelControl14.TabIndex = 999;
            this.labelControl14.Text = "TC:";
            // 
            // textEditAppellation
            // 
            this.textEditAppellation.Location = new System.Drawing.Point(129, 184);
            this.textEditAppellation.Name = "textEditAppellation";
            this.textEditAppellation.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditAppellation.Properties.Appearance.Options.UseFont = true;
            this.textEditAppellation.Properties.ReadOnly = true;
            this.textEditAppellation.Size = new System.Drawing.Size(209, 24);
            this.textEditAppellation.TabIndex = 999;
            this.textEditAppellation.TabStop = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dateEditBirthday);
            this.groupControl1.Controls.Add(this.simpleButtonNewDoctor);
            this.groupControl1.Controls.Add(this.simpleButtonUpdateDoctor);
            this.groupControl1.Controls.Add(this.simpleButtonUpdatePic);
            this.groupControl1.Controls.Add(this.pictureEditDoctor);
            this.groupControl1.Controls.Add(this.textEditCityCounty);
            this.groupControl1.Controls.Add(this.textEditAgeRange);
            this.groupControl1.Controls.Add(this.textEditMail);
            this.groupControl1.Controls.Add(this.textEditPhone);
            this.groupControl1.Controls.Add(this.textEditAge);
            this.groupControl1.Controls.Add(this.textEditNameSurname);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.textEditExpertise);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.textEditAppellation);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textEditSsn);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Location = new System.Drawing.Point(986, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(346, 507);
            this.groupControl1.TabIndex = 999;
            this.groupControl1.Text = "Bilgiler";
            // 
            // dateEditBirthday
            // 
            this.dateEditBirthday.EditValue = null;
            this.dateEditBirthday.Location = new System.Drawing.Point(129, 304);
            this.dateEditBirthday.Name = "dateEditBirthday";
            this.dateEditBirthday.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditBirthday.Properties.Appearance.Options.UseFont = true;
            this.dateEditBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBirthday.Properties.ReadOnly = true;
            this.dateEditBirthday.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEditBirthday.Size = new System.Drawing.Size(209, 24);
            this.dateEditBirthday.TabIndex = 999;
            this.dateEditBirthday.TabStop = false;
            // 
            // textEditMail
            // 
            this.textEditMail.Location = new System.Drawing.Point(129, 394);
            this.textEditMail.Name = "textEditMail";
            this.textEditMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditMail.Properties.Appearance.Options.UseFont = true;
            this.textEditMail.Properties.ReadOnly = true;
            this.textEditMail.Size = new System.Drawing.Size(209, 24);
            this.textEditMail.TabIndex = 999;
            this.textEditMail.TabStop = false;
            // 
            // textEditPhone
            // 
            this.textEditPhone.Location = new System.Drawing.Point(129, 364);
            this.textEditPhone.Name = "textEditPhone";
            this.textEditPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditPhone.Properties.Appearance.Options.UseFont = true;
            this.textEditPhone.Properties.ReadOnly = true;
            this.textEditPhone.Size = new System.Drawing.Size(209, 24);
            this.textEditPhone.TabIndex = 999;
            this.textEditPhone.TabStop = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(7, 397);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(37, 18);
            this.labelControl8.TabIndex = 999;
            this.labelControl8.Text = "Mail:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(7, 367);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(61, 18);
            this.labelControl7.TabIndex = 999;
            this.labelControl7.Text = "Telefon:";
            // 
            // FormAdminDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 531);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdminDoctor";
            this.Text = "Doktorlar";
            this.Load += new System.EventHandler(this.FormAdminDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditDoctor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCityCounty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAgeRange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNameSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditExpertise.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditSsn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAppellation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialogUpdatePic;
        private DevExpress.XtraEditors.SimpleButton simpleButtonNewDoctor;
        private DevExpress.XtraEditors.SimpleButton simpleButtonUpdateDoctor;
        private DevExpress.XtraEditors.SimpleButton simpleButtonUpdatePic;
        private DevExpress.XtraEditors.PictureEdit pictureEditDoctor;
        private DevExpress.XtraEditors.TextEdit textEditCityCounty;
        private DevExpress.XtraEditors.TextEdit textEditAgeRange;
        private DevExpress.XtraEditors.TextEdit textEditAge;
        private DevExpress.XtraEditors.TextEdit textEditNameSurname;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEditExpertise;
        private DevExpress.XtraGrid.GridControl gridControlDoctor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDoctor;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditSsn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit textEditAppellation;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textEditMail;
        private DevExpress.XtraEditors.TextEdit textEditPhone;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit dateEditBirthday;
    }
}