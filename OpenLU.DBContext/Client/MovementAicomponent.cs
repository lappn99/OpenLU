using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class MovementAicomponent
    {
        public long? Id { get; set; }
        public string MovementType { get; set; }
        public double? WanderChance { get; set; }
        public double? WanderDelayMin { get; set; }
        public double? WanderDelayMax { get; set; }
        public double? WanderSpeed { get; set; }
        public double? WanderRadius { get; set; }
        public string AttachedPath { get; set; }
    }
}
