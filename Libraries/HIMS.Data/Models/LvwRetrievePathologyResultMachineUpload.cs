﻿using System;
using System.Collections.Generic;

namespace HIMS.Data.Models
{
    public partial class LvwRetrievePathologyResultMachineUpload
    {
        public long TestDetId { get; set; }
        public long TestId { get; set; }
        public string? TestName { get; set; }
        public long? SubTestId { get; set; }
        public string? SubTestName { get; set; }
        public long ParameterId { get; set; }
        public string? ParameterName { get; set; }
        public long? ServiceId { get; set; }
        public long? PathparaRangeId { get; set; }
        public string? MinValue { get; set; }
        public string? Maxvalue { get; set; }
        public string? UnitName { get; set; }
        public long? UnitId { get; set; }
        public string? SuggestionNote { get; set; }
        public string DefaultValue { get; set; } = null!;
        public string NormalResult { get; set; } = null!;
        public long? PathTestId { get; set; }
        public long PathReportId { get; set; }
        public long? OpdIpdId { get; set; }
        public long? OpdIpdType { get; set; }
        public bool? IsCompleted { get; set; }
        public string? Description { get; set; }
        public string? Sampleid { get; set; }
        public string Tmpvalue { get; set; } = null!;
        public string? RegNo { get; set; }
        public DateTime? Rundate { get; set; }
        public string Result { get; set; } = null!;
        public string? TestRunDate { get; set; }
        public string Transferflag { get; set; } = null!;
    }
}
