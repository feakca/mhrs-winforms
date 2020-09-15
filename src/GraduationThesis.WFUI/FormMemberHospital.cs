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
    public partial class FormMemberHospital : Form
    {
        BLLMember bllMember;
        public FormMemberHospital()
        {
            InitializeComponent();
            bllMember = new BLLMember();
        }

        private void FormMemberHospital_Load(object sender, EventArgs e)
        {
            FillDataGridHospital();
        }

        private List<Hospital> GetActiveHospitals()
        {
            return bllMember.GetActiveHospital();
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
    }
}
