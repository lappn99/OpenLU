using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class AicombatRoles
    {
        public long? Id { get; set; }
        public long? PreferredRole { get; set; }
        public double? SpecifiedMinRangeNouse { get; set; }
        public double? SpecifiedMaxRangeNouse { get; set; }
        public double? SpecificMinRange { get; set; }
        public double? SpecificMaxRange { get; set; }
    }
}
