using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class Preconditions
    {
        public long? Id { get; set; }
        public long? Type { get; set; }
        public string TargetLot { get; set; }
        public string TargetGroup { get; set; }
        public long? TargetCount { get; set; }
        public long? IconId { get; set; }
        public long? Localize { get; set; }
        public long? ValidContexts { get; set; }
        public long? LocStatus { get; set; }
        public string GateVersion { get; set; }
    }
}
