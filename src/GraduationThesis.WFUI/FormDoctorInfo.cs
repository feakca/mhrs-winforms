using DevExpress.XtraEditors;
using GraduationThesis.BusinessLogicLayer;
using GraduationThesis.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraduationThesis.WFUI
{
    public partial class FormDoctorInfo : Form
    {
        Doctor doctor;
        BLLDoctor bllDoctor;
        FormDoctorInfoUpdate doctorInfoUpdate;

        public FormDoctorInfo(Doctor doctor)
        {
            InitializeComponent();
            bllDoctor = new BLLDoctor();
            this.doctor = doctor;
        }

        private void FormDoctorInfo_Load(object sender, EventArgs e)
        {
            SetDateAndTime();
            ShowPicture();
            SetDoctorInfo();
            SetDateEditBirthday();
            FillStatistic();
            FillChart();
        }

        private void SetDateEditBirthday()
        {
            dateEditBirthday.Properties.Mask.Culture = new System.Globalization.CultureInfo("tr-TR");
            dateEditBirthday.Properties.Mask.EditMask = "dd MMMM yyyy";
            dateEditBirthday.Properties.Mask.UseMaskAsDisplayFormat = true;
        }

        private void SetDateAndTime()
        {
            timerDateTime.Interval = 1000;
            timerDateTime.Enabled = true;
            timerDateTime.Tick += TimerDateTime_Tick;
            timerDateTime.Start();
        }

        private void TimerDateTime_Tick(object sender, EventArgs e)
        {
            labelControlDate.Text = DateTime.Now.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("tr-TR"));
            labelControlTime.Text = DateTime.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("tr-TR"));
        }

        private void ShowPicture()
        {
            MemoryStream mem = new MemoryStream(doctor.Picture);
            pictureEditDoctor.Image = Image.FromStream(mem);
        }

        private void simpleButtonUpdatePic_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = xtraOpenFileDialogUpdatePic.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (xtraOpenFileDialogUpdatePic.CheckFileExists)
                {
                    bllDoctor.DoctorInfoUpdate(doctor, xtraOpenFileDialogUpdatePic.FileName);
                    ShowPicture();
                    MessageBox.Show("Bilgiler butonundaki fotoğrafın değişmesi için hesabınızdan çıkış yapıp tekrar giriş yapmanız gerekmektedir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SetDoctorInfo()
        {
            textEditSsn.Text = doctor.Ssn;
            textEditHospital.Text = doctor.Hospital.Name;
            textEditAppellation.Text = BLLHelper.GetEnumDescription(doctor.Appellation);
            textEditExpertise.Text = BLLHelper.GetEnumDescription(doctor.Expertise);
            textEditAgeRange.Text = BLLHelper.GetEnumDescription(doctor.AgeRange);
            textEditName.Text = doctor.Name;
            textEditSurname.Text = doctor.Surname;
            dateEditBirthday.DateTime = doctor.Birthday;
            textEditAge.Text = doctor.Age.ToString();
            textEditPhone.Text = doctor.Phone;
            textEditMail.Text = doctor.Mail;
            if (!string.IsNullOrEmpty(doctor.City) && !string.IsNullOrEmpty(doctor.County))
            {
                textEditCityCounty.Text = $"{doctor.City} / {doctor.County}";
            }
            else
            {
                textEditCityCounty.Text = string.Empty;
            }
        }

        private void simpleButtonUpdateInfo_Click(object sender, EventArgs e)
        {
            doctorInfoUpdate = new FormDoctorInfoUpdate(doctor);
            doctorInfoUpdate.ShowDialog();
            SetDoctorInfo();
        }

        private void FillStatistic()
        {
            {
                List<string> statistics = bllDoctor.GetStatistic(doctor);
                labelControlMemberCount.Text = statistics[0];
                labelControlMedicineCount.Text = statistics[1];
                labelControlCancelledAppointment.Text = statistics[2];
                labelControlNotAttendedAppointment.Text = statistics[3];
                if (statistics[4] == "0") labelControlMemberAgeRange.Text = "N/A";
                else
                {
                    labelControlMemberAgeRange.Text = statistics[4];
                }
                if (statistics[5] == "0" && statistics[6] == "0")
                {
                    labelControlGenderPercentageMan.Text = "N/A";
                    labelControlGenderPercentageWoman.Text = "N/A";
                }
                else
                {
                    labelControlGenderPercentageMan.Text = $"%{statistics[5]}";
                    labelControlGenderPercentageWoman.Text = $"%{statistics[6]}";
                }
            }
        }

        private void FillChart()
        {
            {
                Dictionary<string, int> medicineCount = bllDoctor.GetChartFavoriteMedicine(doctor);

                if (medicineCount.Count == 0)
                {
                    LabelControl labelControlNoMedicine = new LabelControl();
                    labelControlNoMedicine.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    labelControlNoMedicine.Appearance.Options.UseFont = true;
                    labelControlNoMedicine.Location = new System.Drawing.Point(115, 121);
                    labelControlNoMedicine.Name = "labelControlNoMedicine";
                    labelControlNoMedicine.Size = new System.Drawing.Size(134, 18);
                    labelControlNoMedicine.TabIndex = 999;
                    labelControlNoMedicine.Text = "İlaç bulunamadı...";
                    groupControl4.Controls.Add(labelControlNoMedicine);
                    chartControlFavoriteMedicine.Visible = false;
                }
                else
                {
                    chartControlFavoriteMedicine.Series["Series 1"].Points.Clear();
                    foreach (var item in medicineCount)
                    {
                        chartControlFavoriteMedicine.Series["Series 1"].Points.AddPoint(item.Key, item.Value);
                    }
                }
            }
            {
                {

                }
                Dictionary<string, int> ageRanges = bllDoctor.GetChartAgeRange(doctor);
                if (ageRanges.Count == 0)
                {
                    LabelControl labelControlNoMember = new LabelControl();
                    labelControlNoMember.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    labelControlNoMember.Appearance.Options.UseFont = true;
                    labelControlNoMember.Location = new System.Drawing.Point(115, 122);
                    labelControlNoMember.Name = "labelControlNoMember";
                    labelControlNoMember.Size = new System.Drawing.Size(148, 18);
                    labelControlNoMember.TabIndex = 999;
                    labelControlNoMember.Text = "Hasta bulunamadı...";
                    groupControl5.Controls.Add(labelControlNoMember);
                    chartControlAgeRange.Visible = false;
                }
                else
                {
                    if (doctor.AgeRange == DoctorEnumAgeRange._0ve17Arasi)
                    {
                        ageRanges.Remove("18 - 25");
                        ageRanges.Remove("26 - 45");
                        ageRanges.Remove("46 - 64");
                        ageRanges.Remove("65+");
                    }
                    else if (doctor.AgeRange == DoctorEnumAgeRange._18ve65Arasi)
                    {
                        ageRanges.Remove("0 - 8");
                        ageRanges.Remove("9 - 17");
                        ageRanges.Remove("65+");
                    }
                    else
                    {
                        ageRanges.Remove("0 - 8");
                        ageRanges.Remove("9 - 17");
                        ageRanges.Remove("18 - 25");
                        ageRanges.Remove("26 - 45");
                        ageRanges.Remove("46 - 64");
                    }
                    chartControlAgeRange.Series["Series 1"].Points.Clear();
                    foreach (var item in ageRanges)
                    {
                        chartControlAgeRange.Series["Series 1"].Points.AddPoint(item.Key, item.Value);
                    }
                }
            }
        }
    }
}
