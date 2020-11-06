using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class SkillBehavior
    {
        public long? SkillId { get; set; }
        public long? LocStatus { get; set; }
        public long? BehaviorId { get; set; }
        public long? Imaginationcost { get; set; }
        public long? Cooldowngroup { get; set; }
        public double? Cooldown { get; set; }
        public long? InNpcEditor { get; set; }
        public long? SkillIcon { get; set; }
        public string OomSkillId { get; set; }
        public long? OomBehaviorEffectId { get; set; }
        public long? CastTypeDesc { get; set; }
        public long? ImBonusUi { get; set; }
        public long? LifeBonusUi { get; set; }
        public long? ArmorBonusUi { get; set; }
        public long? DamageUi { get; set; }
        public long? HideIcon { get; set; }
        public long? Localize { get; set; }
        public string GateVersion { get; set; }
        public long? CancelType { get; set; }
    }
}
