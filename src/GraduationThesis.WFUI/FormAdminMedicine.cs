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
    public partial class FormAdminMedicine : Form
    {
        BLLAdmin bllAdmin;
        public FormAdminMedicine()
        {
            InitializeComponent();
            bllAdmin = new BLLAdmin();
        }

        private void FormAdminMedicine_Load(object sender, EventArgs e)
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
                radioGroupProcess.Properties.Items.RemoveAt(1);
            }
            else
            {
                RadioGroupItem groupItemUpdate = new RadioGroupItem();
                groupItemUpdate.Description = "Güncelleme";
                if (radioGroupProcess.Properties.Items.Count != 2)
                {
                    radioGroupProcess.Properties.Items.Add(groupItemUpdate);
                }
                FillMedicineInfo(GetFocusedMedicine());
            }
        }

        private void FillMedicineInfo(Medicine medicine)
        {
            if (medicine != null)
            {
                if (radioGroupProcess.Properties.Items[radioGroupProcess.SelectedIndex].Description == "Güncelleme")
                {
                    textEditName.Text = medicine.Name;
                    comboBoxEditType.SelectedItem = medicine.Type.GetEnumDescription();
                    if (medicine.Ssi == null) radioGroupSsi.SelectedIndex = 0;
                    else if (medicine.Ssi == true) radioGroupSsi.SelectedIndex = 1;
                    else radioGroupSsi.SelectedIndex = 2;
                    memoEditDescription.Text = medicine.Description;
                }
            }
            else radioGroupProcess.SelectedIndex = 0;
        }

        private void radioGroupProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroupProcess.SelectedIndex == 0)
            {
                textEditName.Text = string.Empty;
                comboBoxEditType.SelectedItem = null;
                radioGroupSsi.SelectedIndex = 0;
                memoEditDescription.Text = string.Empty;
            }
            else
            {
                if (GetFocusedMedicine() != null) FillMedicineInfo(GetFocusedMedicine());
            }
        }

        private void simpleButtonSaveMedicine_Click(object sender, EventArgs e)
        {
            if (radioGroupProcess.Properties.Items[radioGroupProcess.SelectedIndex].Description == "Yeni Kayıt")
            {
                DialogResult dialogResult = MessageBox.Show("Kaydetmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    bool? ssi;
                    if (radioGroupSsi.Properties.Items[radioGroupSsi.SelectedIndex].Description == "Bilinmiyor") ssi = null;
                    else if (radioGroupSsi.Properties.Items[radioGroupSsi.SelectedIndex].Description == "Evet") ssi = true;
                    else ssi = false;
                    int result = bllAdmin.MedicineNewRecord(textEditName.Text, comboBoxEditType.Text, ssi, memoEditDescription.Text);
                    if (result == 1) MessageBox.Show("İlaç başarıyla kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (result == -1) MessageBox.Show("Lütfen yıldızlı alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (result == -103) MessageBox.Show("Girilen ilaç adı sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Kaydetmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    bool? ssi;
                    if (radioGroupSsi.Properties.Items[radioGroupSsi.SelectedIndex].Description == "Bilinmiyor") ssi = null;
                    else if (radioGroupSsi.Properties.Items[radioGroupSsi.SelectedIndex].Description == "Evet") ssi = true;
                    else ssi = false;
                    int result = bllAdmin.MedicineUpdateRecord(GetFocusedMedicine(), textEditName.Text, comboBoxEditType.Text, ssi, memoEditDescription.Text);
                    if (result == 1) MessageBox.Show("İlaç başarıyla güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (result == -1) MessageBox.Show("Lütfen yıldızlı alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (result == -103) MessageBox.Show("Girilen ilaç adı sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            FillDataGridMedicine();
            FillMedicineInfo(GetFocusedMedicine());
        }

        private void gridViewMedicine_DoubleClick(object sender, EventArgs e)
        {
            if (GetFocusedMedicine() != null)
            {
                DialogResult res = MessageBox.Show("Silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int result = bllAdmin.MedicineDeleteRecord(GetFocusedMedicine());
                    if (result == 1)
                    {
                        MessageBox.Show("İlaç başarıyla silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillDataGridMedicine();
                        FillMedicineInfo(GetFocusedMedicine());
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
