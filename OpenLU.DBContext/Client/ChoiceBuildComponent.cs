using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class ChoiceBuildComponent
    {
        public long? Id { get; set; }
        public string Selections { get; set; }
        public long? ImaginationOverride { get; set; }
    }
}
