using GraduationThesis.BusinessLogicLayer;
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
    public partial class FormLogInForgotPassword : Form
    {
        BLLMember bllMember;
        public FormLogInForgotPassword()
        {
            InitializeComponent();
            bllMember = new BLLMember();
        }

        private void FormLogInForgotPassword_Load(object sender, EventArgs e)
        {
            SetDateEditBirthday();
        }

        private void SetDateEditBirthday()
        {
            dateEditBirthday.Properties.Mask.Culture = new System.Globalization.CultureInfo("tr-TR");
            dateEditBirthday.Properties.Mask.EditMask = "dd MMMM yyyy";
            dateEditBirthday.Properties.Mask.UseMaskAsDisplayFormat = true;
            dateEditBirthday.DateTime = DateTime.Now;
        }

        private void simpleButtonResetPassword_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Şifrenizi sıfırlamak istediğinize emin misiniz? Bu işlem geri alınamaz.", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int result = bllMember.ForgotPassword(textEditSsn.Text, textEditName.Text, textEditSurname.Text, textEditPhone.Text, textEditMail.Text, dateEditBirthday.DateTime, textEditNewPassword.Text, textEditNewPasswordRepeat.Text);
                if (result == 1)
                {
                    MessageBox.Show("Şifreniz başarıyla sıfırlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (result == -1) MessageBox.Show("Lütfen yıldızlı alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (result == -5) MessageBox.Show("Girilen TC ile eşleşen kayıt bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (result == -6) MessageBox.Show("Girilen bilgileri tekrar kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (result == -4) MessageBox.Show("Yeni girilen şifreler uyuşmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
