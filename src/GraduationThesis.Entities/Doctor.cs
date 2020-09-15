using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Entities
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public string Ssn { get; set; }
        public DoctorEnumAppellation Appellation { get; set; }
        public DoctorEnumExpertise Expertise { get; set; }
        public DoctorEnumAgeRange AgeRange { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; } //date
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public byte[] Picture { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime? UpdateTime { get; set; }
        public DateTime? DeleteTime { get; set; }
        public bool IsActive { get; set; } = true;
        public Guid HospitalId { get; set; }

        public Hospital Hospital { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname} / {Age}";
        }
    }
}
