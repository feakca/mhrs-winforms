using GraduationThesis.BusinessLogicLayer;
using GraduationThesis.DataAccessLayer.Contexts;
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
    public partial class FormLogInMain : Form
    {
        BLLLogIn bllLogIn;
        BLLMember bllMember;

        public FormLogInMain()
        {
            InitializeComponent();
            using (HospitalContext context = new HospitalContext())
            {

            }
            bllLogIn = new BLLLogIn();
            bllMember = new BLLMember();
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            SetDateEditBirthday();
            SetRadioGroupLogInType();
            SetRadioGroupGender();
        }

        private void SetDateEditBirthday()
        {
            dateEditBirthday.Properties.Mask.Culture = new System.Globalization.CultureInfo("tr-TR");
            dateEditBirthday.Properties.Mask.EditMask = "dd MMMM yyyy";
            dateEditBirthday.Properties.Mask.UseMaskAsDisplayFormat = true;
            dateEditBirthday.DateTime = DateTime.Now;
            dateEditBirthday.Properties.MaxValue = DateTime.Now;
        }

        private void SetRadioGroupLogInType()
        {
            radioGroupLogInType.Properties.Items.AddEnum<LogInEnumType>();
            radioGroupLogInType.SelectedIndex = 0;
        }

        private void SetRadioGroupGender()
        {
            radioGroupGender.Properties.Items.AddEnum<MemberEnumGender>();
            radioGroupGender.SelectedIndex = 0;
        }

        private void simpleButtonLogIn_Click(object sender, EventArgs e)
        {
            LogInEnumType logInType = (LogInEnumType)radioGroupLogInType.Properties.Items[radioGroupLogInType.SelectedIndex].Value;

            LogInEnumOption result = bllLogIn.LogInCheck(logInType, textEditLogInUserName.Text, textEditLogInPassword.Text);
            if (result == LogInEnumOption.Empty) MessageBox.Show("Kullanıcı adı veya şifre alanını boş bırakamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (result == LogInEnumOption.Error) MessageBox.Show("Kullanıcı adınızı veya şifrenizi yanlış girdiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == LogInEnumOption.Admin)
            {
                FormAdminMain adminMain = new FormAdminMain(bllLogIn.AdminFind(textEditLogInUserName.Text));
                adminMain.Show();
                this.Hide();
            }
            else if (result == LogInEnumOption.Doctor)
            {
                FormDoctorMain doctorMain = new FormDoctorMain(bllLogIn.DoctorFind(textEditLogInUserName.Text));
                doctorMain.Show();
                this.Hide();
            }
            else if (result == LogInEnumOption.Member)
            {
                FormMemberMain memberMain = new FormMemberMain(bllLogIn.MemberFind(textEditLogInUserName.Text));
                memberMain.Show();
                this.Hide();
            }
        }

        private void simpleButtonRegister_Click(object sender, EventArgs e)
        {
            MemberEnumGender memberGender = (MemberEnumGender)radioGroupGender.Properties.Items[radioGroupGender.SelectedIndex].Value;

            int result = bllMember.MemberRegister(memberGender, textEditSsn.Text, textEditPassword.Text, textEditName.Text, textEditSurname.Text, textEditPhone.Text, textEditMail.Text, dateEditBirthday.DateTime);
            if (result == 1) MessageBox.Show("Kaydınız başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (result == -1) MessageBox.Show("Lütfen yıldızlı alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -100) MessageBox.Show("Girilen TC sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -101) MessageBox.Show("Girilen telefon sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == -102) MessageBox.Show("Girilen mail sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void simpleButtonForgotPassword_Click(object sender, EventArgs e)
        {
            FormLogInForgotPassword logInForgotPassword = new FormLogInForgotPassword();
            logInForgotPassword.ShowDialog();
        }

        private void FormLogInMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
