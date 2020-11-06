using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class ItemSets
    {
        public long? SetId { get; set; }
        public long? LocStatus { get; set; }
        public string ItemIds { get; set; }
        public long? KitType { get; set; }
        public long? KitRank { get; set; }
        public long? KitImage { get; set; }
        public long? SkillSetWith2 { get; set; }
        public long? SkillSetWith3 { get; set; }
        public long? SkillSetWith4 { get; set; }
        public long? SkillSetWith5 { get; set; }
        public long? SkillSetWith6 { get; set; }
        public long? Localize { get; set; }
        public string GateVersion { get; set; }
        public long? KitId { get; set; }
        public double? Priority { get; set; }
    }
}
