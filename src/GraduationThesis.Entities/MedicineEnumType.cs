using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Entities
{
    public enum MedicineEnumType
    {
        [Description("Tablet")]
        Tablet = 0,
        [Description("Kapsül")]
        Kapsul = 1,
        [Description("Flakon")]
        Flakon = 2,
        [Description("Ampül")]
        Ampul = 3,
        [Description("Krem")]
        Krem = 4,
        [Description("Merhem")]
        Merhem = 5,
        [Description("Şampuan")]
        Sampuan = 6,
        [Description("Şurup")]
        Surup = 7,
        [Description("Fitil")]
        Fitil = 8,
        [Description("Losyon")]
        Losyon = 9,
        [Description("Damla")]
        Damla = 10,
        [Description("Sprey")]
        Sprey = 11
    }
}
