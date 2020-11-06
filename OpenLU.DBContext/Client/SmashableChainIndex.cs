using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class SmashableChainIndex
    {
        public long? Id { get; set; }
        public string TargetGroup { get; set; }
        public string Description { get; set; }
        public long? Continuous { get; set; }
    }
}
