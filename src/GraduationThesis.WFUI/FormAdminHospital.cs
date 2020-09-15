using DevExpress.XtraEditors;
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
    public partial class FormAdminHospital : Form
    {
        BLLAdmin bllAdmin;
        FormAdminHospitalNewAndUpdate adminHospitalNewAndUpdate;
        public FormAdminHospital()
        {
            InitializeComponent();
            bllAdmin = new BLLAdmin();
        }

        private void FormAdminHospital_Load(object sender, EventArgs e)
        {
            FillDataGridHospital();
        }

        private List<Hospital> GetActiveHospitals()
        {
            return bllAdmin.GetActiveHospitals();
        }

        private void FillDataGridHospital()
        {
            gridControlHospital.DataSource = GetActiveHospitals();
            gridViewHospital.Columns["Id"].Visible = false;
            gridViewHospital.Columns["Picture"].Visible = false;
            gridViewHospital.Columns["CreateTime"].Visible = false;
            gridViewHospital.Columns["UpdateTime"].Visible = false;
            gridViewHospital.Columns["DeleteTime"].Visible = false;
            gridViewHospital.Columns["IsActive"].Visible = false;
            gridViewHospital.Columns["Doctors"].Visible = false;
            gridViewHospital.Columns["Appointments"].Visible = false;

            gridViewHospital.Columns["Name"].Caption = "İsim";
            gridViewHospital.Columns["NumberOfBed"].Caption = "Yatak Sayısı";
            gridViewHospital.Columns["PhoneI"].Caption = "Telefon I";
            gridViewHospital.Columns["PhoneII"].Caption = "Telefon II";
            gridViewHospital.Columns["PhoneIII"].Caption = "Telefon III";
            gridViewHospital.Columns["Mail"].Caption = "Mail";
            gridViewHospital.Columns["Website"].Caption = "Website";
            gridViewHospital.Columns["City"].Caption = "İl";
            gridViewHospital.Columns["County"].Caption = "İlçe";
            gridViewHospital.Columns["Address"].Caption = "Adres";
        }

        private Hospital GetFocusedHospital()
        {
            return (Hospital)gridViewHospital.GetFocusedRow();
        }

        private void gridViewHospital_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FillHospitalInfo(GetFocusedHospital());
        }

        private void FillHospitalInfo(Hospital hospital)
        {
            if (hospital != null)
            {
                textEditName.Text = hospital.Name;
                textEditNumberOfBed.Text = hospital.NumberOfBed.ToString();
                textEditPhoneI.Text = hospital.PhoneI;
                textEditPhoneII.Text = hospital.PhoneII;
                textEditPhoneIII.Text = hospital.PhoneIII;
                textEditMail.Text = hospital.Mail;
                textEditWebsite.Text = hospital.Website;
                textEditCityCounty.Text = $"{hospital.City} / {hospital.County}";
                memoEditAddress.Text = hospital.Address;
                ShowPicture(hospital);
            }
            else
            {
                textEditName.Text = string.Empty;
                textEditNumberOfBed.Text = string.Empty;
                textEditPhoneI.Text = string.Empty;
                textEditPhoneII.Text = string.Empty;
                textEditPhoneIII.Text = string.Empty;
                textEditMail.Text = string.Empty;
                textEditWebsite.Text = string.Empty;
                textEditCityCounty.Text = string.Empty;
                memoEditAddress.Text = string.Empty;
                pictureEditHospital.Image = null;
            }
        }

        private void ShowPicture(Hospital hospital)
        {
            MemoryStream mem = new MemoryStream(hospital.Picture);
            pictureEditHospital.Image = Image.FromStream(mem);
        }

        private void simpleButtonUpdatePic_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = xtraOpenFileDialogUpdatePic.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (xtraOpenFileDialogUpdatePic.CheckFileExists)
                {
                    int result = bllAdmin.HospitalUpdateRecord(GetFocusedHospital(), xtraOpenFileDialogUpdatePic.FileName);
                    if (result == 1)
                    {
                        ShowPicture(GetFocusedHospital());
                        MessageBox.Show("Hastane resmi başarıyla güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void simpleButtonNewHospital_Click(object sender, EventArgs e)
        {
            adminHospitalNewAndUpdate = new FormAdminHospitalNewAndUpdate();
            adminHospitalNewAndUpdate.ShowDialog();
            FillDataGridHospital();
            FillHospitalInfo(GetFocusedHospital());
        }

        private void simpleButtonUpdateHospital_Click(object sender, EventArgs e)
        {
            adminHospitalNewAndUpdate = new FormAdminHospitalNewAndUpdate(GetFocusedHospital());
            adminHospitalNewAndUpdate.ShowDialog();
            FillDataGridHospital();
            FillHospitalInfo(GetFocusedHospital());
        }

        private void gridViewHospital_DoubleClick(object sender, EventArgs e)
        {
            if (GetFocusedHospital() != null)
            {
                DialogResult res = MessageBox.Show("Silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int result = bllAdmin.HospitalDeleteRecord(GetFocusedHospital());
                    if (result == 1)
                    {
                        MessageBox.Show("Hastane başarıyla silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillDataGridHospital();
                        FillHospitalInfo(GetFocusedHospital());
                    }
                    else if (result == -1)
                    {
                        MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
