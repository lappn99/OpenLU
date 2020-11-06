using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class PropertyTemplate
    {
        public long? Id { get; set; }
        public long? MapId { get; set; }
        public long? VendorMapId { get; set; }
        public string SpawnName { get; set; }
        public long? Type { get; set; }
        public long? Sizecode { get; set; }
        public long? MinimumPrice { get; set; }
        public long? RentDuration { get; set; }
        public string Path { get; set; }
        public long? CloneLimit { get; set; }
        public long? DurationType { get; set; }
        public long? AchievementRequired { get; set; }
        public double? ZoneX { get; set; }
        public double? ZoneY { get; set; }
        public double? ZoneZ { get; set; }
        public double? MaxBuildHeight { get; set; }
        public long? Localize { get; set; }
        public long? ReputationPerMinute { get; set; }
        public long? LocStatus { get; set; }
        public string GateVersion { get; set; }
    }
}
