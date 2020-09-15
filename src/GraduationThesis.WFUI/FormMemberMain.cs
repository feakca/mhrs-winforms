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
    public partial class FormMemberMain : Form
    {
        FormMemberAppointmentSet memberAppointmentSet;
        FormMemberMyAppointment memberMyAppointment;
        FormMemberInfo memberInfo;
        FormMemberChangePassword memberChangePassword;
        FormMemberHospital memberHospital;
        Member member;

        public FormMemberMain(Member member)
        {
            InitializeComponent();
            this.member = member;
            Text = $"Üye: {member.Name} {member.Surname}";
        }

        private void FormMemberMain_Load(object sender, EventArgs e)
        {
            LoadInfoForm();
        }

        private void LoadInfoForm()
        {
            if (memberInfo == null || memberInfo.IsDisposed)
            {
                memberInfo = new FormMemberInfo(member);
                memberInfo.MdiParent = this;
                memberInfo.Show();
                MemoryStream mem = new MemoryStream(member.Picture);
                barButtonItemInfo.ImageOptions.LargeImage = Image.FromStream(mem);
            }
        }

        private void barButtonItemAppointmentSet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (memberAppointmentSet == null || memberAppointmentSet.IsDisposed)
            {
                memberAppointmentSet = new FormMemberAppointmentSet(member);
                memberAppointmentSet.MdiParent = this;
                memberAppointmentSet.Show();
            }
        }

        private void barButtonItemLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormLogInMain logInMain = new FormLogInMain();
            logInMain.Show();
            this.Hide();
        }

        private void barButtonItemMyAppointment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (memberMyAppointment == null || memberMyAppointment.IsDisposed)
            {
                memberMyAppointment = new FormMemberMyAppointment(member);
                memberMyAppointment.MdiParent = this;
                memberMyAppointment.Show();
            }
        }

        private void barButtonItemInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (memberInfo == null || memberInfo.IsDisposed)
            {
                memberInfo = new FormMemberInfo(member);
                memberInfo.MdiParent = this;
                memberInfo.Show();
            }
        }

        private void barButtonItemChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            memberChangePassword = new FormMemberChangePassword(member);
            memberChangePassword.ShowDialog();
        }

        private void barButtonItemHospital_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (memberHospital == null || memberHospital.IsDisposed)
            {
                memberHospital = new FormMemberHospital();
                memberHospital.MdiParent = this;
                memberHospital.Show();
            }
        }

        private void FormMemberMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
