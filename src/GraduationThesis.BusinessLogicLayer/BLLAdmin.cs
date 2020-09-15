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
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.BusinessLogicLayer
{
    public class BLLAdmin
    {
        public Admin AdminLogIn(string userName, string password)
        {
            using (RepositoryAdmin repositoryAdmin = new RepositoryAdmin())
            {
                string encryptedPassword = PasswordCrypto.EncryptToSha512(password);
                return repositoryAdmin.FirstWithExplicitLoad(I => I.UserName == userName && I.Password == encryptedPassword);
            }
        }

        public List<Hospital> GetActiveHospitals()
        {
            using (RepositoryHospital repositoryHospital = new RepositoryHospital())
            {
                return repositoryHospital.WhereWithExplicitLoad(I => I.IsActive == true).ToList();
            }
        }

        public int HospitalNewRecord(string name, decimal numberOfBed, string phoneI, string phoneII, string phoneIII, string mail, string website, string city, string county, string address)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name) && !string.IsNullOrEmpty(city) && !string.IsNullOrWhiteSpace(city) && !string.IsNullOrEmpty(county) && !string.IsNullOrWhiteSpace(county))
            {
                string tempPhoneI;
                string tempPhoneII;
                string tempPhoneIII;
                string tempMail;
                string tempWebsite;
                string tempAddress;
                if (string.IsNullOrEmpty(phoneI.Trim())) tempPhoneI = null;
                else tempPhoneI = phoneI;
                if (string.IsNullOrEmpty(phoneII.Trim())) tempPhoneII = null;
                else tempPhoneII = phoneII;
                if (string.IsNullOrEmpty(phoneIII.Trim())) tempPhoneIII = null;
                else tempPhoneIII = phoneIII;
                if (string.IsNullOrEmpty(mail.Trim())) tempMail = null;
                else tempMail = mail;
                if (string.IsNullOrEmpty(website.Trim())) tempWebsite = null;
                else tempWebsite = website;
                if (string.IsNullOrEmpty(address.Trim())) tempAddress = null;
                else tempAddress = address;
                using (RepositoryHospital repositoryHospital = new RepositoryHospital())
                {
                    if (!repositoryHospital.AnyWithExplicitLoad(I => I.Name == name))
                    {
                        if (!repositoryHospital.AnyWithExplicitLoad(I => I.PhoneI == phoneI))
                        {
                            if (!repositoryHospital.AnyWithExplicitLoad(I => I.PhoneII == phoneII))
                            {
                                if (!repositoryHospital.AnyWithExplicitLoad(I => I.PhoneIII == phoneIII))
                                {
                                    if (!repositoryHospital.AnyWithExplicitLoad(I => I.Mail == mail))
                                    {
                                        if (!repositoryHospital.AnyWithExplicitLoad(I => I.Address == address))
                                        {
                                            Hospital hospital = new Hospital()
                                            {
                                                Id = Guid.NewGuid(),
                                                Name = name,
                                                NumberOfBed = (int)numberOfBed,
                                                PhoneI = tempPhoneI,
                                                PhoneII = tempPhoneII,
                                                PhoneIII = tempPhoneIII,
                                                Mail = tempMail,
                                                Website = tempWebsite,
                                                City = city,
                                                County = county,
                                                Address = tempAddress,
                                                Picture = BLLHelper.DefaultHospitalPic()
                                            };
                                            repositoryHospital.CUDOperation(hospital, EntityState.Added);
                                            return repositoryHospital.SaveChanges();
                                        }
                                        else return -109;
                                    }
                                    else return -108;
                                }
                                else return -107;
                            }
                            else return -106;
                        }
                        else return -105;
                    }
                    else return -104;
                }
            }
            else return -1;
        }

        public int HospitalUpdateRecord(Hospital hospital, string picture)
        {
            using (RepositoryHospital repositoryHospital = new RepositoryHospital())
            {
                Image image = Image.FromFile(picture);
                MemoryStream mem = new MemoryStream();
                image.Save(mem, ImageFormat.Png);
                hospital.Picture = mem.ToArray();
                repositoryHospital.CUDOperation(hospital, EntityState.Modified);
                return repositoryHospital.SaveChanges();
            }
        }

        public int HospitalUpdateRecord(Hospital hospital, string name, decimal numberOfBed, string phoneI, string phoneII, string phoneIII, string mail, string website, string city, string county, string address)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name) && !string.IsNullOrEmpty(city) && !string.IsNullOrWhiteSpace(city) && !string.IsNullOrEmpty(county) && !string.IsNullOrWhiteSpace(county) && hospital != null)
            {
                string tempPhoneI;
                string tempPhoneII;
                string tempPhoneIII;
                string tempMail;
                string tempWebsite;
                string tempAddress;
                if (string.IsNullOrEmpty(phoneI.Trim())) tempPhoneI = null;
                else tempPhoneI = phoneI;
                if (string.IsNullOrEmpty(phoneII.Trim())) tempPhoneII = null;
                else tempPhoneII = phoneII;
                if (string.IsNullOrEmpty(phoneIII.Trim())) tempPhoneIII = null;
                else tempPhoneIII = phoneIII;
                if (string.IsNullOrEmpty(mail.Trim())) tempMail = null;
                else tempMail = mail;
                if (string.IsNullOrEmpty(website.Trim())) tempWebsite = null;
                else tempWebsite = website;
                if (string.IsNullOrEmpty(address.Trim())) tempAddress = null;
                else tempAddress = address;
                using (RepositoryHospital repositoryHospital = new RepositoryHospital())
                {
                    if (!repositoryHospital.AnyWithExplicitLoad(I => I.Id != hospital.Id && I.Name == name))
                    {
                        if (!repositoryHospital.AnyWithExplicitLoad(I => I.Id != hospital.Id && I.PhoneI == phoneI))
                        {
                            if (!repositoryHospital.AnyWithExplicitLoad(I => I.Id != hospital.Id && I.PhoneII == phoneII))
                            {
                                if (!repositoryHospital.AnyWithExplicitLoad(I => I.Id != hospital.Id && I.PhoneIII == phoneIII))
                                {
                                    if (!repositoryHospital.AnyWithExplicitLoad(I => I.Id != hospital.Id && I.Mail == mail))
                                    {
                                        if (!repositoryHospital.AnyWithExplicitLoad(I => I.Id != hospital.Id && I.Address == address))
                                        {
                                            hospital.Name = name;
                                            hospital.NumberOfBed = (int)numberOfBed;
                                            hospital.PhoneI = tempPhoneI;
                                            hospital.PhoneII = tempPhoneII;
                                            hospital.PhoneIII = tempPhoneIII;
                                            hospital.Mail = tempMail;
                                            hospital.Website = tempWebsite;
                                            hospital.City = city;
                                            hospital.County = county;
                                            hospital.Address = tempAddress;
                                            hospital.UpdateTime = DateTime.Now;
                                            repositoryHospital.CUDOperation(hospital, EntityState.Modified);
                                            return repositoryHospital.SaveChanges();
                                        }
                                        else return -109;
                                    }
                                    else return -108;
                                }
                                else return -107;
                            }
                            else return -106;
                        }
                        else return -105;
                    }
                    else return -104;
                }
            }
            else return -1;
        }

        public int HospitalDeleteRecord(Hospital hospital)
        {
            if (hospital != null)
            {
                using (RepositoryHospital repositoryHospital = new RepositoryHospital())
                {
                    hospital.DeleteTime = DateTime.Now;
                    hospital.IsActive = false;
                    repositoryHospital.CUDOperation(hospital, EntityState.Modified);
                    return repositoryHospital.SaveChanges();
                }
            }
            else return -1;
        }

        public List<Doctor> GetActiveDoctors()
        {
            using (RepositoryDoctor repositoryDoctor = new RepositoryDoctor())
            {
                List<Doctor> doctors = repositoryDoctor.WhereWithExplicitLoad(I => I.IsActive == true, paths: new string[] { "Hospital" }).ToList();
                foreach (var item in doctors)
                {
                    item.Age = (DateTime.Now.Year - item.Birthday.Year);
                }
                return doctors;
            }
        }

        public int DoctorNewRecord(Hospital hospital, string ssn, string appellation, string expertise, string ageRange, string name, string surname, DateTime birthday, string phone, string mail, string city, string county)
        {
            if (!string.IsNullOrEmpty(ssn) && !string.IsNullOrWhiteSpace(ssn) && ssn.Length == 11 && !string.IsNullOrEmpty(appellation) && !string.IsNullOrWhiteSpace(appellation) && !string.IsNullOrEmpty(expertise) && !string.IsNullOrWhiteSpace(expertise) && !string.IsNullOrEmpty(ageRange) && !string.IsNullOrWhiteSpace(ageRange) && !string.IsNullOrEmpty(surname) && !string.IsNullOrWhiteSpace(surname) && !string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name) && birthday != null && hospital != null)
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
                    if (!repositoryDoctor.AnyWithExplicitLoad(I => I.Ssn == ssn))
                    {
                        if (!repositoryDoctor.AnyWithExplicitLoad(I => I.Phone == phone))
                        {
                            if (!repositoryDoctor.AnyWithExplicitLoad(I => I.Mail == mail))
                            {
                                Doctor doctor = new Doctor()
                                {
                                    Id = Guid.NewGuid(),
                                    Ssn = ssn,
                                    Appellation = BLLHelper.GetEnumValueFromDescription<DoctorEnumAppellation>(appellation),
                                    Expertise = BLLHelper.GetEnumValueFromDescription<DoctorEnumExpertise>(expertise),
                                    AgeRange = BLLHelper.GetEnumValueFromDescription<DoctorEnumAgeRange>(ageRange),
                                    Name = BLLHelper.TrimName(name),
                                    Surname = BLLHelper.TrimSurname(surname),
                                    Birthday = birthday,
                                    Phone = tempPhone,
                                    Mail = tempMail,
                                    City = tempCity,
                                    County = tempCounty,
                                    Picture = BLLHelper.DefaultDoctorPic(),
                                    Password = PasswordCrypto.EncryptToSha512(ssn),
                                    UpdateTime = DateTime.Now,
                                    HospitalId = hospital.Id
                                };
                                repositoryDoctor.CUDOperation(doctor, EntityState.Added);
                                return repositoryDoctor.SaveChanges();
                            }
                            else return -112;
                        }
                        else return -111;
                    }
                    else return -110;
                }
            }
            else return -1;
        }

        public int DoctorUpdateRecord(Doctor doctor, string picture)
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

        public int DoctorUpdateRecord(Doctor doctor, Hospital hospital, string ssn, string appellation, string expertise, string ageRange, string name, string surname, DateTime birthday, string phone, string mail, string city, string county)
        {
            if (!string.IsNullOrEmpty(ssn) && !string.IsNullOrWhiteSpace(ssn) && ssn.Length == 11 && !string.IsNullOrEmpty(appellation) && !string.IsNullOrWhiteSpace(appellation) && !string.IsNullOrEmpty(expertise) && !string.IsNullOrWhiteSpace(expertise) && !string.IsNullOrEmpty(ageRange) && !string.IsNullOrWhiteSpace(ageRange) && !string.IsNullOrEmpty(surname) && !string.IsNullOrWhiteSpace(surname) && !string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name) && birthday != null && doctor != null && hospital != null)
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
                    if (!repositoryDoctor.AnyWithExplicitLoad(I => I.Id != doctor.Id && I.Ssn == ssn))
                    {
                        if (!repositoryDoctor.AnyWithExplicitLoad(I => I.Id != doctor.Id && I.Phone == phone))
                        {
                            if (!repositoryDoctor.AnyWithExplicitLoad(I => I.Id != doctor.Id && I.Mail == mail))
                            {
                                doctor.Ssn = ssn;
                                doctor.Appellation = BLLHelper.GetEnumValueFromDescription<DoctorEnumAppellation>(appellation);
                                doctor.Expertise = BLLHelper.GetEnumValueFromDescription<DoctorEnumExpertise>(expertise);
                                doctor.AgeRange = BLLHelper.GetEnumValueFromDescription<DoctorEnumAgeRange>(ageRange);
                                doctor.Name = BLLHelper.TrimName(name);
                                doctor.Surname = BLLHelper.TrimSurname(surname);
                                doctor.Birthday = birthday;
                                doctor.Phone = tempPhone;
                                doctor.Mail = tempMail;
                                doctor.City = tempCity;
                                doctor.County = tempCounty;
                                doctor.UpdateTime = DateTime.Now;
                                doctor.HospitalId = hospital.Id;
                                repositoryDoctor.CUDOperation(doctor, EntityState.Modified);
                                return repositoryDoctor.SaveChanges();
                            }
                            else return -112;
                        }
                        else return -111;
                    }
                    else return -110;
                }
            }
            else return -1;
        }

        public int DoctorDeleteRecord(Doctor doctor)
        {
            if (doctor != null)
            {
                using (RepositoryDoctor repositoryDoctor = new RepositoryDoctor())
                {
                    doctor.DeleteTime = DateTime.Now;
                    doctor.IsActive = false;
                    repositoryDoctor.CUDOperation(doctor, EntityState.Modified);
                    return repositoryDoctor.SaveChanges();
                }
            }
            else return -1;
        }

        public List<Medicine> GetActiveMedicines()
        {
            using (RepositoryMedicine repositoryMedicine = new RepositoryMedicine())
            {
                List<Medicine> medicines = repositoryMedicine.WhereWithExplicitLoad(I => I.IsActive == true).ToList();
                return medicines;
            }
        }

        public int MedicineNewRecord(string name, string type, bool? ssi, string description)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name) && !string.IsNullOrEmpty(type) && !string.IsNullOrWhiteSpace(type))
            {
                string tempDescription;
                if (string.IsNullOrEmpty(description.Trim())) tempDescription = null;
                else tempDescription = description;
                using (RepositoryMedicine repositoryMedicine = new RepositoryMedicine())
                {
                    if (!repositoryMedicine.AnyWithExplicitLoad(I => I.Name == name))
                    {
                        Medicine medicine = new Medicine()
                        {
                            Id = Guid.NewGuid(),
                            Name = name,
                            Type = BLLHelper.GetEnumValueFromDescription<MedicineEnumType>(type),
                            Description = tempDescription,
                            Ssi = ssi
                        };
                        repositoryMedicine.CUDOperation(medicine, EntityState.Added);
                        return repositoryMedicine.SaveChanges();
                    }
                    else return -103;
                }
            }
            else return -1;
        }

        public int MedicineUpdateRecord(Medicine medicine, string name, string type, bool? ssi, string description)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name) && !string.IsNullOrEmpty(type) && !string.IsNullOrWhiteSpace(type) && medicine != null)
            {
                string tempDescription;
                if (string.IsNullOrEmpty(description.Trim())) tempDescription = null;
                else tempDescription = description;
                using (RepositoryMedicine repositoryMedicine = new RepositoryMedicine())
                {
                    if (!repositoryMedicine.AnyWithExplicitLoad(I => I.Id != medicine.Id && I.Name == name))
                    {
                        medicine.Name = name;
                        medicine.Type = BLLHelper.GetEnumValueFromDescription<MedicineEnumType>(type);
                        medicine.Ssi = ssi;
                        medicine.Description = tempDescription;
                        medicine.UpdateTime = DateTime.Now;
                        repositoryMedicine.CUDOperation(medicine, EntityState.Modified);
                        return repositoryMedicine.SaveChanges();
                    }
                    return -103;
                }
            }
            else return -1;
        }

        public int MedicineDeleteRecord(Medicine medicine)
        {
            if (medicine != null)
            {
                using (RepositoryMedicine repositoryMedicine = new RepositoryMedicine())
                {
                    medicine.DeleteTime = DateTime.Now;
                    medicine.IsActive = false;
                    repositoryMedicine.CUDOperation(medicine, EntityState.Modified);
                    return repositoryMedicine.SaveChanges();
                }
            }
            else return -1;
        }

        public int GetLastAdminNumber()
        {
            using (RepositoryAdmin repositoryAdmin = new RepositoryAdmin())
            {
                List<Admin> admins = repositoryAdmin.GetAllWithExplicitLoad().ToList();
                List<int> userNames = new List<int>();
                foreach (var item in admins)
                {
                    userNames.Add(Convert.ToInt32(item.UserName));
                }
                return userNames.Max();
            }
        }

        public int AdminNewRecord(string userName)
        {
            using (RepositoryAdmin repositoryAdmin = new RepositoryAdmin())
            {
                repositoryAdmin.CUDOperation(new Admin()
                {
                    Id = Guid.NewGuid(),
                    UserName = userName,
                    Password = PasswordCrypto.EncryptToSha512("demo")
                }, EntityState.Added);
                return repositoryAdmin.SaveChanges();
            }
        }

        public Doctor CheckDoctor(string ssn)
        {
            using (RepositoryDoctor repositoryDoctor = new RepositoryDoctor())
            {
                return repositoryDoctor.FirstWithExplicitLoad(I => I.Ssn == ssn);
            }
        }

        public Member CheckMember(string ssn)
        {
            using (RepositoryMember repositoryMember = new RepositoryMember())
            {
                return repositoryMember.FirstWithExplicitLoad(I => I.Ssn == ssn);
            }
        }
        public Admin CheckAdmin(string userName)
        {
            using (RepositoryAdmin repositoryAdmin = new RepositoryAdmin())
            {
                return repositoryAdmin.FirstWithExplicitLoad(I => I.UserName == userName);
            }
        }

        public int ResetMemberPassword(Member member, string password)
        {
            if (member != null && !string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
            {
                using (RepositoryMember repositoryMember = new RepositoryMember())
                {
                    member.Password = PasswordCrypto.EncryptToSha512(password);
                    repositoryMember.CUDOperation(member, EntityState.Modified);
                    return repositoryMember.SaveChanges();
                }
            }
            else return -1;
        }

        public int ResetDoctorPassword(Doctor doctor, string password)
        {
            if (doctor != null && !string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
            {
                using (RepositoryDoctor repositoryDoctor = new RepositoryDoctor())
                {
                    doctor.Password = PasswordCrypto.EncryptToSha512(password);
                    repositoryDoctor.CUDOperation(doctor, EntityState.Modified);
                    return repositoryDoctor.SaveChanges();
                }
            }
            else return -1;
        }

        public int ResetAdminPassword(Admin admin, string password)
        {
            if (admin != null && !string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
            {
                using (RepositoryAdmin repositoryAdmin = new RepositoryAdmin())
                {
                    admin.Password = PasswordCrypto.EncryptToSha512(password);
                    repositoryAdmin.CUDOperation(admin, EntityState.Modified);
                    return repositoryAdmin.SaveChanges();
                }
            }
            else return -1;
        }

        public List<Hospital> GetDeletedHospital()
        {
            using (RepositoryHospital repositoryHospital = new RepositoryHospital())
            {
                return repositoryHospital.WhereWithExplicitLoad(I => I.IsActive == false).ToList();
            }
        }

        public List<Doctor> GetDeletedDoctor()
        {
            using (RepositoryDoctor repositoryDoctor = new RepositoryDoctor())
            {
                return repositoryDoctor.WhereWithExplicitLoad(I => I.IsActive == false).ToList();
            }
        }

        public List<Member> GetDeletedMember()
        {
            using (RepositoryMember repositoryMember = new RepositoryMember())
            {
                return repositoryMember.WhereWithExplicitLoad(I => I.IsActive == false).ToList();
            }
        }

        public List<Medicine> GetDeletedMedicine()
        {
            using (RepositoryMedicine repositoryMedicine = new RepositoryMedicine())
            {
                return repositoryMedicine.WhereWithExplicitLoad(I => I.IsActive == false).ToList();
            }
        }

        public int ReactivateData<Entity>(Entity entity)
        {
            if (entity is Hospital)
            {
                using (RepositoryHospital repositoryHospital = new RepositoryHospital())
                {
                    (entity as Hospital).IsActive = true;
                    repositoryHospital.CUDOperation(entity as Hospital, EntityState.Modified);
                    return repositoryHospital.SaveChanges();
                }
            }
            else if (entity is Doctor)
            {
                using (RepositoryDoctor repositoryDoctor = new RepositoryDoctor())
                {
                    (entity as Doctor).IsActive = true;
                    repositoryDoctor.CUDOperation(entity as Doctor, EntityState.Modified);
                    return repositoryDoctor.SaveChanges();
                }
            }
            else if (entity is Member)
            {
                using (RepositoryMember repositoryMember = new RepositoryMember())
                {
                    (entity as Member).IsActive = true;
                    repositoryMember.CUDOperation(entity as Member, EntityState.Modified);
                    return repositoryMember.SaveChanges();
                }
            }
            else if (entity is Medicine)
            {
                using (RepositoryMedicine repositoryMedicine = new RepositoryMedicine())
                {
                    (entity as Medicine).IsActive = true;
                    repositoryMedicine.CUDOperation(entity as Medicine, EntityState.Modified);
                    return repositoryMedicine.SaveChanges();
                }
            }
            else return -1;
        }
    }
}
