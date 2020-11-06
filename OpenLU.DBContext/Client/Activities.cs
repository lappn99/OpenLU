using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class Activities
    {
        public long? ActivityId { get; set; }
        public long? LocStatus { get; set; }
        public long? InstanceMapId { get; set; }
        public long? MinTeams { get; set; }
        public long? MaxTeams { get; set; }
        public long? MinTeamSize { get; set; }
        public long? MaxTeamSize { get; set; }
        public long? WaitTime { get; set; }
        public long? StartDelay { get; set; }
        public long? RequiresUniqueData { get; set; }
        public long? LeaderboardType { get; set; }
        public long? Localize { get; set; }
        public long? OptionalCostLot { get; set; }
        public long? OptionalCostCount { get; set; }
        public long? ShowUirewards { get; set; }
        public long? CommunityActivityFlagId { get; set; }
        public string GateVersion { get; set; }
        public long? NoTeamLootOnDeath { get; set; }
        public double? OptionalPercentage { get; set; }
    }
}
