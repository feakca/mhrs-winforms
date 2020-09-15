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
    public partial class FormDoctorAppointment : Form
    {
        List<Medicine> medicines;
        BLLDoctor bllDoctor;
        Doctor doctor;
        List<Appointment> appointments;
        List<Medicine> prescription;

        public FormDoctorAppointment(Doctor doctor)
        {
            InitializeComponent();
            medicines = new List<Medicine>();
            bllDoctor = new BLLDoctor();
            prescription = new List<Medicine>();
            this.doctor = doctor;
        }

        private void FormDoctorAppointment_Load(object sender, EventArgs e)
        {
            GetAppointments();
            FillListBoxAppointment();
            FillListBoxMedicine();
        }

        private void GetAppointments()
        {
            appointments = doctor.Appointments.Where(I => I.Time.ToString("dd.MM.yyyy") == DateTime.Now.ToString("dd.MM.yyyy") && I.State == AppointmentEnumState.Future).OrderBy(I => I.Time).ToList();
        }

        private void FillListBoxAppointment()
        {
            listBoxControlAppointment.Items.Clear();
            GetAppointments();
            if (appointments != null)
            {
                foreach (var item in appointments)
                {
                    listBoxControlAppointment.Items.Add(item);
                }
            }
        }

        private List<Medicine> GetActiveMedicines()
        {
            medicines = bllDoctor.GetActiveMedicines();
            return medicines;
        }

        private void FillListBoxMedicine()
        {
            listBoxControlMedicine.DataSource = GetActiveMedicines();
        }

        private void textEditSearchMedicine_Enter(object sender, EventArgs e)
        {
            textEditSearchMedicine.Text = string.Empty;
        }

        private List<Medicine> FillListBoxMedicineWithSearch(string searchTerm)
        {
            return medicines.Where(I => I.Name.Contains(searchTerm)).ToList();
        }

        private void textEditSearchMedicine_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditSearchMedicine.Text) || string.IsNullOrWhiteSpace(textEditSearchMedicine.Text) || textEditSearchMedicine.Text == "İlaç ara...")
            {
                FillListBoxMedicine();
            }
            else
            {
                listBoxControlMedicine.DataSource = FillListBoxMedicineWithSearch(textEditSearchMedicine.Text);
            }
        }

        private void FillListBoxPrescription()
        {
            listBoxControlPrescription.Items.Clear();
            if (prescription != null)
            {
                foreach (var item in prescription)
                {
                    listBoxControlPrescription.Items.Add(item);
                }
            }
        }

        private void listBoxControlMedicine_DoubleClick(object sender, EventArgs e)
        {
            if ((Medicine)listBoxControlMedicine.SelectedItem != null)
            {
                prescription.Add((Medicine)listBoxControlMedicine.SelectedItem);
                FillListBoxPrescription();
            }
        }

        private void listBoxControlPrescription_DoubleClick(object sender, EventArgs e)
        {
            prescription.Remove((Medicine)listBoxControlPrescription.SelectedItem);
            FillListBoxPrescription();
        }

        private void ShowPicture(Member member)
        {
            MemoryStream mem = new MemoryStream(member.Picture);
            pictureEditMember.Image = Image.FromStream(mem);
        }

        private void simpleButtonAttended_Click(object sender, EventArgs e)
        {
            if (listBoxControlAppointment.SelectedItem != null)
            {
                DialogResult res = MessageBox.Show("Kaydetmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int result = bllDoctor.FillAppointmentInfo((Appointment)listBoxControlAppointment.SelectedItem, memoEditDescription.Text, prescription, AppointmentEnumState.Attended);
                    if (result == 1)
                    {
                        MessageBox.Show("Kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearScreen();
                        FillListBoxAppointment();
                    }
                    else if (result == -1)
                    {
                        MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void simpleButtonNotAttended_Click(object sender, EventArgs e)
        {
            if (listBoxControlAppointment.SelectedItem != null)
            {
                DialogResult res = MessageBox.Show("Gelmedi olarak işaretlemek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int result = bllDoctor.FillAppointmentInfo((Appointment)listBoxControlAppointment.SelectedItem, AppointmentEnumState.NotAttended);
                    if (result == 1)
                    {
                        MessageBox.Show("Gelmedi olarak işaretlendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearScreen();
                        FillListBoxAppointment();
                    }
                    else if (result == -1)
                    {
                        MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show("Bir şeyler yanlış gitti. Lütfen sistem yöneticinizle görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listBoxControlAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxControlAppointment.SelectedItem == null)
            {
                ClearScreen();
            }
            else
            {
                textEditSearchMedicine.Text = "İlaç ara...";
                prescription.Clear();
                FillListBoxPrescription();
                textEditSsn.Text = ((Appointment)listBoxControlAppointment.SelectedItem).Member.Ssn;
                textEditNameSurname.Text = $"{((Appointment)listBoxControlAppointment.SelectedItem).Member.Name} {((Appointment)listBoxControlAppointment.SelectedItem).Member.Surname}";
                textEditGender.Text = ((Appointment)listBoxControlAppointment.SelectedItem).Member.Gender.GetEnumDescription();
                textEditAge.Text = ((Appointment)listBoxControlAppointment.SelectedItem).Member.Age.ToString();
                if (!((Appointment)listBoxControlAppointment.SelectedItem).Member.DoesSmoke.HasValue)
                {
                    textEditSmoke.Text = "Bilinmiyor";
                }
                else
                {
                    if (((Appointment)listBoxControlAppointment.SelectedItem).Member.DoesSmoke == true) textEditSmoke.Text = "Evet";
                    else textEditSmoke.Text = "Hayır";
                }
                if (((Appointment)listBoxControlAppointment.SelectedItem).Member.Height != null && ((Appointment)listBoxControlAppointment.SelectedItem).Member.Weight != null)
                {
                    double height = (double)((Appointment)listBoxControlAppointment.SelectedItem).Member.Height / 100;
                    double weight = (double)((Appointment)listBoxControlAppointment.SelectedItem).Member.Weight;
                    textEditBmi.Text = Math.Round((weight / Math.Pow(height, 2)), 2).ToString();
                }
                else textEditBmi.Text = "Bilinmiyor";
                if (!string.IsNullOrEmpty(((Appointment)listBoxControlAppointment.SelectedItem).Member.City) && !string.IsNullOrEmpty(((Appointment)listBoxControlAppointment.SelectedItem).Member.County))
                {
                    textEditCityCounty.Text = $"{((Appointment)listBoxControlAppointment.SelectedItem).Member.City} / {((Appointment)listBoxControlAppointment.SelectedItem).Member.County}";
                }
                else textEditCityCounty.Text = string.Empty;
                memoEditDescription.Text = ((Appointment)listBoxControlAppointment.SelectedItem).Description;
                ShowPicture(((Appointment)listBoxControlAppointment.SelectedItem).Member);
            }
        }

        private void ClearScreen()
        {
            textEditSearchMedicine.Text = "İlaç ara...";
            prescription.Clear();
            FillListBoxPrescription();
            textEditSsn.Text = string.Empty;
            textEditNameSurname.Text = string.Empty;
            textEditGender.Text = string.Empty;
            textEditAge.Text = string.Empty;
            textEditSmoke.Text = string.Empty;
            textEditBmi.Text = string.Empty;
            textEditCityCounty.Text = string.Empty;
            memoEditDescription.Text = string.Empty;
            pictureEditMember.Image = null;
        }
    }
}
