using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class LupexhibitModelData
    {
        public long? Lot { get; set; }
        public double? MinXz { get; set; }
        public double? MaxXz { get; set; }
        public double? MaxY { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
    }
}
