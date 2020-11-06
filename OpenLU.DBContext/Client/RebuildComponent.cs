using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class RebuildComponent
    {
        public long? Id { get; set; }
        public double? ResetTime { get; set; }
        public double? CompleteTime { get; set; }
        public long? TakeImagination { get; set; }
        public long? Interruptible { get; set; }
        public long? SelfActivator { get; set; }
        public string CustomModules { get; set; }
        public long? ActivityId { get; set; }
        public long? PostImaginationCost { get; set; }
        public double? TimeBeforeSmash { get; set; }
    }
}
