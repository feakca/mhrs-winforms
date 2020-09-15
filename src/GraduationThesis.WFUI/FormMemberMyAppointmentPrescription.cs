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
    public partial class FormMemberMyAppointmentPrescription : Form
    {
        Appointment appointment;

        public FormMemberMyAppointmentPrescription(Appointment appointment)
        {
            InitializeComponent();
            this.appointment = appointment;
            FillListBoxMedicine();
        }

        private void FormMemberMyAppointmentPrescription_Load(object sender, EventArgs e)
        {

        }

        private void FillListBoxMedicine()
        {
            if (appointment.Medicines != null)
            {
                foreach (var item in appointment.Medicines)
                {
                    listBoxControlMedicine.Items.Add(item);
                }
            }
        }

        private void FillMedicineInfo(Medicine medicine)
        {
            textEditMedicineName.Text = medicine.Name;
            textEditMedicineType.Text = BLLHelper.GetEnumDescription(medicine.Type);
            if (!medicine.Ssi.HasValue)
            {
                textEditMedicineSsi.Text = "Bilinmiyor";
            }
            else
            {
                if (medicine.Ssi == true) textEditMedicineSsi.Text = "Evet";
                else textEditMedicineSsi.Text = "Hayır";
            }
            memoEditMedicineDescription.Text = medicine.Description;
        }

        private void listBoxControlMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillMedicineInfo((Medicine)listBoxControlMedicine.SelectedItem);
        }
    }
}
