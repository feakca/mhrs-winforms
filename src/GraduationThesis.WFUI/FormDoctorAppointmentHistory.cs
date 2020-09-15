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
    public partial class FormDoctorAppointmentHistory : Form
    {
        BLLDoctor bllDoctor;
        Doctor doctor;
        FormMemberMyAppointmentPrescription memberMyAppointmentPrescription;
        List<Appointment> appointments;
        public FormDoctorAppointmentHistory(Doctor doctor)
        {
            InitializeComponent();
            this.doctor = doctor;
            bllDoctor = new BLLDoctor();
        }

        private void FormDoctorAppointmentHistory_Load(object sender, EventArgs e)
        {
            GetAppointmentHistorySearch(DateTime.Now.AddDays(-1));
            SetDateTime();
            FillAppointmentHistory();
        }

        private void GetAppointmentHistorySearch(DateTime dateTime)
        {
            appointments = doctor.Appointments.Where(I => I.State != AppointmentEnumState.Future && I.State != AppointmentEnumState.Cancel && I.Time.ToString("dd.MM.yyyy") == dateTime.ToString("dd.MM.yyyy")).OrderByDescending(I => I.Time).ToList();
        }

        private void FillAppointmentHistory()
        {
            gridControlAppointmentHistory.DataSource = appointments;
            gridViewAppointmentHistory.Columns["Id"].Visible = false;
            gridViewAppointmentHistory.Columns["MemberId"].Visible = false;
            gridViewAppointmentHistory.Columns["DoctorId"].Visible = false;
            gridViewAppointmentHistory.Columns["HospitalId"].Visible = false;
            gridViewAppointmentHistory.Columns["CreateTime"].Visible = false;
            gridViewAppointmentHistory.Columns["UpdateTime"].Visible = false;
            gridViewAppointmentHistory.Columns["DeleteTime"].Visible = false;
            gridViewAppointmentHistory.Columns["IsActive"].Visible = false;
            gridViewAppointmentHistory.Columns["Doctor"].Visible = false;
            gridViewAppointmentHistory.Columns["Medicines"].Visible = false;

            gridViewAppointmentHistory.Columns["Time"].Caption = "Randevu Zamanı";
            gridViewAppointmentHistory.Columns["Description"].Caption = "Bulgular";
            gridViewAppointmentHistory.Columns["State"].Caption = "Durum";
            gridViewAppointmentHistory.Columns["Member"].Caption = "Hasta";
            gridViewAppointmentHistory.Columns["Hospital"].Caption = "Hastane";
        }

        private void SetDateTime()
        {
            dateEditAppointmentHistory.Properties.Mask.Culture = new System.Globalization.CultureInfo("tr-TR");
            dateEditAppointmentHistory.Properties.Mask.EditMask = "dd MMMM yyyy";
            dateEditAppointmentHistory.Properties.Mask.UseMaskAsDisplayFormat = true;
            dateEditAppointmentHistory.Properties.MaxValue = DateTime.Now.AddDays(-1);
            dateEditAppointmentHistory.Properties.ShowClear = false;
            dateEditAppointmentHistory.DateTime = DateTime.Now.AddDays(-1);
        }

        private void dateEditAppointmentHistory_DateTimeChanged(object sender, EventArgs e)
        {
            GetAppointmentHistorySearch(dateEditAppointmentHistory.DateTime);
            FillAppointmentHistory();
        }

        private Appointment GetFocusedAppointmentHistory()
        {
            return (Appointment)gridViewAppointmentHistory.GetFocusedRow();
        }

        private void gridViewAppointmentHistory_DoubleClick(object sender, EventArgs e)
        {
            Appointment appointment = GetFocusedAppointmentHistory();
            if (appointment != null)
            {
                memberMyAppointmentPrescription = new FormMemberMyAppointmentPrescription(appointment);
                memberMyAppointmentPrescription.ShowDialog();
            }
        }

        private void FillAppointmentHistoryInfo()
        {
            Appointment appointment = GetFocusedAppointmentHistory();
            if (appointment != null)
            {
                memoEditDescription.Text = appointment.Description;
            }
            else
            {
                memoEditDescription.Text = string.Empty;
            }
        }

        private void gridViewAppointmentHistory_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FillAppointmentHistoryInfo();
        }
    }
}
