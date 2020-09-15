using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Entities
{
    public class Appointment
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public Guid MemberId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid HospitalId { get; set; }
        public string Description { get; set; }
        public AppointmentEnumState State { get; set; } = AppointmentEnumState.Future;
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime? UpdateTime { get; set; }
        public DateTime? DeleteTime { get; set; }
        public bool IsActive { get; set; } = true;

        public Member Member { get; set; }
        public Doctor Doctor { get; set; }
        public Hospital Hospital { get; set; }
        public ICollection<Medicine> Medicines { get; set; }

        public override string ToString()
        {
            return $"{Time.ToString("HH:mm")} - {Member.Name} {Member.Surname}";
        }
    }
}
