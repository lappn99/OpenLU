using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class BaseCombatAicomponent
    {
        public long? Id { get; set; }
        public long? BehaviorType { get; set; }
        public double? CombatRoundLength { get; set; }
        public long? CombatRole { get; set; }
        public double? MinRoundLength { get; set; }
        public double? MaxRoundLength { get; set; }
        public double? TetherSpeed { get; set; }
        public double? PursuitSpeed { get; set; }
        public double? CombatStartDelay { get; set; }
        public double? SoftTetherRadius { get; set; }
        public double? HardTetherRadius { get; set; }
        public double? SpawnTimer { get; set; }
        public long? TetherEffectId { get; set; }
        public long? IgnoreMediator { get; set; }
        public double? AggroRadius { get; set; }
        public long? IgnoreStatReset { get; set; }
        public long? IgnoreParent { get; set; }
    }
}
