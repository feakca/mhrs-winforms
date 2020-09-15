using Cryptology;
using GraduationThesis.DataAccessLayer.Contexts;
using GraduationThesis.DataAccessLayer.Repositories;
using GraduationThesis.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraduationThesis.BusinessLogicLayer
{
    public class BLLMember
    {
        public BLLMember()
        {

        }

        public Member MemberLogIn(string userName, string password)
        {
            using (RepositoryMember repositoryMember = new RepositoryMember())
            {
                string encryptedPassword = PasswordCrypto.EncryptToSha512(password);
                return repositoryMember.FirstWithExplicitLoad(I => I.Ssn == userName && I.Password == encryptedPassword && I.IsActive == true);
            }
        }

        public List<Hospital> GetActiveHospital()
        {
            using (RepositoryHospital repositoryHospital = new RepositoryHospital())
            {
                return repositoryHospital.WhereWithExplicitLoad(I => I.IsActive == true).ToList();
            }
        }

        public int MemberRegister(MemberEnumGender gender, string ssn, string password, string name, string surname, string phone, string mail, DateTime birthday)
        {
            int returnValueInt = 0;
            if (!string.IsNullOrEmpty(ssn) && !string.IsNullOrWhiteSpace(ssn) && !string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password) && !string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name) && !string.IsNullOrEmpty(surname) && !string.IsNullOrWhiteSpace(surname) && ssn.Length == 11 && birthday != null)
            {
                string tempPhone;
                string tempMail;
                if (string.IsNullOrEmpty(phone.Trim())) tempPhone = null;
                else tempPhone = phone;
                if (string.IsNullOrEmpty(mail.Trim())) tempMail = null;
                else tempMail = mail;
                using (RepositoryMember repositoryMember = new RepositoryMember())
                {
                    if (!repositoryMember.AnyWithExplicitLoad(I => I.Ssn == ssn))
                    {
                        if (!repositoryMember.AnyWithExplicitLoad(I => I.Phone == phone))
                        {
                            if (!repositoryMember.AnyWithExplicitLoad(I => I.Mail == mail))
                            {
                                repositoryMember.CUDOperation(new Member()
                                {
                                    Id = Guid.NewGuid(),
                                    Ssn = ssn,
                                    Name = BLLHelper.TrimName(name),
                                    Surname = BLLHelper.TrimSurname(surname),
                                    Gender = gender,
                                    Birthday = birthday,
                                    Phone = tempPhone,
                                    Mail = tempMail,
                                    Password = PasswordCrypto.EncryptToSha512(password),
                                    Picture = BLLHelper.DefaultUserPic()
                                }, EntityState.Added);
                                returnValueInt = repositoryMember.SaveChanges();
                            }
                            else returnValueInt = -102;
                        }
                        else returnValueInt = -101;
                    }
                    else returnValueInt = -100;
                }
            }
            else returnValueInt = -1;
            return returnValueInt;
        }

        public List<string> GetStatistic(Member member)
        {
            List<string> statistics = new List<string>();
            using (RepositoryAppointment repositoryAppointment = new RepositoryAppointment())
            {
                {
                    statistics.Add(repositoryAppointment.WhereWithExplicitLoad(I => I.MemberId == member.Id && I.State == AppointmentEnumState.Attended).Count().ToString());
                }
                {
                    int medicineCount = 0;
                    List<Appointment> appointments = repositoryAppointment.WhereWithExplicitLoad(I => I.MemberId == member.Id && I.State == AppointmentEnumState.Attended, paths: new string[] { "Medicines" }).ToList();
                    foreach (var item in appointments)
                    {
                        medicineCount += item.Medicines.Count;
                    }
                    statistics.Add(medicineCount.ToString());
                }
                {
                    statistics.Add(repositoryAppointment.WhereWithExplicitLoad(I => I.MemberId == member.Id && I.State == AppointmentEnumState.Cancel).Count().ToString());
                }
                {
                    statistics.Add(repositoryAppointment.WhereWithExplicitLoad(I => I.MemberId == member.Id && I.State == AppointmentEnumState.NotAttended).Count().ToString());
                }
                {
                    int ageSum = 0;
                    List<Doctor> doctors = new List<Doctor>();
                    List<Appointment> appointments = repositoryAppointment.WhereWithExplicitLoad(I => I.MemberId == member.Id && I.State == AppointmentEnumState.Attended, paths: new string[] { "Doctor" }).ToList();
                    foreach (var item in appointments)
                    {
                        item.Doctor.Age = item.Time.Year - item.Doctor.Birthday.Year;
                        doctors.Add(item.Doctor);
                    }
                    foreach (var item in doctors.Distinct())
                    {
                        ageSum += item.Age;
                    }
                    if (doctors.Distinct().Count() == 0) statistics.Add("0");
                    else
                    {
                        statistics.Add(((double)ageSum / (double)doctors.Distinct().Count()).ToString());
                    }
                }
                {
                    int maxAge = 0;
                    List<Appointment> appointments = repositoryAppointment.WhereWithExplicitLoad(I => I.MemberId == member.Id && I.State == AppointmentEnumState.Attended, paths: new string[] { "Doctor" }).ToList();
                    foreach (var item in appointments)
                    {
                        item.Doctor.Age = item.Time.Year - item.Doctor.Birthday.Year;
                        if (item.Doctor.Age >= maxAge) maxAge = item.Doctor.Age;
                    }
                    statistics.Add(maxAge.ToString());
                }
                {
                    int minAge = 200;
                    List<Appointment> appointments = repositoryAppointment.WhereWithExplicitLoad(I => I.MemberId == member.Id && I.State == AppointmentEnumState.Attended, paths: new string[] { "Doctor" }).ToList();
                    foreach (var item in appointments)
                    {
                        item.Doctor.Age = item.Time.Year - item.Doctor.Birthday.Year;
                        if (item.Doctor.Age <= minAge) minAge = item.Doctor.Age;
                    }
                    statistics.Add(minAge.ToString());
                }
                return statistics;
            }
        }

        public Dictionary<string, int> GetChartMostVisitedHospital(Member member)
        {
            using (HospitalContext context = new HospitalContext())
            {
                Dictionary<string, int> hospitalCount = context.Hospitals.ToDictionary(I => I.Name, I => 0);

                List<Appointment> appointments = context.Appointments.Where(I => I.MemberId == member.Id && I.State == AppointmentEnumState.Attended).Include(I => I.Hospital).ToList();
                foreach (var appointment in appointments)
                {
                    hospitalCount[appointment.Hospital.Name] = hospitalCount[appointment.Hospital.Name] + 1;
                }
                Dictionary<string, int> hospitalCountFinal = new Dictionary<string, int>();
                foreach (var item in hospitalCount)
                {
                    hospitalCountFinal.Add(item.Key, item.Value);
                }
                foreach (var item in hospitalCount)
                {
                    if (item.Value == 0) hospitalCountFinal.Remove(item.Key);
                }
                return hospitalCountFinal.OrderByDescending(I => I.Value).Take(5).ToDictionary(I => I.Key, I => I.Value);
            }
        }

        public Dictionary<string, int> GetChartMostUsedMedicine(Member member)
        {
            using (HospitalContext context = new HospitalContext())
            {
                Dictionary<string, int> medicineCount = context.Medicines.ToDictionary(I => I.Name, I => 0);

                List<Appointment> appointments = context.Appointments.Where(I => I.MemberId == member.Id).Include(I => I.Medicines).ToList();
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

        public int ForgotPassword(string ssn, string name, string surname, string phone, string mail, DateTime birthday, string newPassword, string newPasswordRepeat)
        {
            if (!string.IsNullOrEmpty(ssn) && !string.IsNullOrWhiteSpace(ssn) && !string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name) && !string.IsNullOrEmpty(surname) && !string.IsNullOrWhiteSpace(surname) && !string.IsNullOrEmpty(newPassword) && !string.IsNullOrWhiteSpace(newPassword) && !string.IsNullOrEmpty(newPasswordRepeat) && !string.IsNullOrWhiteSpace(newPasswordRepeat) && birthday != null)
            {
                string tempPhone;
                string tempMail;
                if (string.IsNullOrEmpty(phone.Trim())) tempPhone = null;
                else tempPhone = phone;
                if (string.IsNullOrEmpty(mail.Trim())) tempMail = null;
                else tempMail = mail;
                using (RepositoryMember repositoryMember = new RepositoryMember())
                {
                    Member member = repositoryMember.FirstWithExplicitLoad(I => I.Ssn == ssn);
                    if (member != null)
                    {
                        if (member.Name == BLLHelper.TrimName(name) && member.Surname == BLLHelper.TrimSurname(surname) && member.Phone == tempPhone && member.Mail == tempMail && member.Birthday.ToString("dd.MM.yyyy") == birthday.ToString("dd.MM.yyyy"))
                        {
                            if (newPassword == newPasswordRepeat)
                            {
                                member.Password = PasswordCrypto.EncryptToSha512(newPassword);
                                repositoryMember.CUDOperation(member, EntityState.Modified);
                                return repositoryMember.SaveChanges();
                            }
                            else return -4;
                        }
                        else return -6;
                    }
                    else return -5;
                }
            }
            else return -1;
        }

        public int MemberInfoUpdate(Member member, string name, string surname, MemberEnumGender memberGender, DateTime birthday, decimal height, decimal weight, bool? smoke, string phone, string mail, string city, string county)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name) && !string.IsNullOrEmpty(surname) && !string.IsNullOrWhiteSpace(surname) && member != null)
            {
                int? tempHeight;
                double? tempWeight;
                string tempPhone;
                string tempMail;
                string tempCity;
                string tempCounty;
                if (height == 0) tempHeight = null;
                else tempHeight = (int)height;
                if (weight == 0) tempWeight = null;
                else tempWeight = (double)weight;
                if (string.IsNullOrEmpty(phone.Trim())) tempPhone = null;
                else tempPhone = phone;
                if (string.IsNullOrEmpty(mail.Trim())) tempMail = null;
                else tempMail = mail;
                if (string.IsNullOrEmpty(city.Trim())) tempCity = null;
                else tempCity = city;
                if (string.IsNullOrEmpty(county.Trim())) tempCounty = null;
                else tempCounty = county;
                using (RepositoryMember repositoryMember = new RepositoryMember())
                {
                    if (!repositoryMember.AnyWithExplicitLoad(I => I.Id != member.Id && I.Phone == phone))
                    {
                        if (!repositoryMember.AnyWithExplicitLoad(I => I.Id != member.Id && I.Mail == mail))
                        {
                            member.Name = name;
                            member.Surname = surname;
                            member.Gender = memberGender;
                            member.Birthday = birthday;
                            member.Height = tempHeight;
                            member.Weight = tempWeight;
                            member.DoesSmoke = smoke;
                            member.Phone = tempPhone;
                            member.Mail = tempMail;
                            member.City = tempCity;
                            member.County = tempCounty;
                            member.UpdateTime = DateTime.Now;
                            repositoryMember.CUDOperation(member, EntityState.Modified);
                            return repositoryMember.SaveChanges();
                        }
                        else return -102;
                    }
                    else return -101;
                }
            }
            else return -1;
        }

        public int ChangePassword(Member member, string oldPassword, string newPassword, string newPasswordRepeat)
        {
            if (!string.IsNullOrEmpty(oldPassword) && !string.IsNullOrWhiteSpace(oldPassword) && !string.IsNullOrEmpty(newPassword) && !string.IsNullOrWhiteSpace(newPassword) && !string.IsNullOrEmpty(newPasswordRepeat) && !string.IsNullOrWhiteSpace(newPasswordRepeat) && member != null)
            {
                if (member.Password == PasswordCrypto.EncryptToSha512(oldPassword))
                {
                    if (newPassword == newPasswordRepeat)
                    {
                        using (RepositoryMember repositoryMember = new RepositoryMember())
                        {
                            member.Password = PasswordCrypto.EncryptToSha512(newPassword);
                            repositoryMember.CUDOperation(member, EntityState.Modified);
                            return repositoryMember.SaveChanges();
                        }
                    }
                    else return -4;
                }
                else return -3;
            }
            else return -1;
        }

        public List<City> GetHospitalCities()
        {
            using (RepositoryCity repositoryCity = new RepositoryCity())
            {
                List<Hospital> hospitals = new List<Hospital>();
                using (RepositoryHospital repositoryHospital = new RepositoryHospital())
                {
                    hospitals = repositoryHospital.WhereWithExplicitLoad(I => I.IsActive == true).ToList();
                }

                List<City> cities = new List<City>();
                foreach (var item in hospitals)
                {
                    cities.AddRange(repositoryCity.WhereWithExplicitLoad(I => I.Name == item.City, I => I.OrderBy(J => J.Name)).ToList());
                }

                return cities.Distinct().ToList();
            }
        }

        public List<Hospital> GetSelectedCityHospitals(City city)
        {
            using (RepositoryHospital repositoryHospital = new RepositoryHospital())
            {
                return repositoryHospital.WhereWithExplicitLoad(I => I.IsActive == true && I.City == city.Name, I => I.OrderBy(J => J.Name), paths: new string[] { "Doctors", "Appointments" }).ToList();
            }
        }

        public List<DoctorEnumExpertise> GetSelectedHospitalExpertises(Hospital hospital, Member member)
        {
            using (RepositoryAppointment repositoryAppointment = new RepositoryAppointment())
            {
                List<Appointment> appointments = new List<Appointment>();
                appointments = repositoryAppointment.WhereWithExplicitLoad(I => I.MemberId == member.Id && I.State == AppointmentEnumState.Future, paths: new string[] { "Doctor" }).ToList();

                List<DoctorEnumExpertise> existingExpertise = new List<DoctorEnumExpertise>();
                foreach (var item in appointments)
                {
                    existingExpertise.Add(item.Doctor.Expertise);
                }


                List<DoctorEnumExpertise> expertises = new List<DoctorEnumExpertise>();
                foreach (var item in hospital.Doctors)
                {
                    expertises.Add(item.Expertise);
                }
                List<DoctorEnumExpertise> expertisesFinal = new List<DoctorEnumExpertise>();
                foreach (var item in expertises)
                {
                    expertisesFinal.Add(item);
                }
                foreach (var item in existingExpertise)
                {
                    foreach (var exp in expertises)
                    {
                        if (expertises.Contains(item))
                        {
                            expertisesFinal.Remove(item);
                        }
                    }
                }
                return expertisesFinal.Distinct().ToList();
            }
        }

        public List<Doctor> GetSelectedHospitalExpertiseDoctors(Hospital hospital, DoctorEnumExpertise expertise, Member member)
        {
            DoctorEnumAgeRange ageRange = BLLHelper.GetAgeRange(member);
            List<Doctor> doctors = hospital.Doctors.Where(I => I.AgeRange == ageRange && I.Expertise == expertise).ToList();
            foreach (var item in doctors)
            {
                item.Age = (DateTime.Now.Year - item.Birthday.Year);
            }
            return doctors;
        }

        public int SetNewAppointment(DateTime dateTime, Member member, Doctor doctor, Hospital hospital)
        {
            using (RepositoryAppointment repositoryAppointment = new RepositoryAppointment())
            {
                if (!repositoryAppointment.AnyWithExplicitLoad(I => I.Time == dateTime && I.DoctorId == doctor.Id && I.HospitalId == hospital.Id))
                {
                    repositoryAppointment.CUDOperation(new Appointment()
                    {
                        Id = Guid.NewGuid(),
                        Time = dateTime,
                        MemberId = member.Id,
                        DoctorId = doctor.Id,
                        HospitalId = hospital.Id
                    }, EntityState.Added);
                    return repositoryAppointment.SaveChanges();
                }
                else
                {
                    return -2;
                }
            }
        }

        public List<string> GetSelectableAppointmentTime(DateTime date, Doctor doctor)
        {
            List<Appointment> appointments = new List<Appointment>();
            List<string> times = new List<string>();

            using (RepositoryAppointment repositoryAppointment = new RepositoryAppointment())
            {
                appointments = repositoryAppointment.WhereWithExplicitLoad(I => I.DoctorId == doctor.Id && I.State == AppointmentEnumState.Future, paths: new string[] { "Doctor" }).ToList();
            }

            foreach (var item in appointments)
            {
                if (item.Time.ToString("dd.MM.yyyy") == date.ToString("dd.MM.yyyy"))
                {
                    times.Add(item.Time.ToString("HH:mm"));
                }
            }
            return times.Distinct().ToList();
        }

        public List<Appointment> GetFutureAppointments(Member member)
        {
            using (RepositoryAppointment repositoryAppointment = new RepositoryAppointment())
            {
                List<Appointment> appointments = new List<Appointment>();
                appointments = repositoryAppointment.WhereWithExplicitLoad(I => I.MemberId == member.Id && I.State == AppointmentEnumState.Future, paths: new string[] { "Doctor", "Member", "Hospital" }).ToList();
                return appointments;
            }
        }

        public List<Appointment> GetHistoryAppointments(Member member)
        {
            using (RepositoryAppointment repositoryAppointment = new RepositoryAppointment())
            {
                List<Appointment> appointments = new List<Appointment>();
                appointments = repositoryAppointment.WhereWithExplicitLoad(I => I.MemberId == member.Id && I.State != AppointmentEnumState.Future, paths: new string[] { "Doctor", "Member", "Hospital", "Medicines" }).ToList();
                foreach (var item in appointments)
                {
                    item.Doctor.Age = (DateTime.Now.Year - item.Doctor.Birthday.Year);
                }
                return appointments;
            }
        }

        public int CancelAppointment(Appointment appointment)
        {
            using (RepositoryAppointment repositoryAppointment = new RepositoryAppointment())
            {
                appointment.State = AppointmentEnumState.Cancel;
                repositoryAppointment.CUDOperation(appointment, EntityState.Modified);
                return repositoryAppointment.SaveChanges();
            }
        }

        public int MemberInfoUpdate(Member member, string picture)
        {
            using (RepositoryMember repositoryMember = new RepositoryMember())
            {
                Image image = Image.FromFile(picture);
                MemoryStream mem = new MemoryStream();
                image.Save(mem, ImageFormat.Png);
                member.Picture = mem.ToArray();
                repositoryMember.CUDOperation(member, EntityState.Modified);
                return repositoryMember.SaveChanges();
            }
        }
    }
}
