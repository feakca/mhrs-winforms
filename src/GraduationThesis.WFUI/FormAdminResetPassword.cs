using DevExpress.Data;
using DevExpress.Data.Linq;
using DevExpress.XtraBars.Docking.Helpers;
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
    public partial class FormAdminResetPassword : Form
    {
        BLLAdmin bllAdmin;
        Doctor doctor;
        Member member;
        Admin admin;
        public FormAdminResetPassword()
        {
            InitializeComponent();
            bllAdmin = new BLLAdmin();
        }

        private void FormAdminResetPassword_Load(object sender, EventArgs e)
        {
            LabelDefault();
        }

        private void LabelDefault()
        {
            doctor = null;
            member = null;
            admin = null;
            labelControlName.Text = "Sıfırlanacak kişi...";
            labelControlName.ForeColor = Color.DodgerBlue;
            textEditSsn.Text = string.Empty;
            textEditNewPassword.Text = string.Empty;
            simpleButtonResetPassword.Enabled = false;
        }

        private void LabelNotFound(string type)
        {
            if (type == "doctor")
            {
                doctor = null;
                labelControlName.Text = "Doktor bulunamadı.";
                labelControlName.ForeColor = Color.Red;
                simpleButtonResetPassword.Enabled = false;
            }
            else if (type == "member")
            {
                member = null;
                labelControlName.Text = "Üye bulunamadı.";
                labelControlName.ForeColor = Color.Red;
                simpleButtonResetPassword.Enabled = false;
            }
            else
            {
                admin = null;
                labelControlName.Text = "Yönetici bulunamadı.";
                labelControlName.ForeColor = Color.Red;
                simpleButtonResetPassword.Enabled = false;
            }
        }

        private void LabelFound<Entity>(Entity entity)
        {
            if (entity is Doctor)
            {
                labelControlName.Text = $"{doctor.Name} {doctor.Surname}";
                simpleButtonResetPassword.Enabled = true;
            }
            else if (entity is Member)
            {
                labelControlName.Text = $"{member.Name} {member.Surname}";
                simpleButtonResetPassword.Enabled = true;
            }
            else
            {
                labelControlName.Text = admin.UserName;
                simpleButtonResetPassword.Enabled = true;
            }
            labelControlName.ForeColor = Color.Green;
        }

        private void textEditSsn_EditValueChanged(object sender, EventArgs e)
        {
            if (textEditSsn.Text.Length == 11)
            {
                if (radioGroupType.SelectedIndex == 0)
                {
                    doctor = bllAdmin.CheckDoctor(textEditSsn.Text);
                    if (doctor == null) LabelNotFound("doctor");
                    else LabelFound<Doctor>(doctor);

                }
                else if (radioGroupType.SelectedIndex == 1)
                {
                    member = bllAdmin.CheckMember(textEditSsn.Text);
                    if (member == null) LabelNotFound("member");
                    else LabelFound<Member>(member);
                }
                else
                {
                    admin = bllAdmin.CheckAdmin(textEditSsn.Text);
                    if (admin == null) LabelNotFound("admin");
                    else LabelFound<Admin>(admin);
                }
            }
            else LabelDefault();
        }

        private void radioGroupType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelDefault();
        }

        private void simpleButtonResetPassword_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sıfırlamak istediğinize emin misiniz? Bu işlem geri alınamaz.", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int result;
                if (radioGroupType.SelectedIndex == 0)
                {
                    result = bllAdmin.ResetDoctorPassword(doctor, textEditNewPassword.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("Doktor şifresi sıfırlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LabelDefault();
                    }
                    else if (result == -1) MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (radioGroupType.SelectedIndex == 1)
                {
                    result = bllAdmin.ResetMemberPassword(member, textEditNewPassword.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("Üye şifresi sıfırlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LabelDefault();
                    }
                    else if (result == -1) MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    result = bllAdmin.ResetAdminPassword(admin, textEditNewPassword.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("Yönetici şifresi sıfırlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LabelDefault();
                    }
                    else if (result == -1) MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
