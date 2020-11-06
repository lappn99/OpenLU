using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class MapShaders
    {
        public long? Id { get; set; }
        public string Label { get; set; }
        public long? GameValue { get; set; }
        public long? Priority { get; set; }
    }
}
