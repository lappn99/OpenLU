using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class MissionTasks
    {
        public long? Id { get; set; }
        public long? LocStatus { get; set; }
        public long? TaskType { get; set; }
        public long? Target { get; set; }
        public string TargetGroup { get; set; }
        public long? TargetValue { get; set; }
        public string TaskParam1 { get; set; }
        public string LargeTaskIcon { get; set; }
        public long? IconId { get; set; }
        public long? Uid { get; set; }
        public long? LargeTaskIconId { get; set; }
        public long? Localize { get; set; }
        public string GateVersion { get; set; }
    }
}
