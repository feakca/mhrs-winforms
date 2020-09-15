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
    public partial class FormAdminAddAdmin : Form
    {
        int lastAdmin;
        string nextAdmin;
        BLLAdmin bllAdmin;
        public FormAdminAddAdmin()
        {
            InitializeComponent();
            bllAdmin = new BLLAdmin();
        }

        private void FormAdminAddAdmin_Load(object sender, EventArgs e)
        {
            GetLastAdminNumber();
            CalculateNextAdminUserName();
        }

        private void GetLastAdminNumber()
        {
            lastAdmin = bllAdmin.GetLastAdminNumber();
        }

        private void CalculateNextAdminUserName()
        {
            nextAdmin = string.Empty;
            int prefixLenght = 11 - (lastAdmin + 1).ToString().Length;
            for (int i = 0; i < prefixLenght; i++)
            {
                nextAdmin += "0";
            }
            nextAdmin += (lastAdmin + 1).ToString();
            labelControlNextAdmin.Text = nextAdmin;
        }

        private void simpleButtonAddAdmin_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Yeni yönetici eklemek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                int result = bllAdmin.AdminNewRecord(nextAdmin);
                if (result == 1)
                {
                    MessageBox.Show($"Yönetici başarıyla eklendi.\n\nKullanıcı adı: {nextAdmin}\nŞifre: demo", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetLastAdminNumber();
                    CalculateNextAdminUserName();
                }
                else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
