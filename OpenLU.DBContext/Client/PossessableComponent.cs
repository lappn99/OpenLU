using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class PossessableComponent
    {
        public long? Id { get; set; }
        public long? ControlSchemeId { get; set; }
        public string MinifigAttachPoint { get; set; }
        public string MinifigAttachAnimation { get; set; }
        public string MinifigDetachAnimation { get; set; }
        public string MountAttachAnimation { get; set; }
        public string MountDetachAnimation { get; set; }
        public double? AttachOffsetFwd { get; set; }
        public double? AttachOffsetRight { get; set; }
        public long? PossessionType { get; set; }
        public long? WantBillboard { get; set; }
        public double? BillboardOffsetUp { get; set; }
        public long? DepossessOnHit { get; set; }
        public double? HitStunTime { get; set; }
        public long? SkillSet { get; set; }
    }
}
