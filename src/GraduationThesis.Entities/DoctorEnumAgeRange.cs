using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Entities
{
    public enum DoctorEnumAgeRange
    {
        [Description("18 Yaş Altı")]
        _0ve17Arasi = 0,
        [Description("18 - 65 Yaş Arası")]
        _18ve65Arasi = 1,
        [Description("65 Yaş Üstü")]
        _65Ustu = 2
    }
}
