﻿using System;
using System.Collections.Generic;

namespace HIMS.Data.Models
{
    public partial class IpddiscRefDoctorSmsquery
    {
        public string? Smsstring { get; set; }
        public string? Mobile { get; set; }
        public long DischargeId { get; set; }
    }
}
