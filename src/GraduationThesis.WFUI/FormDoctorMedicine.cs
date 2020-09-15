using DevExpress.XtraEditors.Controls;
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
    public partial class FormDoctorMedicine : Form
    {
        BLLAdmin bllAdmin;
        public FormDoctorMedicine()
        {
            InitializeComponent();
            bllAdmin = new BLLAdmin();
        }

        private void FormDoctorMedicine_Load(object sender, EventArgs e)
        {
            FillDataGridMedicine();
            FillComboBoxType();
        }

        private void FillComboBoxType()
        {
            comboBoxEditType.Properties.Items.AddRange(BLLHelper.GetEnumDescriptions<MedicineEnumType>());
        }

        private List<Medicine> GetActiveMedicines()
        {
            return bllAdmin.GetActiveMedicines();
        }

        private void FillDataGridMedicine()
        {
            gridControlMedicine.DataSource = GetActiveMedicines();
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

        private Medicine GetFocusedMedicine()
        {
            return (Medicine)gridViewMedicine.GetFocusedRow();
        }

        private void gridViewMedicine_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (GetFocusedMedicine() == null)
            {
                textEditName.Text = string.Empty;
                comboBoxEditType.SelectedItem = null;
                radioGroupSsi.SelectedIndex = 0;
                memoEditDescription.Text = string.Empty;
            }
            else
            {
                FillMedicineInfo(GetFocusedMedicine());
            }
        }

        private void FillMedicineInfo(Medicine medicine)
        {
            if (medicine != null)
            {
                textEditName.Text = medicine.Name;
                comboBoxEditType.SelectedItem = medicine.Type.GetEnumDescription();
                if (medicine.Ssi == null) radioGroupSsi.SelectedIndex = 0;
                else if (medicine.Ssi == true) radioGroupSsi.SelectedIndex = 1;
                else radioGroupSsi.SelectedIndex = 2;
                memoEditDescription.Text = medicine.Description;
            }
        }
    }
}
