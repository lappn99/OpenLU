using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class LevelProgressionLookup
    {
        public long? Id { get; set; }
        public long? RequiredUscore { get; set; }
        public string BehaviorEffect { get; set; }
    }
}
