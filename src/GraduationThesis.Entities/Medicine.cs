using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Entities
{
    public class Medicine
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public MedicineEnumType Type { get; set; }
        public string Description { get; set; }
        public bool? Ssi { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime? UpdateTime { get; set; }
        public DateTime? DeleteTime { get; set; }
        public bool IsActive { get; set; } = true;

        public ICollection<Appointment> Appointments { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Type}";
        }
    }
}
