using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Entities
{
    public enum AppointmentEnumState
    {
        [Description("İleri Tarih")]
        Future = 0,
        [Description("Geldi")]
        Attended = 1,
        [Description("Gelmedi")]
        NotAttended = 2,
        [Description("İptal")]
        Cancel = 3
    }
}
