using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class Rewards
    {
        public long? Id { get; set; }
        public long? LevelId { get; set; }
        public long? MissionId { get; set; }
        public long? RewardType { get; set; }
        public long? Value { get; set; }
        public long? Count { get; set; }
    }
}
