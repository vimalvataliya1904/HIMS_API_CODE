﻿using System;
using System.Collections.Generic;

namespace HIMS.Data.Models
{
    public partial class MSalesTypeMaster
    {
        public long SalesTypeId { get; set; }
        public string? SalesHeadName { get; set; }
        public bool? IsDeleted { get; set; }
        public long? AddedBy { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
