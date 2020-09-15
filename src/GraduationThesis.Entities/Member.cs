using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Entities
{
    public class Member
    {
        public Guid Id { get; set; }
        public string Ssn { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public MemberEnumGender Gender { get; set; } //*
        public DateTime Birthday { get; set; } //date
        public int Age { get; set; }
        public int? Height { get; set; } //*
        public double? Weight { get; set; } //*
        public bool? DoesSmoke { get; set; } //*
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

        public ICollection<Appointment> Appointments { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
