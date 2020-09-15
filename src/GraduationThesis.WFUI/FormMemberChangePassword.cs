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
    public partial class FormMemberChangePassword : Form
    {
        Doctor doctor;
        Member member;
        BLLDoctor bllDoctor;
        BLLMember bllMember;
        public FormMemberChangePassword(Doctor doctor)
        {
            InitializeComponent();
            this.doctor = doctor;
            bllDoctor = new BLLDoctor();
        }

        public FormMemberChangePassword(Member member)
        {
            InitializeComponent();
            this.member = member;
            bllMember = new BLLMember();
        }

        private void FormMemberChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void simpleButtonChangePassword_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Şifrenizi değiştirmek istediğinize emin misiniz? Bu işlem geri alınamaz.", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (doctor != null)
                {
                    int result = bllDoctor.ChangePassword(doctor, textEditOldPassword.Text, textEditNewPassword.Text, textEditNewPasswordRepeat.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("Şifreniz başarıyla değiştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else if (result == -1) MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (result == -3) MessageBox.Show("Eski şifrenizi hatalı girdiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (result == -4) MessageBox.Show("Yeni girilen şifreler uyuşmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (member != null)
                {
                    int result = bllMember.ChangePassword(member, textEditOldPassword.Text, textEditNewPassword.Text, textEditNewPasswordRepeat.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("Şifreniz başarıyla değiştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else if (result == -1) MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (result == -3) MessageBox.Show("Eski şifrenizi hatalı girdiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (result == -4) MessageBox.Show("Yeni girilen şifreler uyuşmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
