using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class ActivityText
    {
        public long? ActivityId { get; set; }
        public string Type { get; set; }
        public long? Localize { get; set; }
        public long? LocStatus { get; set; }
        public string GateVersion { get; set; }
    }
}
