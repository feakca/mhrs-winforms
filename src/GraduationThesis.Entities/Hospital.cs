using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Entities
{
    public class Hospital
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? NumberOfBed { get; set; }
        public string PhoneI { get; set; }
        public string PhoneII { get; set; }
        public string PhoneIII { get; set; }
        public string Mail { get; set; }
        public string Website { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Address { get; set; }
        public byte[] Picture { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime? UpdateTime { get; set; }
        public DateTime? DeleteTime { get; set; }
        public bool IsActive { get; set; } = true;

        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
