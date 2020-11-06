using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class FeatureGating
    {
        public string FeatureName { get; set; }
        public long? Major { get; set; }
        public long? Current { get; set; }
        public long? Minor { get; set; }
        public string Description { get; set; }
    }
}
