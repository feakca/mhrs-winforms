using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FormAdminDeletedData : Form
    {
        BLLAdmin bllAdmin;
        public FormAdminDeletedData()
        {
            InitializeComponent();
            bllAdmin = new BLLAdmin();
        }

        private void FormAdminDeletedData_Load(object sender, EventArgs e)
        {
            FillDataGridDeletedHospital();
            FillDataGridDeletedDoctor();
            FillDataGridDeletedMember();
            FillDataGridDeletedMedicine();
        }

        private List<Hospital> GetDeletedHospital()
        {
            return bllAdmin.GetDeletedHospital();
        }

        private List<Doctor> GetDeletedDoctor()
        {
            return bllAdmin.GetDeletedDoctor();
        }

        private List<Member> GetDeletedMember()
        {
            return bllAdmin.GetDeletedMember();
        }

        private List<Medicine> GetDeletedMedicine()
        {
            return bllAdmin.GetDeletedMedicine();
        }

        private void FillDataGridDeletedHospital()
        {
            gridControlHospital.DataSource = GetDeletedHospital();
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

        private void FillDataGridDeletedDoctor()
        {
            gridControlDoctor.DataSource = GetDeletedDoctor();
            gridViewDoctor.Columns["Id"].Visible = false;
            gridViewDoctor.Columns["Picture"].Visible = false;
            gridViewDoctor.Columns["Password"].Visible = false;
            gridViewDoctor.Columns["CreateTime"].Visible = false;
            gridViewDoctor.Columns["UpdateTime"].Visible = false;
            gridViewDoctor.Columns["DeleteTime"].Visible = false;
            gridViewDoctor.Columns["IsActive"].Visible = false;
            gridViewDoctor.Columns["HospitalId"].Visible = false;
            gridViewDoctor.Columns["Hospital"].Visible = false;
            gridViewDoctor.Columns["Appointments"].Visible = false;
            gridViewDoctor.Columns["Age"].Visible = false;

            gridViewDoctor.Columns["Ssn"].Caption = "TC";
            gridViewDoctor.Columns["Appellation"].Caption = "Ünvan";
            gridViewDoctor.Columns["Expertise"].Caption = "Uzmanlık";
            gridViewDoctor.Columns["AgeRange"].Caption = "Yaş Aralığı";
            gridViewDoctor.Columns["Name"].Caption = "İsim";
            gridViewDoctor.Columns["Surname"].Caption = "Soyisim";
            gridViewDoctor.Columns["Birthday"].Caption = "D. Tarihi";
            gridViewDoctor.Columns["Phone"].Caption = "Telefon";
            gridViewDoctor.Columns["Mail"].Caption = "Mail";
            gridViewDoctor.Columns["City"].Caption = "İl";
            gridViewDoctor.Columns["County"].Caption = "İlçe";
        }

        private void FillDataGridDeletedMember()
        {
            gridControlMember.DataSource = GetDeletedMember();
            gridViewMember.Columns["Id"].Visible = false;
            gridViewMember.Columns["Age"].Visible = false;
            gridViewMember.Columns["Height"].Visible = false;
            gridViewMember.Columns["Weight"].Visible = false;
            gridViewMember.Columns["DoesSmoke"].Visible = false;
            gridViewMember.Columns["City"].Visible = false;
            gridViewMember.Columns["County"].Visible = false;
            gridViewMember.Columns["Picture"].Visible = false;
            gridViewMember.Columns["Password"].Visible = false;
            gridViewMember.Columns["CreateTime"].Visible = false;
            gridViewMember.Columns["UpdateTime"].Visible = false;
            gridViewMember.Columns["DeleteTime"].Visible = false;
            gridViewMember.Columns["IsActive"].Visible = false;
            gridViewMember.Columns["Appointments"].Visible = false;

            gridViewMember.Columns["Ssn"].Caption = "TC";
            gridViewMember.Columns["Name"].Caption = "İsim";
            gridViewMember.Columns["Surname"].Caption = "Akca";
            gridViewMember.Columns["Gender"].Caption = "Cinsiyet";
            gridViewMember.Columns["Birthday"].Caption = "Doğum Tarihi";
            gridViewMember.Columns["Mail"].Caption = "Mail";
            gridViewMember.Columns["Phone"].Caption = "Telefon";
        }

        private void FillDataGridDeletedMedicine()
        {
            gridControlMedicine.DataSource = GetDeletedMedicine();
            gridViewMedicine.Columns["Id"].Visible = false;
            gridViewMedicine.Columns["CreateTime"].Visible = false;
            gridViewMedicine.Columns["UpdateTime"].Visible = false;
            gridViewMedicine.Columns["DeleteTime"].Visible = false;
            gridViewMedicine.Columns["IsActive"].Visible = false;
            gridViewMedicine.Columns["Appointments"].Visible = false;

            gridViewMedicine.Columns["Name"].Caption = "İsim";
            gridViewMedicine.Columns["Type"].Caption = "Tip";
            gridViewMedicine.Columns["Ssi"].Caption = "SGK";
            gridViewMedicine.Columns["Description"].Caption = "Açıklama";
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            if (((GridView)sender).GetFocusedRow() != null)
            {
                DialogResult dialogResult = MessageBox.Show("Tekrar aktifleştirmek istediğinize emin misiniz? Bu işlem geri alınamaz.", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (((GridView)sender).GetFocusedRow() is Hospital)
                    {
                        Hospital hospital = (Hospital)((GridView)sender).GetFocusedRow();
                        if (hospital != null)
                        {
                            int result = bllAdmin.ReactivateData(hospital);
                            if (result == 1) MessageBox.Show("Başarılı bir şekilde aktifleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else if (result == -1) MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (((GridView)sender).GetFocusedRow() is Doctor)
                    {
                        Doctor doctor = (Doctor)((GridView)sender).GetFocusedRow();
                        if (doctor != null)
                        {
                            int result = bllAdmin.ReactivateData(doctor);
                            if (result == 1) MessageBox.Show("Başarılı bir şekilde aktifleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else if (result == -1) MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (((GridView)sender).GetFocusedRow() is Member)
                    {
                        Member member = (Member)((GridView)sender).GetFocusedRow();
                        if (member != null)
                        {
                            int result = bllAdmin.ReactivateData(member);
                            if (result == 1) MessageBox.Show("Başarılı bir şekilde aktifleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else if (result == -1) MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (((GridView)sender).GetFocusedRow() is Medicine)
                    {
                        Medicine medicine = (Medicine)((GridView)sender).GetFocusedRow();
                        if (medicine != null)
                        {
                            int result = bllAdmin.ReactivateData(medicine);
                            if (result == 1) MessageBox.Show("Başarılı bir şekilde aktifleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else if (result == -1) MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    FillDataGridDeletedHospital();
                    FillDataGridDeletedDoctor();
                    FillDataGridDeletedMember();
                    FillDataGridDeletedMedicine();
                }
            }
        }
    }
}
