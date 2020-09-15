using Cryptology;
using GraduationThesis.DataAccessLayer.Contexts;
using GraduationThesis.DataAccessLayer.Repositories;
using GraduationThesis.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.BusinessLogicLayer
{
    public class BLLDoctor
    {
        public Doctor DoctorLogIn(string userName, string password)
        {
            using (RepositoryDoctor repositoryDoctor = new RepositoryDoctor())
            {
                string encryptedPassword = PasswordCrypto.EncryptToSha512(password);
                return repositoryDoctor.FirstWithExplicitLoad(I => I.Ssn == userName && I.Password == encryptedPassword && I.IsActive == true);
            }
        }

        public int DoctorInfoUpdate(Doctor doctor, string picture)
        {
            using (RepositoryDoctor repositoryDoctor = new RepositoryDoctor())
            {
                Image image = Image.FromFile(picture);
                MemoryStream mem = new MemoryStream();
                image.Save(mem, ImageFormat.Png);
                doctor.Picture = mem.ToArray();
                repositoryDoctor.CUDOperation(doctor, EntityState.Modified);
                return repositoryDoctor.SaveChanges();
            }
        }

        public int ChangePassword(Doctor doctor, string oldPassword, string newPassword, string newPasswordRepeat)
        {
            if (!string.IsNullOrEmpty(oldPassword) && !string.IsNullOrWhiteSpace(oldPassword) && !string.IsNullOrEmpty(newPassword) && !string.IsNullOrWhiteSpace(newPassword) && !string.IsNullOrEmpty(newPasswordRepeat) && !string.IsNullOrWhiteSpace(newPasswordRepeat) && doctor != null)
            {
                if (doctor.Password == PasswordCrypto.EncryptToSha512(oldPassword))
                {
                    if (newPassword == newPasswordRepeat)
                    {
                        using (RepositoryDoctor repositoryDoctor = new RepositoryDoctor())
                        {
                            doctor.Password = PasswordCrypto.EncryptToSha512(newPassword);
                            repositoryDoctor.CUDOperation(doctor, EntityState.Modified);
                            return repositoryDoctor.SaveChanges();
                        }
                    }
                    else return -4;
                }
                else return -3;
            }
            else return -1;
        }

        public int DoctorInfoUpdate(Doctor doctor, string phone, string mail, string city, string county)
        {
            string tempPhone;
            string tempMail;
            string tempCity;
            string tempCounty;
            if (string.IsNullOrEmpty(phone.Trim())) tempPhone = null;
            else tempPhone = phone;
            if (string.IsNullOrEmpty(mail.Trim())) tempMail = null;
            else tempMail = mail;
            if (string.IsNullOrEmpty(city.Trim())) tempCity = null;
            else tempCity = city;
            if (string.IsNullOrEmpty(county.Trim())) tempCounty = null;
            else tempCounty = county;
            using (RepositoryDoctor repositoryDoctor = new RepositoryDoctor())
            {
                if (!repositoryDoctor.AnyWithExplicitLoad(I => I.Id != doctor.Id && I.Phone == phone))
                {
                    if (!repositoryDoctor.AnyWithExplicitLoad(I => I.Id != doctor.Id && I.Mail == mail))
                    {
                        doctor.Phone = tempPhone;
                        doctor.Mail = tempMail;
                        doctor.City = tempCity;
                        doctor.County = tempCounty;
                        repositoryDoctor.CUDOperation(doctor, EntityState.Modified);
                        return repositoryDoctor.SaveChanges();
                    }
                    else return -112;
                }
                else return -111;
            }
        }

        public List<Medicine> GetActiveMedicines()
        {
            using (RepositoryMedicine repositoryMedicine = new RepositoryMedicine())
            {
                List<Medicine> medicines = new List<Medicine>();
                medicines = repositoryMedicine.WhereWithExplicitLoad(I => I.IsActive == true).OrderBy(I => I.Name).ToList();
                return medicines;
            }
        }

        public int FillAppointmentInfo(Appointment appointment, string description, List<Medicine> prescription, AppointmentEnumState state)
        {
            if (appointment != null)
            {
                string tempDescription;
                if (string.IsNullOrEmpty(description.Trim())) tempDescription = null;
                else tempDescription = description;
                using (HospitalContext context = new HospitalContext())
                {
                    using (DbContextTransaction transaction = context.Database.BeginTransaction())
                    {
                        try
                        {
                            appointment.Description = tempDescription;
                            appointment.State = state;
                            appointment.UpdateTime = DateTime.Now;
                            context.Entry(appointment).State = EntityState.Modified;
                            int result = context.SaveChanges();

                            var tempAppointment = context.Appointments.Include("Medicines").Single(I => I.Id == appointment.Id);
                            foreach (var item in prescription)
                            {
                                var tempMedicine = context.Medicines.Single(I => I.Id == item.Id);
                                tempAppointment.Medicines.Add(tempMedicine);
                            }
                            context.SaveChanges();

                            transaction.Commit();
                            return 1;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            return 0;
                        }
                    }
                }
            }
            else return -1;
        }

        public int FillAppointmentInfo(Appointment appointment, AppointmentEnumState state)
        {
            if (appointment != null)
            {
                using (RepositoryAppointment repositoryAppointment = new RepositoryAppointment())
                {
                    appointment.State = state;
                    appointment.UpdateTime = DateTime.Now;
                    repositoryAppointment.CUDOperation(appointment, EntityState.Modified);
                    return repositoryAppointment.SaveChanges();
                }
            }
            else return -1;
        }

        public List<string> GetStatistic(Doctor doctor)
        {
            List<string> statistics = new List<string>();
            using (RepositoryAppointment repositoryAppointment = new RepositoryAppointment())
            {
                DateTime thirtyDayAgo = DateTime.Now.AddDays(-30);
                {
                    statistics.Add(repositoryAppointment.WhereWithExplicitLoad(I => I.DoctorId == doctor.Id && I.State == AppointmentEnumState.Attended && I.Time.CompareTo(thirtyDayAgo) > 0).Count().ToString());
                }
                {
                    int medicineCount = 0;
                    List<Appointment> appointments = repositoryAppointment.WhereWithExplicitLoad(I => I.DoctorId == doctor.Id && I.State == AppointmentEnumState.Attended && I.Time.CompareTo(thirtyDayAgo) > 0, paths: new string[] { "Medicines" }).ToList();
                    foreach (var item in appointments)
                    {
                        medicineCount += item.Medicines.Count;
                    }
                    statistics.Add(medicineCount.ToString());
                }
                {
                    statistics.Add(repositoryAppointment.WhereWithExplicitLoad(I => I.DoctorId == doctor.Id && I.State == AppointmentEnumState.Cancel && I.Time.CompareTo(thirtyDayAgo) > 0).Count().ToString());
                }
                {
                    statistics.Add(repositoryAppointment.WhereWithExplicitLoad(I => I.DoctorId == doctor.Id && I.State == AppointmentEnumState.NotAttended && I.Time.CompareTo(thirtyDayAgo) > 0).Count().ToString());
                }
                {
                    int ageSum = 0;
                    List<Member> members = new List<Member>();
                    List<Appointment> appointments = repositoryAppointment.WhereWithExplicitLoad(I => I.DoctorId == doctor.Id && I.State == AppointmentEnumState.Attended && I.Time.CompareTo(thirtyDayAgo) > 0, paths: new string[] { "Member" }).ToList();
                    foreach (var item in appointments)
                    {
                        item.Member.Age = item.Time.Year - item.Member.Birthday.Year;
                        members.Add(item.Member);
                    }
                    foreach (var item in members.Distinct())
                    {
                        ageSum += item.Age;
                    }
                    if (members.Distinct().Count() == 0) statistics.Add("0");
                    else
                    {
                        statistics.Add(((double)ageSum / (double)members.Distinct().Count()).ToString());
                    }
                }
                {
                    double man = 0, woman = 0;
                    List<Appointment> appointments = new List<Appointment>();
                    appointments = repositoryAppointment.WhereWithExplicitLoad(I => I.DoctorId == doctor.Id && I.State == AppointmentEnumState.Attended && I.Time.CompareTo(thirtyDayAgo) > 0, paths: new string[] { "Member" }).ToList();
                    foreach (var item in appointments)
                    {
                        if (item.Member.Gender == MemberEnumGender.Erkek) man++;
                        else woman++;
                    }
                    if (man == 0 && woman == 0)
                    {
                        statistics.Add("0");
                        statistics.Add("0");
                    }
                    else
                    {
                        statistics.Add(Math.Round(man / (man + woman) * 100, 2).ToString());
                        statistics.Add(Math.Round(woman / (man + woman) * 100, 2).ToString());
                    }
                }
                return statistics;
            }
        }

        public Dictionary<string, int> GetChartFavoriteMedicine(Doctor doctor)
        {
            using (HospitalContext context = new HospitalContext())
            {
                Dictionary<string, int> medicineCount = context.Medicines.ToDictionary(I => I.Name, I => 0);

                List<Appointment> appointments = context.Appointments.Where(I => I.DoctorId == doctor.Id).Include(I => I.Medicines).ToList();
                foreach (var appointment in appointments)
                {
                    foreach (var medicine in appointment.Medicines)
                    {
                        medicineCount[medicine.Name] = medicineCount[medicine.Name] + 1;
                    }
                }
                Dictionary<string, int> medicineCountFinal = new Dictionary<string, int>();
                foreach (var item in medicineCount)
                {
                    medicineCountFinal.Add(item.Key, item.Value);
                }
                foreach (var item in medicineCount)
                {
                    if (item.Value == 0) medicineCountFinal.Remove(item.Key);
                }
                return medicineCountFinal.OrderByDescending(I => I.Value).Take(5).ToDictionary(I => I.Key, I => I.Value);
            }
        }

        public Dictionary<string, int> GetChartAgeRange(Doctor doctor)
        {
            using (HospitalContext context = new HospitalContext())
            {
                Dictionary<string, int> ageRanges = new Dictionary<string, int>();
                ageRanges.Add("0 - 8", 0);
                ageRanges.Add("9 - 17", 0);
                ageRanges.Add("18 - 25", 0);
                ageRanges.Add("26 - 45", 0);
                ageRanges.Add("46 - 64", 0);
                ageRanges.Add("65+", 0);

                List<Appointment> appointments = context.Appointments.Where(I => I.DoctorId == doctor.Id && I.State == AppointmentEnumState.Attended).Include(I => I.Member).ToList();
                foreach (var item in appointments)
                {
                    item.Member.Age = item.Time.Year - item.Member.Birthday.Year;
                    if (item.Member.Age >= 0 && item.Member.Age <= 8)
                    {
                        ageRanges["0 - 8"] = ageRanges["0 - 8"] + 1;
                    }
                    else if (item.Member.Age >= 9 && item.Member.Age <= 17)
                    {
                        ageRanges["9 - 17"] = ageRanges["9 - 17"] + 1;
                    }
                    else if (item.Member.Age >= 18 && item.Member.Age <= 25)
                    {
                        ageRanges["18 - 25"] = ageRanges["18 - 25"] + 1;
                    }
                    else if (item.Member.Age >= 26 && item.Member.Age <= 45)
                    {
                        ageRanges["26 - 45"] = ageRanges["26 - 45"] + 1;
                    }
                    else if (item.Member.Age >= 46 && item.Member.Age <= 64)
                    {
                        ageRanges["46 - 64"] = ageRanges["46 - 64"] + 1;
                    }
                    else ageRanges["65+"] = ageRanges["65+"] + 1;
                }
                Dictionary<string, int> ageRangesFinal = new Dictionary<string, int>();
                foreach (var item in ageRanges)
                {
                    ageRangesFinal.Add(item.Key, item.Value);
                }
                foreach (var item in ageRanges)
                {
                    if (item.Value == 0) ageRangesFinal.Remove(item.Key);
                }
                return ageRangesFinal.OrderByDescending(I => I.Value).ToDictionary(I => I.Key, I => I.Value);
            }
        }
    }
}
