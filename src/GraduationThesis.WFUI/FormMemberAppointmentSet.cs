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
    public partial class FormMemberAppointmentSet : Form
    {
        int count = 0;
        BLLMember bllMember;
        Member member;
        List<City> cities;
        List<Hospital> hospitals;
        List<DoctorEnumExpertise> expertises;
        List<Doctor> doctors;

        public FormMemberAppointmentSet(Member member)
        {
            InitializeComponent();
            this.member = member;
            bllMember = new BLLMember();
            cities = new List<City>();
            hospitals = new List<Hospital>();
            expertises = new List<DoctorEnumExpertise>();
            doctors = new List<Doctor>();
        }

        private void FormMemberAppointmentSet_Load(object sender, EventArgs e)
        {
            GetCities();
            FillComboBoxCity();
            SetDateTimeGroup();
        }

        private void GetCities()
        {
            cities = bllMember.GetHospitalCities();
        }

        private void GetSelectedCityHospitals()
        {
            if ((City)comboBoxEditCity.SelectedItem != null)
            {
                hospitals = bllMember.GetSelectedCityHospitals((City)comboBoxEditCity.SelectedItem);
            }
            else
            {
                hospitals.Clear();
            }
        }

        private void GetSelectedHospitalExpertises()
        {
            if ((Hospital)listBoxControlHospital.SelectedItem != null)
            {
                expertises = bllMember.GetSelectedHospitalExpertises((Hospital)listBoxControlHospital.SelectedItem, member);
            }
            else
            {
                expertises.Clear();
            }
        }

        private void GetSelectedHospitalExpertiseDoctors()
        {
            if (listBoxControlHospital.SelectedItem != null && listBoxControlExpertise.SelectedItem != null)
            {
                doctors = bllMember.GetSelectedHospitalExpertiseDoctors((Hospital)listBoxControlHospital.SelectedItem, (DoctorEnumExpertise)listBoxControlExpertise.SelectedItem, member);
            }
            else
            {
                doctors.Clear();
            }
        }

        private void FillComboBoxCity()
        {
            comboBoxEditCity.Properties.Items.AddRange(cities);
        }

        private void FillListBoxHospital()
        {
            foreach (var item in hospitals)
            {
                listBoxControlHospital.Items.Add(item);
            }
        }

        private void FillListBoxExpertise()
        {
            foreach (var item in expertises)
            {
                listBoxControlExpertise.Items.Add(item);
            }
        }

        private void FillListBoxDoctor()
        {
            foreach (var item in doctors)
            {
                listBoxControlDoctor.Items.Add(item);
            }
        }

        private void comboBoxEditCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxControlDoctor.Items.Clear();
            listBoxControlExpertise.Items.Clear();
            listBoxControlHospital.Items.Clear();
            GetSelectedCityHospitals();
            FillListBoxHospital();
        }

        private void listBoxControlHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxControlDoctor.Items.Clear();
            listBoxControlExpertise.Items.Clear();
            GetSelectedHospitalExpertises();
            FillListBoxExpertise();
        }

        private void listBoxControlExpertise_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxControlDoctor.Items.Clear();
            doctors.Clear();
            GetSelectedHospitalExpertiseDoctors();
            FillListBoxDoctor();
        }

        private void SetDateTimeGroup()
        {
            dateEditAppointment.Enabled = false;
            simpleButtonAppointmentSet.Enabled = false;
            simpleButtonRefresh.Enabled = false;
            dateEditAppointment.Properties.Mask.Culture = new System.Globalization.CultureInfo("tr-TR");
            dateEditAppointment.Properties.Mask.EditMask = "dd MMMM yyyy";
            dateEditAppointment.Properties.Mask.UseMaskAsDisplayFormat = true;
            dateEditAppointment.Properties.MinValue = DateTime.Now.AddDays(1);
            dateEditAppointment.Properties.MaxValue = DateTime.Now.AddDays(15);
            dateEditAppointment.Properties.ShowClear = false;
            dateEditAppointment.DateTime = DateTime.Now.AddDays(1);

            foreach (var item in groupControlDateTime.Controls)
            {
                if (item is CheckButton)
                {
                    ((CheckButton)item).Enabled = false;
                    ((CheckButton)item).GroupIndex = 0;
                }
            }
        }

        private DateTime CreateAppointmentDateTime()
        {
            string appointmentDateTimeString = dateEditAppointment.DateTime.ToString("dd.MM.yyyy");

            foreach (var item in groupControlDateTime.Controls)
            {
                if (item is CheckButton)
                {
                    if (((CheckButton)item).Checked == true)
                    {
                        appointmentDateTimeString += $" {((CheckButton)item).Text}";
                    }
                }
            }
            return DateTime.Parse(appointmentDateTimeString, new System.Globalization.CultureInfo("tr-TR"));
        }

        private void simpleButtonAppointmentSet_Click(object sender, EventArgs e)
        {
            DateTime appointmentDateTime = CreateAppointmentDateTime();
            if (appointmentDateTime.Hour == 0)
            {
                MessageBox.Show("Lütfen randevu saatini seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int result = bllMember.SetNewAppointment(appointmentDateTime, member, (Doctor)listBoxControlDoctor.SelectedItem, (Hospital)listBoxControlHospital.SelectedItem);
                if (result == 1)
                {
                    MessageBox.Show("Randevunuz başarıyla kaydedilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxEditCity.SelectedItem = null;
                    comboBoxEditCity.Text = "İl seçimi yapınız...";
                }
                else
                {
                    MessageBox.Show("Seçmiş olduğunuz saate bir başkası randevu almıştır. Lütfen yenileyip tekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void GetSelectableAppointmentTime()
        {
            if (count > 0)
            {
                foreach (var item in groupControlDateTime.Controls)
                {
                    if (item is CheckButton)
                    {
                        ((CheckButton)item).Enabled = true;
                        ((CheckButton)item).AllowAllUnchecked = true;
                        ((CheckButton)item).Checked = false;
                    }
                }

                dateEditAppointment.Enabled = true;
                simpleButtonAppointmentSet.Enabled = true;
                simpleButtonRefresh.Enabled = true;
                List<string> times = new List<string>();
                times = bllMember.GetSelectableAppointmentTime(dateEditAppointment.DateTime, (Doctor)listBoxControlDoctor.SelectedItem);
                foreach (var time in times)
                {
                    foreach (var checkButton in groupControlDateTime.Controls)
                    {
                        if (checkButton is CheckButton)
                        {
                            if (((CheckButton)checkButton).Text == time)
                            {
                                ((CheckButton)checkButton).Enabled = false;
                                break;
                            }
                        }
                    }
                }
                if (times.Count == 0)
                {
                    foreach (var checkButton in groupControlDateTime.Controls)
                    {
                        if (checkButton is CheckButton)
                        {
                            ((CheckButton)checkButton).Enabled = true;
                            ((CheckButton)checkButton).AllowAllUnchecked = true;
                            ((CheckButton)checkButton).Checked = false;
                        }
                    }
                }
            }
            count++;
        }

        private void listBoxControlDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxControlDoctor.SelectedItem == null)
            {
                dateEditAppointment.Enabled = false;
                simpleButtonAppointmentSet.Enabled = false;
                simpleButtonRefresh.Enabled = false;
                foreach (var item in groupControlDateTime.Controls)
                {
                    if (item is CheckButton)
                    {
                        ((CheckButton)item).Enabled = false;
                    }
                }
            }
            else
            {
                dateEditAppointment.DateTime = DateTime.Now.AddDays(1);
                GetSelectableAppointmentTime();
            }
        }

        private void dateEditAppointment_DateTimeChanged(object sender, EventArgs e)
        {
            GetSelectableAppointmentTime();
        }

        private void simpleButtonRefresh_Click(object sender, EventArgs e)
        {
            GetSelectableAppointmentTime();
        }
    }
}
