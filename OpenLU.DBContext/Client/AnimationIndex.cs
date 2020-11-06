using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class AnimationIndex
    {
        public long? AnimationGroupId { get; set; }
        public string Description { get; set; }
        public string GroupType { get; set; }
    }
}
