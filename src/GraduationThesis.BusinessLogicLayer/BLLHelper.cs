using GraduationThesis.DataAccessLayer.Repositories;
using GraduationThesis.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.BusinessLogicLayer
{
    public static class BLLHelper
    {
        public static string TrimName(string name)
        {
            string resultName = string.Empty;
            string trimmedName = name.Trim();
            for (int i = 0; i < trimmedName.Length; i++)
            {
                if (i == 0) { resultName += trimmedName[i].ToString().ToUpper(); i++; }
                if (trimmedName[i] == ' ')
                {
                    resultName += trimmedName[i];
                    resultName += trimmedName[i + 1].ToString().ToUpper();
                    i++;
                }
                else resultName += trimmedName[i].ToString().ToLower();
            }
            return resultName;
        }

        public static string TrimSurname(string surname)
        {
            string resultSurname = string.Empty;
            string trimmedSurname = surname.Trim();
            for (int i = 0; i < trimmedSurname.Length; i++)
            {
                if (i == 0) { resultSurname += trimmedSurname[i].ToString().ToUpper(); i++; }
                if (trimmedSurname[i] == ' ')
                {
                    resultSurname += trimmedSurname[i];
                    resultSurname += trimmedSurname[i + 1].ToString().ToUpper();
                    i++;
                }
                else resultSurname += trimmedSurname[i].ToString().ToLower();
            }
            return resultSurname;
        }

        public static byte[] DefaultUserPic()
        {
            Bitmap bitmap = Properties.Resources.user;
            MemoryStream mem = new MemoryStream();
            bitmap.Save(mem, ImageFormat.Png);
            return mem.ToArray();
        }

        public static byte[] DefaultHospitalPic()
        {
            Bitmap bitmap = Properties.Resources.hospital;
            MemoryStream mem = new MemoryStream();
            bitmap.Save(mem, ImageFormat.Png);
            return mem.ToArray();
        }

        public static byte[] DefaultDoctorPic()
        {
            Bitmap bitmap = Properties.Resources.doctor;
            MemoryStream mem = new MemoryStream();
            bitmap.Save(mem, ImageFormat.Png);
            return mem.ToArray();
        }

        public static List<City> GetCities()
        {
            using (RepositoryCity repositoryCity = new RepositoryCity())
            {
                return repositoryCity.WhereWithExplicitLoad(I => true, I => I.OrderBy(J => J.Name), paths: new string[] { "Counties" }).ToList();
            }
        }

        public static List<County> GetCounties(string city)
        {
            using (RepositoryCounty repositoryCounty = new RepositoryCounty())
            {
                return repositoryCounty.WhereWithExplicitLoad(I => I.City.Name == city, I => I.OrderBy(J => J.Name), paths: new string[] { "City" }).ToList();
            }
        }

        public static string GetEnumDescription(this Enum genericEnum)
        {
            Type genericEnumType = genericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(genericEnum.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var Attributes = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                if ((Attributes != null && Attributes.Count() > 0))
                {
                    return ((System.ComponentModel.DescriptionAttribute)Attributes.ElementAt(0)).Description;
                }
            }
            return genericEnum.ToString();
        }

        public static List<string> GetEnumDescriptions<T>()
        {
            List<string> appellationDesc = new List<string>();
            foreach (var item in Enum.GetValues(typeof(T)))
            {
                appellationDesc.Add(GetEnumDescription((Enum)item));
            }
            return appellationDesc;
        }

        public static T GetEnumValueFromDescription<T>(string description)
        {
            var type = typeof(T);
            if (!type.IsEnum) throw new InvalidOperationException();
            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (attribute != null)
                {
                    if (attribute.Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException("Not found.", nameof(description));
        }

        public static DoctorEnumAgeRange GetAgeRange(Member member)
        {
            DoctorEnumAgeRange ageRange;
            if (member.Age < 18)
            {
                ageRange = DoctorEnumAgeRange._0ve17Arasi;
            }
            else if (member.Age >= 18 && member.Age < 65)
            {
                ageRange = DoctorEnumAgeRange._18ve65Arasi;
            }
            else
            {
                ageRange = DoctorEnumAgeRange._65Ustu;
            }
            return ageRange;
        }
    }
}
