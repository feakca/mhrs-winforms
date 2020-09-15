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
    public partial class FormDoctorInfoUpdate : Form
    {
        int count = 0;
        Doctor doctor;
        List<City> cities;
        List<County> counties;
        BLLDoctor bllDoctor;
        public FormDoctorInfoUpdate(Doctor doctor)
        {
            InitializeComponent();
            this.doctor = doctor;
            bllDoctor = new BLLDoctor();
            cities = new List<City>();
            counties = new List<County>();
        }

        private void FormDoctorInfoUpdate_Load(object sender, EventArgs e)
        {
            GetCities();
            GetCounties(doctor.City);
            FillComboBoxCity();
            FillComboBoxCounty();
            SetDoctorUpdateInfo();
        }

        private void SetDoctorUpdateInfo()
        {
            textEditPhone.Text = doctor.Phone;
            textEditMail.Text = doctor.Mail;
            comboBoxEditCity.SelectedItem = cities.Find(I => I.Name == doctor.City);
            comboBoxEditCounty.SelectedItem = counties.Find(I => I.Name == doctor.County);
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

        private void simpleButtonUpdateInfo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bilgilerinizi güncellemek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int updateResult = bllDoctor.DoctorInfoUpdate(doctor, textEditPhone.Text, textEditMail.Text, comboBoxEditCity.Text, comboBoxEditCounty.Text);
                if (updateResult == 1) MessageBox.Show("Güncelleme işlemi başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (updateResult == -111) MessageBox.Show("Girilen telefon sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (updateResult == -112) MessageBox.Show("Girilen mail sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
