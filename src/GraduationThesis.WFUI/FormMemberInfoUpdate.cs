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
    public partial class FormMemberInfoUpdate : Form
    {
        int count = 0;
        Member member;
        List<City> cities;
        List<County> counties;
        BLLMember bllMember;
        public FormMemberInfoUpdate(Member member)
        {
            InitializeComponent();
            this.member = member;
            bllMember = new BLLMember();
            cities = new List<City>();
            counties = new List<County>();
        }

        private void FormMemberInfoUpdate_Load(object sender, EventArgs e)
        {
            GetCities();
            GetCounties(member.City);
            SetRadioGroupGender();
            SetDateEditBirthday();
            FillComboBoxCity();
            FillComboBoxCounty();
            SetDoctorUpdateInfo();
        }

        private void SetRadioGroupGender()
        {
            radioGroupGender.Properties.Items.AddEnum<MemberEnumGender>();
            radioGroupGender.SelectedIndex = 0;
        }

        private void SetDoctorUpdateInfo()
        {
            textEditName.Text = member.Name;
            textEditSurname.Text = member.Surname;
            if (member.Gender == MemberEnumGender.Erkek) radioGroupGender.SelectedIndex = 1;
            else radioGroupGender.SelectedIndex = 0;
            dateEditBirthday.DateTime = member.Birthday;
            if (member.Height != null) numericUpDownHeight.Value = (decimal)member.Height;
            else numericUpDownHeight.Value = 0;
            if (member.Weight != null) numericUpDownWeight.Value = (decimal)member.Weight;
            else numericUpDownWeight.Value = 0;
            if (member.DoesSmoke.HasValue)
            {
                if (member.DoesSmoke == true)
                {
                    radioGroupSmoke.SelectedIndex = 1;
                }
                else radioGroupSmoke.SelectedIndex = 2;
            }
            else radioGroupSmoke.SelectedIndex = 0;

            textEditPhone.Text = member.Phone;
            textEditMail.Text = member.Mail;
            comboBoxEditCity.SelectedItem = cities.Find(I => I.Name == member.City);
            comboBoxEditCounty.SelectedItem = counties.Find(I => I.Name == member.County);
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

        private void SetDateEditBirthday()
        {
            dateEditBirthday.Properties.Mask.Culture = new System.Globalization.CultureInfo("tr-TR");
            dateEditBirthday.Properties.Mask.EditMask = "dd MMMM yyyy";
            dateEditBirthday.Properties.Mask.UseMaskAsDisplayFormat = true;
            dateEditBirthday.Properties.MaxValue = DateTime.Now;
        }

        private void comboBoxEditCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(member.City)) count += 2;
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
                bool? smoke;
                if (radioGroupSmoke.SelectedIndex == 0) smoke = null;
                else if (radioGroupSmoke.SelectedIndex == 1) smoke = true;
                else smoke = false;
                MemberEnumGender memberGender = (MemberEnumGender)radioGroupGender.Properties.Items[radioGroupGender.SelectedIndex].Value;
                int updateResult = bllMember.MemberInfoUpdate(member, textEditName.Text, textEditSurname.Text, memberGender, dateEditBirthday.DateTime, numericUpDownHeight.Value, numericUpDownWeight.Value, smoke, textEditPhone.Text, textEditMail.Text, comboBoxEditCity.Text, comboBoxEditCounty.Text);
                if (updateResult == 1) MessageBox.Show("Güncelleme işlemi başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (updateResult == -1) MessageBox.Show("Lütfen yıldızlı alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (updateResult == -101) MessageBox.Show("Girilen telefon sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (updateResult == -102) MessageBox.Show("Girilen mail sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
