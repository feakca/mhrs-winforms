﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Entities
{
    public class AppointmentTime
    {
        public Guid Id { get; set; }
        public TimeSpan Time { get; set; }
    }
}
