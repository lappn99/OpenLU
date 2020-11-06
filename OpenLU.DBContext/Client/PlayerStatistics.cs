using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class PlayerStatistics
    {
        public long? StatId { get; set; }
        public long? SortOrder { get; set; }
        public long? LocStatus { get; set; }
        public string GateVersion { get; set; }
    }
}
