using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class ProximityTypes
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public long? Radius { get; set; }
        public long? CollisionGroup { get; set; }
        public long? PassiveChecks { get; set; }
        public long? IconId { get; set; }
        public long? LoadOnClient { get; set; }
        public long? LoadOnServer { get; set; }
    }
}
