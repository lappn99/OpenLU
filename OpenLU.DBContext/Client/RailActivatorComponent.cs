using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class RailActivatorComponent
    {
        public long? Id { get; set; }
        public string StartAnim { get; set; }
        public string LoopAnim { get; set; }
        public string StopAnim { get; set; }
        public string StartSound { get; set; }
        public string LoopSound { get; set; }
        public string StopSound { get; set; }
        public string EffectIds { get; set; }
        public string Preconditions { get; set; }
        public long? PlayerCollision { get; set; }
        public long? CameraLocked { get; set; }
        public string StartEffectId { get; set; }
        public string StopEffectId { get; set; }
        public long? DamageImmune { get; set; }
        public long? NoAggro { get; set; }
        public long? ShowNameBillboard { get; set; }
    }
}
