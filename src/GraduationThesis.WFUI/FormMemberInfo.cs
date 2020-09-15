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
    public partial class FormMemberInfo : Form
    {
        Member member;
        BLLMember bllMember;
        FormMemberInfoUpdate memberInfoUpdate;

        public FormMemberInfo(Member member)
        {
            InitializeComponent();
            bllMember = new BLLMember();
            this.member = member;
        }

        private void FormMemberInfo_Load(object sender, EventArgs e)
        {
            SetDateAndTime();
            ShowPicture();
            SetMemberInfo();
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
            MemoryStream mem = new MemoryStream(member.Picture);
            pictureEditDoctor.Image = Image.FromStream(mem);
        }

        private void SetMemberInfo()
        {
            textEditSsn.Text = member.Ssn;
            textEditName.Text = member.Name;
            textEditSurname.Text = member.Surname;
            textEditGender.Text = BLLHelper.GetEnumDescription(member.Gender);
            dateEditBirthday.DateTime = member.Birthday;
            textEditAge.Text = member.Age.ToString();
            if (member.Height.HasValue) textEditHeight.Text = member.Height.ToString();
            else textEditHeight.Text = string.Empty;
            if (member.Weight.HasValue) textEditWeight.Text = member.Weight.ToString();
            else textEditWeight.Text = string.Empty;
            if (member.DoesSmoke.HasValue)
            {
                if (member.DoesSmoke == true) textEditSmoke.Text = "Evet";
                else textEditSmoke.Text = "Hayır";
            }
            else textEditSmoke.Text = string.Empty;
            textEditPhone.Text = member.Phone;
            textEditMail.Text = member.Mail;
            if (!string.IsNullOrEmpty(member.City) && !string.IsNullOrEmpty(member.County))
            {
                textEditCityCounty.Text = $"{member.City} / {member.County}";
            }
            else
            {
                textEditCityCounty.Text = string.Empty;
            }
        }

        private void FillStatistic()
        {
            {
                List<string> statistics = bllMember.GetStatistic(member);
                labelControlAttendedAppointment.Text = statistics[0];
                labelControlMedicineCount.Text = statistics[1];
                labelControlCancelledAppointment.Text = statistics[2];
                labelControlNotAttendedAppointment.Text = statistics[3];
                if (statistics[4] == "0") labelControlDoctorAgeRange.Text = "N/A";
                else
                {
                    labelControlDoctorAgeRange.Text = statistics[4];
                }
                if (statistics[5] == "0")
                {
                    labelControlOldestDoctorAge.Text = "N/A";
                    labelControlYoungestDoctorAge.Text = "N/A";
                }
                else
                {
                    labelControlOldestDoctorAge.Text = statistics[5];
                    labelControlYoungestDoctorAge.Text = statistics[6];
                }
            }
        }

        private void FillChart()
        {
            {
                Dictionary<string, int> medicineCount = bllMember.GetChartMostUsedMedicine(member);

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
                    chartControlMostUsedMedicine.Visible = false;
                }
                else
                {
                    chartControlMostUsedMedicine.Series["Series 1"].Points.Clear();
                    foreach (var item in medicineCount)
                    {
                        chartControlMostUsedMedicine.Series["Series 1"].Points.AddPoint(item.Key, item.Value);
                    }
                }
            }
            {
                Dictionary<string, int> hospitalCount = bllMember.GetChartMostVisitedHospital(member);

                if (hospitalCount.Count == 0)
                {
                    LabelControl labelControlNoMedicine = new LabelControl();
                    labelControlNoMedicine.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    labelControlNoMedicine.Appearance.Options.UseFont = true;
                    labelControlNoMedicine.Location = new System.Drawing.Point(97, 121);
                    labelControlNoMedicine.Name = "labelControlNoMedicine";
                    labelControlNoMedicine.Size = new System.Drawing.Size(134, 18);
                    labelControlNoMedicine.TabIndex = 999;
                    labelControlNoMedicine.Text = "Hastane bulunamadı...";
                    groupControl5.Controls.Add(labelControlNoMedicine);
                    chartControlMostVisitedHospital.Visible = false;
                }
                else
                {
                    chartControlMostVisitedHospital.Series["Series 1"].Points.Clear();
                    foreach (var item in hospitalCount)
                    {
                        chartControlMostVisitedHospital.Series["Series 1"].Points.AddPoint(item.Key, item.Value);
                    }
                }
            }
        }

        private void simpleButtonUpdatePic_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = xtraOpenFileDialogUpdatePic.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (xtraOpenFileDialogUpdatePic.CheckFileExists)
                {
                    bllMember.MemberInfoUpdate(member, xtraOpenFileDialogUpdatePic.FileName);
                    ShowPicture();
                    MessageBox.Show("Bilgiler butonundaki fotoğrafın değişmesi için hesabınızdan çıkış yapıp tekrar giriş yapmanız gerekmektedir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void simpleButtonUpdateInfo_Click(object sender, EventArgs e)
        {
            memberInfoUpdate = new FormMemberInfoUpdate(member);
            memberInfoUpdate.ShowDialog();
            SetMemberInfo();
        }
    }
}
