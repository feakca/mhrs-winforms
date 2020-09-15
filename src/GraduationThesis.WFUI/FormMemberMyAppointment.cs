using DevExpress.Data;
using DevExpress.XtraCharts;
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
    public partial class FormMemberMyAppointment : Form
    {
        int countFuture = 0;
        int countHistory = 0;
        BLLMember bllMember;
        Member member;
        FormMemberMyAppointmentPrescription memberMyAppointmentPrescription;
        public FormMemberMyAppointment(Member member)
        {
            InitializeComponent();
            this.member = member;
            bllMember = new BLLMember();
        }

        private void FormMemberMyAppointment_Load(object sender, EventArgs e)
        {
            simpleButtonFutureCancel.Enabled = false;
            simpleButtonHistoryPrescription.Enabled = false;
            FillDataGridFutureAppointment();
            FillDataGridHistoryAppointment();
        }

        private List<Appointment> GetFutureAppointments()
        {
            return bllMember.GetFutureAppointments(member);
        }

        private List<Appointment> GetHistoryAppointments()
        {
            return bllMember.GetHistoryAppointments(member);
        }

        private void FillDataGridFutureAppointment()
        {
            gridControlFutureAppointment.DataSource = GetFutureAppointments();
            gridViewFutureAppointment.Columns["Id"].Visible = false;
            gridViewFutureAppointment.Columns["UpdateTime"].Visible = false;
            gridViewFutureAppointment.Columns["DeleteTime"].Visible = false;
            gridViewFutureAppointment.Columns["IsActive"].Visible = false;
            gridViewFutureAppointment.Columns["State"].Visible = false;
            gridViewFutureAppointment.Columns["MemberId"].Visible = false;
            gridViewFutureAppointment.Columns["DoctorId"].Visible = false;
            gridViewFutureAppointment.Columns["HospitalId"].Visible = false;
            gridViewFutureAppointment.Columns["Member"].Visible = false;
            gridViewFutureAppointment.Columns["Medicines"].Visible = false;

            if (countFuture == 0)
            {
                GridColumn columnExpertise = gridViewFutureAppointment.Columns.AddVisible("Expertise", "Bölüm");
                columnExpertise.UnboundType = DevExpress.Data.UnboundColumnType.String;
                countFuture++;
            }

            for (int i = 0; i < gridViewFutureAppointment.RowCount; i++)
            {
                Appointment appointment = (Appointment)gridViewFutureAppointment.GetRow(i);
                gridViewFutureAppointment.SetRowCellValue(i, "Expertise", appointment.Doctor.Expertise);
            }

            gridViewFutureAppointment.Columns["Time"].Caption = "Randevu Zamanı";
            gridViewFutureAppointment.Columns["Description"].Caption = "Açıklama";
            gridViewFutureAppointment.Columns["CreateTime"].Caption = "Oluşturulma Zamanı";
            gridViewFutureAppointment.Columns["Doctor"].Caption = "Doktor";
            gridViewFutureAppointment.Columns["Hospital"].Caption = "Hastane";
        }

        private void FillDataGridHistoryAppointment()
        {
            gridControlHistoryAppointment.DataSource = GetHistoryAppointments();
            gridViewHistoryAppointment.Columns["Id"].Visible = false;
            gridViewHistoryAppointment.Columns["UpdateTime"].Visible = false;
            gridViewHistoryAppointment.Columns["DeleteTime"].Visible = false;
            gridViewHistoryAppointment.Columns["IsActive"].Visible = false;
            gridViewHistoryAppointment.Columns["MemberId"].Visible = false;
            gridViewHistoryAppointment.Columns["DoctorId"].Visible = false;
            gridViewHistoryAppointment.Columns["HospitalId"].Visible = false;
            gridViewHistoryAppointment.Columns["Member"].Visible = false;
            gridViewHistoryAppointment.Columns["Medicines"].Visible = false;

            if (countHistory == 0)
            {
                GridColumn columnExpertise = gridViewHistoryAppointment.Columns.AddVisible("Expertise", "Bölüm");
                columnExpertise.UnboundType = DevExpress.Data.UnboundColumnType.String;
                countHistory++;
            }

            for (int i = 0; i < gridViewHistoryAppointment.RowCount; i++)
            {
                Appointment appointment = (Appointment)gridViewHistoryAppointment.GetRow(i);
                gridViewHistoryAppointment.SetRowCellValue(i, "Expertise", appointment.Doctor.Expertise);
            }

            gridViewHistoryAppointment.Columns["Time"].Caption = "Randevu Zamanı";
            gridViewHistoryAppointment.Columns["Description"].Caption = "Bulgular";
            gridViewHistoryAppointment.Columns["CreateTime"].Caption = "Oluşturulma Zamanı";
            gridViewHistoryAppointment.Columns["Doctor"].Caption = "Doktor";
            gridViewHistoryAppointment.Columns["Hospital"].Caption = "Hastane";
            gridViewHistoryAppointment.Columns["State"].Caption = "Durum";
        }

        private void gridViewFutureAppointment_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            e.Value = BLLHelper.GetEnumDescription(((Appointment)e.Row).Doctor.Expertise);
        }

        private void gridViewHistoryAppointment_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            e.Value = BLLHelper.GetEnumDescription(((Appointment)e.Row).Doctor.Expertise);
        }

        private Appointment GetFocusedFutureAppointment()
        {
            return (Appointment)gridViewFutureAppointment.GetFocusedRow();
        }

        private Appointment GetFocusedHistoryAppointment()
        {
            return (Appointment)gridViewHistoryAppointment.GetFocusedRow();
        }

        private void gridViewFutureAppointment_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FillFutureInfo(GetFocusedFutureAppointment());
        }

        private void gridViewHistoryAppointment_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FillHistoryInfo(GetFocusedHistoryAppointment());
        }

        private void FillFutureInfo(Appointment appointment)
        {
            if (GetFocusedFutureAppointment() != null)
            {
                textEditFutureHospitalName.Text = appointment.Hospital.Name;
                textEditFutureHospitalCityCounty.Text = $"{appointment.Hospital.City} / {appointment.Hospital.County}";
                memoEditFutureHospitalAddress.Text = appointment.Hospital.Address;
                ShowPictureFuture(appointment);
                simpleButtonFutureCancel.Enabled = true;
            }
            else
            {
                textEditFutureHospitalName.Text = string.Empty;
                textEditFutureHospitalCityCounty.Text = string.Empty;
                memoEditFutureHospitalAddress.Text = string.Empty;
                pictureEditFutureHospital.Image = null;
                pictureEditFutureDoctor.Image = null;
                simpleButtonFutureCancel.Enabled = false;
            }
        }

        private void FillHistoryInfo(Appointment appointment)
        {
            if (GetFocusedHistoryAppointment() != null)
            {
                textEditHistoryHospitalName.Text = appointment.Hospital.Name;
                textEditHistoryHospitalCityCounty.Text = $"{appointment.Hospital.City} / {appointment.Hospital.County}";
                memoEditHistoryHospitalAddress.Text = appointment.Hospital.Address;
                ShowPictureHistory(appointment);
                if (appointment.State == AppointmentEnumState.Attended) simpleButtonHistoryPrescription.Enabled = true;
                else simpleButtonHistoryPrescription.Enabled = false;
            }
            else
            {
                textEditHistoryHospitalName.Text = string.Empty;
                textEditHistoryHospitalCityCounty.Text = string.Empty;
                memoEditHistoryHospitalAddress.Text = string.Empty;
                pictureEditHistoryHospital.Image = null;
                pictureEditHistoryDoctor.Image = null;
                simpleButtonHistoryPrescription.Enabled = false;
            }
        }

        private void ShowPictureFuture(Appointment appointment)
        {
            MemoryStream memFutureHospital = new MemoryStream(appointment.Hospital.Picture);
            pictureEditFutureHospital.Image = Image.FromStream(memFutureHospital);

            MemoryStream memFutureDoctor = new MemoryStream(appointment.Doctor.Picture);
            pictureEditFutureDoctor.Image = Image.FromStream(memFutureDoctor);
        }

        private void ShowPictureHistory(Appointment appointment)
        {
            MemoryStream memHistoryHospital = new MemoryStream(appointment.Hospital.Picture);
            pictureEditHistoryHospital.Image = Image.FromStream(memHistoryHospital);

            MemoryStream memHistoryDoctor = new MemoryStream(appointment.Doctor.Picture);
            pictureEditHistoryDoctor.Image = Image.FromStream(memHistoryDoctor);
        }

        private void simpleButtonFutureCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int result = bllMember.CancelAppointment(GetFocusedFutureAppointment());
                if (result == 1)
                {
                    MessageBox.Show("Başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillDataGridFutureAppointment();
                }
                else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle iletişime geçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButtonFutureRefresh_Click(object sender, EventArgs e)
        {
            FillDataGridFutureAppointment();
        }

        private void simpleButtonHistoryRefresh_Click(object sender, EventArgs e)
        {
            FillDataGridHistoryAppointment();
        }

        private void simpleButtonHistoryPrescription_Click(object sender, EventArgs e)
        {
            Appointment appointment = GetFocusedHistoryAppointment();
            if (appointment != null)
            {
                memberMyAppointmentPrescription = new FormMemberMyAppointmentPrescription(appointment);
                memberMyAppointmentPrescription.ShowDialog();
            }
        }
    }
}
