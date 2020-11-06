using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class ObjectSkills
    {
        public long? ObjectTemplate { get; set; }
        public long? SkillId { get; set; }
        public long? CastOnType { get; set; }
        public long? AicombatWeight { get; set; }
    }
}
