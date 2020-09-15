using DevExpress.XtraEditors;
using GraduationThesis.BusinessLogicLayer;
using GraduationThesis.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraduationThesis.WFUI
{
    public partial class FormAdminDoctorNewAndUpdate : Form
    {
        BLLAdmin bllAdmin;
        Doctor doctor;
        int count = 0;
        List<City> cities;
        List<County> counties;
        List<Hospital> hospitals;

        public FormAdminDoctorNewAndUpdate()
        {
            InitializeComponent();
            CreateNewElement();
            bllAdmin = new BLLAdmin();
            cities = new List<City>();
            counties = new List<County>();
            hospitals = new List<Hospital>();
            Text = "Yeni Doktor Kaydı";
        }

        public FormAdminDoctorNewAndUpdate(Doctor doctor)
        {
            InitializeComponent();
            CreateUpdateElement(doctor);
            bllAdmin = new BLLAdmin();
            this.doctor = doctor;
            cities = new List<City>();
            counties = new List<County>();
            Text = "Doktor Kaydı Güncelleme";
        }

        private void FormAdminDoctorNewAndUpdate_Load(object sender, EventArgs e)
        {
            GetCities();
            if (doctor != null) GetCounties(doctor.City);
            GetActiveHospitals();
            FillComboBoxCity();
            FillComboBoxCounty();
            FillComboBoxHospital();
            FillComboBoxAppellation();
            FillComboBoxExpertise();
            FillComboBoxAgeRange();
            SetDateEditBirthday();
            if (doctor != null) FillDoctorInfo(doctor);
        }

        private void SetDateEditBirthday()
        {
            dateEditBirthday.Properties.Mask.Culture = new System.Globalization.CultureInfo("tr-TR");
            dateEditBirthday.Properties.Mask.EditMask = "dd MMMM yyyy";
            dateEditBirthday.Properties.Mask.UseMaskAsDisplayFormat = true;
            dateEditBirthday.DateTime = DateTime.Now;
            dateEditBirthday.Properties.MaxValue = DateTime.Now;
        }

        private void FillDoctorInfo(Doctor doctor)
        {
            textEditSsn.Text = doctor.Ssn;
            comboBoxEditAppellation.SelectedItem = doctor.Appellation.GetEnumDescription();
            comboBoxEditExpertise.SelectedItem = doctor.Expertise.GetEnumDescription();
            comboBoxEditAgeRange.SelectedItem = doctor.AgeRange.GetEnumDescription();
            textEditName.Text = doctor.Name;
            textEditSurname.Text = doctor.Surname;
            dateEditBirthday.DateTime = doctor.Birthday;
            textEditPhone.Text = doctor.Phone;
            textEditMail.Text = doctor.Mail;
            comboBoxEditCity.SelectedItem = cities.Find(I => I.Name == doctor.City);
            comboBoxEditCounty.SelectedItem = counties.Find(I => I.Name == doctor.County);
            comboBoxEditHospital.SelectedItem = hospitals.Find(I => I.Id == doctor.Hospital.Id);
        }

        private void CreateNewElement()
        {
            SimpleButton simpleButtonNewDoctor = new SimpleButton();
            simpleButtonNewDoctor.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            simpleButtonNewDoctor.Appearance.Options.UseFont = true;
            simpleButtonNewDoctor.Location = new System.Drawing.Point(133, 391);
            simpleButtonNewDoctor.Name = "simpleButtonNewDoctor";
            simpleButtonNewDoctor.Size = new System.Drawing.Size(231, 40);
            simpleButtonNewDoctor.TabIndex = 999;
            simpleButtonNewDoctor.TabStop = false;
            simpleButtonNewDoctor.Text = "Doktor Ekle";

            simpleButtonNewDoctor.Click += SimpleButtonNewDoctor_Click;

            Controls.Add(simpleButtonNewDoctor);
        }

        private void SimpleButtonNewDoctor_Click(object sender, EventArgs e)
        {
            int result = bllAdmin.DoctorNewRecord((Hospital)comboBoxEditHospital.SelectedItem, textEditSsn.Text, comboBoxEditAppellation.Text, comboBoxEditExpertise.Text, comboBoxEditAgeRange.Text, textEditName.Text, textEditSurname.Text, dateEditBirthday.DateTime, textEditPhone.Text, textEditMail.Text, comboBoxEditCity.Text, comboBoxEditCounty.Text);
            if (result == 1) MessageBox.Show("Doktor başarıyla kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (result == -1) MessageBox.Show("Lütfen yıldızlı alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -110) MessageBox.Show("Girilen TC sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -111) MessageBox.Show("Girilen telefon sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -112) MessageBox.Show("Girilen mail sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CreateUpdateElement(Doctor doctor)
        {
            LabelControl labelLastUpdate = new LabelControl();
            labelLastUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelLastUpdate.Appearance.Options.UseFont = true;
            labelLastUpdate.Location = new System.Drawing.Point(133, 372);
            labelLastUpdate.Name = "labelLastUpdate";
            labelLastUpdate.Size = new System.Drawing.Size(227, 13);
            labelLastUpdate.TabIndex = 999;
            if (doctor.UpdateTime != null)
            {
                int updateDay = (DateTime.Now - doctor.UpdateTime).Value.Days;
                labelLastUpdate.Text = $"Son güncelleme {updateDay} gün önce yapılmış.";
            }
            else labelLastUpdate.Text = $"Hiç güncelleme yapılmamış.";

            SimpleButton simpleButtonUpdateInfo = new SimpleButton();
            simpleButtonUpdateInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            simpleButtonUpdateInfo.Appearance.Options.UseFont = true;
            simpleButtonUpdateInfo.Location = new System.Drawing.Point(133, 391);
            simpleButtonUpdateInfo.Name = "simpleButtonUpdateInfo";
            simpleButtonUpdateInfo.Size = new System.Drawing.Size(231, 40);
            simpleButtonUpdateInfo.TabIndex = 999;
            simpleButtonUpdateInfo.TabStop = false;
            simpleButtonUpdateInfo.Text = "Bilgileri Güncelle";

            simpleButtonUpdateInfo.Click += SimpleButtonUpdateInfo_Click;

            Controls.Add(labelLastUpdate);
            Controls.Add(simpleButtonUpdateInfo);
        }

        private void SimpleButtonUpdateInfo_Click(object sender, EventArgs e)
        {
            int result = bllAdmin.DoctorUpdateRecord(doctor, (Hospital)comboBoxEditHospital.SelectedItem, textEditSsn.Text, comboBoxEditAppellation.Text, comboBoxEditExpertise.Text, comboBoxEditAgeRange.Text, textEditName.Text, textEditSurname.Text, dateEditBirthday.DateTime, textEditPhone.Text, textEditMail.Text, comboBoxEditCity.Text, comboBoxEditCounty.Text);
            if (result == 1) MessageBox.Show("Doktor bilgileri başarıyla güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (result == -1) MessageBox.Show("Lütfen yıldızlı alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -110) MessageBox.Show("Girilen TC sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -111) MessageBox.Show("Girilen telefon sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -112) MessageBox.Show("Girilen mail sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GetCities()
        {
            cities = BLLHelper.GetCities();
        }

        private void GetCounties(string city)
        {
            if (!string.IsNullOrEmpty(city)) counties = BLLHelper.GetCounties(city);
        }

        private void GetActiveHospitals()
        {
            hospitals = bllAdmin.GetActiveHospitals();
        }

        private void FillComboBoxCity()
        {
            comboBoxEditCity.Properties.Items.AddRange(cities);
        }

        private void FillComboBoxCounty()
        {
            comboBoxEditCounty.Properties.Items.AddRange(counties);
        }

        private void FillComboBoxHospital()
        {
            comboBoxEditHospital.Properties.Items.AddRange(hospitals);
        }

        private void comboBoxEditCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doctor != null)
            {
                if (string.IsNullOrEmpty(doctor.City)) count += 2;
                else count++;
                if (count > 1)
                {
                    comboBoxEditCounty.Properties.Items.Clear();
                    GetCounties(((City)comboBoxEditCity.SelectedItem).Name);
                    FillComboBoxCounty();
                    comboBoxEditCounty.SelectedItem = null;
                }
            }
            else
            {
                comboBoxEditCounty.Properties.Items.Clear();
                GetCounties(((City)comboBoxEditCity.SelectedItem).Name);
                FillComboBoxCounty();
                comboBoxEditCounty.SelectedItem = null;
            }
        }

        private void FillComboBoxAppellation()
        {
            comboBoxEditAppellation.Properties.Items.AddRange(BLLHelper.GetEnumDescriptions<DoctorEnumAppellation>());
        }

        private void FillComboBoxExpertise()
        {
            comboBoxEditExpertise.Properties.Items.AddRange(BLLHelper.GetEnumDescriptions<DoctorEnumExpertise>());
        }

        private void FillComboBoxAgeRange()
        {
            comboBoxEditAgeRange.Properties.Items.AddRange(BLLHelper.GetEnumDescriptions<DoctorEnumAgeRange>());
        }
    }
}
