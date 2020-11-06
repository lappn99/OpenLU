using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class PetComponent
    {
        public long? Id { get; set; }
        public double? MinTameUpdateTime { get; set; }
        public double? MaxTameUpdateTime { get; set; }
        public double? PercentTameChance { get; set; }
        public double? Tamability { get; set; }
        public long? ElementType { get; set; }
        public double? WalkSpeed { get; set; }
        public double? RunSpeed { get; set; }
        public double? SprintSpeed { get; set; }
        public double? IdleTimeMin { get; set; }
        public double? IdleTimeMax { get; set; }
        public long? PetForm { get; set; }
        public double? ImaginationDrainRate { get; set; }
        public string AudioMetaEventSet { get; set; }
        public string BuffIds { get; set; }
    }
}
