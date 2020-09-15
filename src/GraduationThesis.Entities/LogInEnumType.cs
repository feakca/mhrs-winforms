using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Entities
{
    public enum LogInEnumType
    {
        [Description("Üye")]
        Member = 0,
        [Description("Doktor")]
        Doctor = 1
    }
}
