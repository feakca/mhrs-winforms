using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using GraduationThesis.DataAccessLayer.Contexts;
using GraduationThesis.DataAccessLayer.Repositories;
using GraduationThesis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.BusinessLogicLayer
{
    public class BLLLogIn
    {
        BLLAdmin bllAdmin;
        BLLDoctor bllDoctor;
        BLLMember bllMember;

        public BLLLogIn()
        {
            bllAdmin = new BLLAdmin();
            bllDoctor = new BLLDoctor();
            bllMember = new BLLMember();
        }

        public LogInEnumOption LogInCheck(LogInEnumType logInType, string userName, string password)
        {
            LogInEnumOption logInOption = LogInEnumOption.Empty;
            if (logInType == LogInEnumType.Doctor)
            {
                if (userName.StartsWith("000000000"))
                {
                    if (!string.IsNullOrEmpty(userName) && !string.IsNullOrWhiteSpace(userName) && !string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
                    {
                        Admin admin = bllAdmin.AdminLogIn(userName, password);
                        if (admin != null)
                        {
                            logInOption = LogInEnumOption.Admin;
                        }
                        else
                        {
                            logInOption = LogInEnumOption.Error;
                        }
                    }
                    else
                    {
                        logInOption = LogInEnumOption.Empty;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(userName) && !string.IsNullOrWhiteSpace(userName) && !string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
                    {
                        Doctor doctor = bllDoctor.DoctorLogIn(userName, password);
                        if (doctor != null)
                        {
                            logInOption = LogInEnumOption.Doctor;
                        }
                        else
                        {
                            logInOption = LogInEnumOption.Error;
                        }
                    }
                    else
                    {
                        logInOption = LogInEnumOption.Empty;
                    }
                }
            }
            else if (logInType == LogInEnumType.Member)
            {
                if (!string.IsNullOrEmpty(userName) && !string.IsNullOrWhiteSpace(userName) && !string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
                {
                    Member member = bllMember.MemberLogIn(userName, password);
                    if (member != null)
                    {
                        logInOption = LogInEnumOption.Member;
                    }
                    else
                    {
                        logInOption = LogInEnumOption.Error;
                    }
                }
                else
                {
                    logInOption = LogInEnumOption.Empty;
                }
            }
            return logInOption;
        }

        public Admin AdminFind(string userName)
        {
            using (RepositoryAdmin repositoryAdmin = new RepositoryAdmin())
            {
                Admin admin = repositoryAdmin.FirstWithExplicitLoad(I => I.UserName == userName);
                return admin;
            }
        }

        public Doctor DoctorFind(string ssn)
        {
            using (RepositoryDoctor repositoryDoctor = new RepositoryDoctor())
            {
                Doctor doctor = repositoryDoctor.FirstWithExplicitLoad(I => I.Ssn == ssn, paths: new string[] { "Hospital", "Appointments", "Appointments.Member", "Appointments.Medicines" });
                doctor.Age = (DateTime.Now.Year - doctor.Birthday.Year);
                foreach (var item in doctor.Appointments)
                {
                    item.Member.Age = (DateTime.Now.Year - item.Member.Birthday.Year);
                }
                return doctor;
            }
        }

        public Member MemberFind(string ssn)
        {
            using (RepositoryMember repositoryMember = new RepositoryMember())
            {
                Member member = repositoryMember.FirstWithExplicitLoad(I => I.Ssn == ssn, paths: new string[] { "Appointments", "Appointments.Doctor", "Appointments.Medicines" });
                member.Age = (DateTime.Now.Year - member.Birthday.Year);
                foreach (var item in member.Appointments)
                {
                    item.Doctor.Age = (DateTime.Now.Year - item.Doctor.Birthday.Year);
                }
                return member;
            }
        }
    }
}
