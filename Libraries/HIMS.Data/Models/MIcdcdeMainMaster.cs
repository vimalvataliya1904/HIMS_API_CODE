﻿using System;
using System.Collections.Generic;

namespace HIMS.Data.Models
{
    public partial class MIcdcdeMainMaster
    {
        public long IcdcdeMid { get; set; }
        public string? IcdcodeName { get; set; }
        public bool? IsDeleted { get; set; }
        public long? AddedBy { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
