using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Entities
{
    public enum DoctorEnumAppellation
    {
        [Description("Pratisyen Doktor")]
        PratisyenDoktor = 0,
        [Description("Uzman Doktor")]
        UzmanDoktor = 1,
        [Description("Operatör Doktor")]
        OperatorDoktor = 2,
        [Description("Yardımcı Doçent")]
        YardimciDocent = 3,
        [Description("Doçent")]
        Docent = 4,
        [Description("Profesör")]
        Profesor = 5
    }
}
