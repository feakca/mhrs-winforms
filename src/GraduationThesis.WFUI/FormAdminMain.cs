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
    public partial class FormAdminMain : Form
    {
        Admin admin;
        FormAdminHospital adminHospital;
        FormAdminDoctor adminDoctor;
        FormAdminMedicine adminMedicine;
        FormAdminAddAdmin adminAddAdmin;
        FormAdminResetPassword adminResetPassword;
        FormAdminDeletedData adminDeletedData;

        public FormAdminMain(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void FormAdminMain_Load(object sender, EventArgs e)
        {
            LoadHospitalForm();
        }

        private void LoadHospitalForm()
        {
            if (adminHospital == null || adminHospital.IsDisposed)
            {
                adminHospital = new FormAdminHospital();
                adminHospital.MdiParent = this;
                adminHospital.Show();
            }
        }

        private void barButtonItemLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormLogInMain logInMain = new FormLogInMain();
            logInMain.Show();
            this.Hide();
        }

        private void barButtonItemHospital_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (adminHospital == null || adminHospital.IsDisposed)
            {
                adminHospital = new FormAdminHospital();
                adminHospital.MdiParent = this;
                adminHospital.Show();
            }
        }

        private void barButtonItemDoctor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (adminDoctor == null || adminDoctor.IsDisposed)
            {
                adminDoctor = new FormAdminDoctor();
                adminDoctor.MdiParent = this;
                adminDoctor.Show();
            }
        }

        private void barButtonItemMedicine_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (adminMedicine == null || adminMedicine.IsDisposed)
            {
                adminMedicine = new FormAdminMedicine();
                adminMedicine.MdiParent = this;
                adminMedicine.Show();
            }
        }

        private void barButtonItemAddAdmin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            adminAddAdmin = new FormAdminAddAdmin();
            adminAddAdmin.ShowDialog();
        }

        private void barButtonItemResetPassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            adminResetPassword = new FormAdminResetPassword();
            adminResetPassword.ShowDialog();
        }

        private void barButtonItemDeletedData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (adminDeletedData == null || adminDeletedData.IsDisposed)
            {
                adminDeletedData = new FormAdminDeletedData();
                adminDeletedData.MdiParent = this;
                adminDeletedData.Show();
            }
        }

        private void FormAdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
