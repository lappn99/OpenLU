using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class LupexhibitComponent
    {
        public long? Id { get; set; }
        public double? MinXz { get; set; }
        public double? MaxXz { get; set; }
        public double? MaxY { get; set; }
        public double? OffsetX { get; set; }
        public double? OffsetY { get; set; }
        public double? OffsetZ { get; set; }
    }
}
