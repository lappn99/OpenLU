using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class ReputationRewards
    {
        public long? RepLevel { get; set; }
        public long? Sublevel { get; set; }
        public double? Reputation { get; set; }
    }
}
