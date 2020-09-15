using DevExpress.XtraGrid.Columns;
using GraduationThesis.BusinessLogicLayer;
using GraduationThesis.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraduationThesis.WFUI
{
    public partial class FormAdminDoctor : Form
    {
        int count = 0;
        BLLAdmin bllAdmin;
        FormAdminDoctorNewAndUpdate adminDoctorNewAndUpdate;

        public FormAdminDoctor()
        {
            InitializeComponent();
            bllAdmin = new BLLAdmin();
        }

        private void FormAdminDoctor_Load(object sender, EventArgs e)
        {
            SetDateEditBirthday();
            FillDataGridDoctor();
        }

        private void SetDateEditBirthday()
        {
            dateEditBirthday.Properties.Mask.Culture = new System.Globalization.CultureInfo("tr-TR");
            dateEditBirthday.Properties.Mask.EditMask = "dd MMMM yyyy";
            dateEditBirthday.Properties.Mask.UseMaskAsDisplayFormat = true;
        }

        private List<Doctor> GetActiveDoctors()
        {
            return bllAdmin.GetActiveDoctors();
        }

        private void FillDataGridDoctor()
        {
            gridControlDoctor.DataSource = GetActiveDoctors();
            gridViewDoctor.Columns["Id"].Visible = false;
            gridViewDoctor.Columns["Picture"].Visible = false;
            gridViewDoctor.Columns["Password"].Visible = false;
            gridViewDoctor.Columns["CreateTime"].Visible = false;
            gridViewDoctor.Columns["UpdateTime"].Visible = false;
            gridViewDoctor.Columns["DeleteTime"].Visible = false;
            gridViewDoctor.Columns["IsActive"].Visible = false;
            gridViewDoctor.Columns["HospitalId"].Visible = false;
            gridViewDoctor.Columns["Hospital"].Visible = false;
            gridViewDoctor.Columns["Appointments"].Visible = false;

            if (count == 0)
            {
                GridColumn columnHospital = gridViewDoctor.Columns.AddVisible("HospitalName", "Hastane");
                columnHospital.UnboundType = DevExpress.Data.UnboundColumnType.String;
                count++;
            }

            for (int i = 0; i < gridViewDoctor.RowCount; i++)
            {
                Doctor doctor = (Doctor)gridViewDoctor.GetRow(i);
                gridViewDoctor.SetRowCellValue(i, "HospitalName", doctor.Hospital.Name);
            }

            gridViewDoctor.Columns["Ssn"].Caption = "TC";
            gridViewDoctor.Columns["Appellation"].Caption = "Ünvan";
            gridViewDoctor.Columns["Expertise"].Caption = "Uzmanlık";
            gridViewDoctor.Columns["AgeRange"].Caption = "Yaş Aralığı";
            gridViewDoctor.Columns["Name"].Caption = "İsim";
            gridViewDoctor.Columns["Surname"].Caption = "Soyisim";
            gridViewDoctor.Columns["Birthday"].Caption = "D. Tarihi";
            gridViewDoctor.Columns["Age"].Caption = "Yaş";
            gridViewDoctor.Columns["Phone"].Caption = "Telefon";
            gridViewDoctor.Columns["Mail"].Caption = "Mail";
            gridViewDoctor.Columns["City"].Caption = "İl";
            gridViewDoctor.Columns["County"].Caption = "İlçe";
        }

        private void gridViewDoctor_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            e.Value = ((Doctor)e.Row).Hospital.Name;
        }

        private Doctor GetFocusedDoctor()
        {
            return (Doctor)gridViewDoctor.GetFocusedRow();
        }

        private void gridViewDoctor_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FillDoctorInfo(GetFocusedDoctor());
        }

        private void FillDoctorInfo(Doctor doctor)
        {
            if (doctor != null)
            {
                textEditSsn.Text = doctor.Ssn;
                textEditAppellation.Text = BLLHelper.GetEnumDescription(doctor.Appellation);
                textEditExpertise.Text = BLLHelper.GetEnumDescription(doctor.Expertise);
                textEditAgeRange.Text = BLLHelper.GetEnumDescription(doctor.AgeRange);
                textEditNameSurname.Text = $"{doctor.Name} {doctor.Surname}";
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
                ShowPicture(doctor);
            }
            else
            {
                textEditSsn.Text = string.Empty;
                textEditAppellation.Text = string.Empty;
                textEditExpertise.Text = string.Empty;
                textEditAgeRange.Text = string.Empty;
                textEditNameSurname.Text = string.Empty;
                dateEditBirthday.DateTime = DateTime.Now;
                textEditAge.Text = string.Empty;
                textEditPhone.Text = string.Empty;
                textEditMail.Text = string.Empty;
                textEditCityCounty.Text = string.Empty;
                pictureEditDoctor.Image = null;
            }
        }

        private void ShowPicture(Doctor doctor)
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
                    int result = bllAdmin.DoctorUpdateRecord(GetFocusedDoctor(), xtraOpenFileDialogUpdatePic.FileName);
                    if (result == 1)
                    {
                        ShowPicture(GetFocusedDoctor());
                        MessageBox.Show("Doktor resmi başarıyla güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void simpleButtonNewDoctor_Click(object sender, EventArgs e)
        {
            adminDoctorNewAndUpdate = new FormAdminDoctorNewAndUpdate();
            adminDoctorNewAndUpdate.ShowDialog();
            FillDataGridDoctor();
            FillDoctorInfo(GetFocusedDoctor());
        }

        private void simpleButtonUpdateDoctor_Click(object sender, EventArgs e)
        {
            adminDoctorNewAndUpdate = new FormAdminDoctorNewAndUpdate(GetFocusedDoctor());
            adminDoctorNewAndUpdate.ShowDialog();
            FillDataGridDoctor();
            FillDoctorInfo(GetFocusedDoctor());
        }

        private void gridViewDoctor_DoubleClick(object sender, EventArgs e)
        {
            if (GetFocusedDoctor() != null)
            {
                DialogResult res = MessageBox.Show("Silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int result = bllAdmin.DoctorDeleteRecord(GetFocusedDoctor());
                    if (result == 1)
                    {
                        MessageBox.Show("Doktor başarıyla silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillDataGridDoctor();
                        FillDoctorInfo(GetFocusedDoctor());
                    }
                    else if (result == -1)
                    {
                        MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
