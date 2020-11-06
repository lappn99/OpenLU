using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class ModularBuildComponent
    {
        public long? Id { get; set; }
        public long? BuildType { get; set; }
        public string Xml { get; set; }
        public long? CreatedLot { get; set; }
        public long? CreatedPhysicsId { get; set; }
        public string AudioEventGuidSnap { get; set; }
        public string AudioEventGuidComplete { get; set; }
        public string AudioEventGuidPresent { get; set; }
    }
}
