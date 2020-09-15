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
    public partial class FormAdminHospitalNewAndUpdate : Form
    {
        BLLAdmin bllAdmin;
        Hospital hospital;
        int count = 0;
        List<City> cities;
        List<County> counties;

        public FormAdminHospitalNewAndUpdate()
        {
            InitializeComponent();
            CreateNewElement();
            bllAdmin = new BLLAdmin();
            cities = new List<City>();
            counties = new List<County>();
            Text = "Yeni Hastane Kaydı";
        }

        public FormAdminHospitalNewAndUpdate(Hospital hospital)
        {
            InitializeComponent();
            CreateUpdateElement(hospital);
            bllAdmin = new BLLAdmin();
            this.hospital = hospital;
            cities = new List<City>();
            counties = new List<County>();
            Text = "Hastane Kaydı Güncelleme";
        }

        private void FormAdminHospitalNewAndUpdate_Load(object sender, EventArgs e)
        {
            GetCities();
            if (hospital != null) GetCounties(hospital.City);
            FillComboBoxCity();
            FillComboBoxCounty();
            if (hospital != null) FillHospitalInfo(hospital);
        }

        private void FillHospitalInfo(Hospital hospital)
        {
            textEditName.Text = hospital.Name;
            if (hospital.NumberOfBed == null)
            {
                numericUpDownNumberOfBed.Value = 0;
            }
            else
            {
                numericUpDownNumberOfBed.Value = (decimal)hospital.NumberOfBed;
            }
            textEditPhoneI.Text = hospital.PhoneI;
            textEditPhoneII.Text = hospital.PhoneII;
            textEditPhoneIII.Text = hospital.PhoneIII;
            textEditMail.Text = hospital.Mail;
            textEditWebsite.Text = hospital.Website;
            memoEditAddress.Text = hospital.Address;
            comboBoxEditCity.SelectedItem = cities.Find(I => I.Name == hospital.City);
            comboBoxEditCounty.SelectedItem = counties.Find(I => I.Name == hospital.County);
        }

        private void CreateNewElement()
        {
            SimpleButton simpleButtonNewHospital = new SimpleButton();
            simpleButtonNewHospital.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            simpleButtonNewHospital.Appearance.Options.UseFont = true;
            simpleButtonNewHospital.Location = new System.Drawing.Point(116, 426);
            simpleButtonNewHospital.Name = "simpleButtonNewHospital";
            simpleButtonNewHospital.Size = new System.Drawing.Size(225, 40);
            simpleButtonNewHospital.TabIndex = 999;
            simpleButtonNewHospital.TabStop = false;
            simpleButtonNewHospital.Text = "Hastane Ekle";

            simpleButtonNewHospital.Click += SimpleButtonNewHospital_Click;

            Controls.Add(simpleButtonNewHospital);
        }

        private void SimpleButtonNewHospital_Click(object sender, EventArgs e)
        {
            int result = bllAdmin.HospitalNewRecord(textEditName.Text, numericUpDownNumberOfBed.Value, textEditPhoneI.Text, textEditPhoneII.Text, textEditPhoneIII.Text, textEditMail.Text, textEditWebsite.Text, comboBoxEditCity.Text, comboBoxEditCounty.Text, memoEditAddress.Text);
            if (result == 1) MessageBox.Show("Hastane başarıyla kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (result == -1) MessageBox.Show("Lütfen yıldızlı alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -104) MessageBox.Show("Girilen hastane ismi sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -105) MessageBox.Show("Girilen ilk telefon sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -106) MessageBox.Show("Girilen ikinci telefon sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -107) MessageBox.Show("Girilen üçüncü telefon sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -108) MessageBox.Show("Girilen mail sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -109) MessageBox.Show("Girilen adres sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CreateUpdateElement(Hospital hospital)
        {
            LabelControl labelLastUpdate = new LabelControl();
            labelLastUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelLastUpdate.Appearance.Options.UseFont = true;
            labelLastUpdate.Location = new System.Drawing.Point(116, 396);
            labelLastUpdate.Name = "labelLastUpdate";
            labelLastUpdate.Size = new System.Drawing.Size(227, 13);
            labelLastUpdate.TabIndex = 999;
            if (hospital.UpdateTime != null)
            {
                int updateDay = (DateTime.Now - hospital.UpdateTime).Value.Days;
                labelLastUpdate.Text = $"Son güncelleme {updateDay} gün önce yapılmış.";
            }
            else labelLastUpdate.Text = $"Hiç güncelleme yapılmamış.";

            SimpleButton simpleButtonUpdateInfo = new SimpleButton();
            simpleButtonUpdateInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            simpleButtonUpdateInfo.Appearance.Options.UseFont = true;
            simpleButtonUpdateInfo.Location = new System.Drawing.Point(116, 426);
            simpleButtonUpdateInfo.Name = "simpleButtonUpdateInfo";
            simpleButtonUpdateInfo.Size = new System.Drawing.Size(225, 40);
            simpleButtonUpdateInfo.TabIndex = 999;
            simpleButtonUpdateInfo.TabStop = false;
            simpleButtonUpdateInfo.Text = "Bilgileri Güncelle";

            simpleButtonUpdateInfo.Click += SimpleButtonUpdateInfo_Click;

            Controls.Add(labelLastUpdate);
            Controls.Add(simpleButtonUpdateInfo);
        }

        private void SimpleButtonUpdateInfo_Click(object sender, EventArgs e)
        {
            int result = bllAdmin.HospitalUpdateRecord(hospital, textEditName.Text, numericUpDownNumberOfBed.Value, textEditPhoneI.Text, textEditPhoneII.Text, textEditPhoneIII.Text, textEditMail.Text, textEditWebsite.Text, comboBoxEditCity.Text, comboBoxEditCounty.Text, memoEditAddress.Text);
            if (result == 1) MessageBox.Show("Hastane bilgileri başarıyla güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (result == -1) MessageBox.Show("Lütfen yıldızlı alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -104) MessageBox.Show("Girilen hastane ismi sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -105) MessageBox.Show("Girilen ilk telefon sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -106) MessageBox.Show("Girilen ikinci telefon sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -107) MessageBox.Show("Girilen üçüncü telefon sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -108) MessageBox.Show("Girilen mail sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -109) MessageBox.Show("Girilen adres sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void FillComboBoxCity()
        {
            comboBoxEditCity.Properties.Items.AddRange(cities);
        }

        private void FillComboBoxCounty()
        {
            comboBoxEditCounty.Properties.Items.AddRange(counties);
        }

        private void comboBoxEditCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hospital != null)
            {
                if (string.IsNullOrEmpty(hospital.City)) count += 2;
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
    }
}
