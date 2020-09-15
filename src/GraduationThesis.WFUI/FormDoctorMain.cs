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
    public partial class FormDoctorMain : Form
    {
        FormDoctorInfo doctorInfo;
        FormDoctorAppointment doctorAppointment;
        FormDoctorAppointmentHistory doctorAppointmentHistory;
        FormDoctorMedicine doctorMedicine;
        FormMemberChangePassword memberChangePassword;
        Doctor doctor;
        public FormDoctorMain(Doctor doctor)
        {
            InitializeComponent();
            this.doctor = doctor;
            Text = $"Doktor: {doctor.Name} {doctor.Surname}";
        }

        private void FormDoctorMain_Load(object sender, EventArgs e)
        {
            LoadInfoForm();
        }

        private void LoadInfoForm()
        {
            if (doctorInfo == null || doctorInfo.IsDisposed)
            {
                doctorInfo = new FormDoctorInfo(doctor);
                doctorInfo.MdiParent = this;
                doctorInfo.Show();
                MemoryStream mem = new MemoryStream(doctor.Picture);
                barButtonItemInfo.ImageOptions.LargeImage = Image.FromStream(mem);
            }
        }

        private void barButtonItemInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (doctorInfo == null || doctorInfo.IsDisposed)
            {
                doctorInfo = new FormDoctorInfo(doctor);
                doctorInfo.MdiParent = this;
                doctorInfo.Show();
            }
        }

        private void barButtonItemLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormLogInMain logInMain = new FormLogInMain();
            logInMain.Show();
            this.Hide();
        }

        private void barButtonItemAppointment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (doctorAppointment == null || doctorAppointment.IsDisposed)
            {
                doctorAppointment = new FormDoctorAppointment(doctor);
                doctorAppointment.MdiParent = this;
                doctorAppointment.Show();
            }
        }

        private void barButtonItemAppointmentHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (doctorAppointmentHistory == null || doctorAppointmentHistory.IsDisposed)
            {
                doctorAppointmentHistory = new FormDoctorAppointmentHistory(doctor); ;
                doctorAppointmentHistory.MdiParent = this;
                doctorAppointmentHistory.Show();
            }
        }

        private void barButtonItemMedicine_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (doctorMedicine == null || doctorMedicine.IsDisposed)
            {
                doctorMedicine = new FormDoctorMedicine();
                doctorMedicine.MdiParent = this;
                doctorMedicine.Show();
            }
        }

        private void barButtonItemChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            memberChangePassword = new FormMemberChangePassword(doctor);
            memberChangePassword.ShowDialog();
        }

        private void FormDoctorMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
