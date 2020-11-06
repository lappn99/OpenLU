using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class RebuildSections
    {
        public long? Id { get; set; }
        public long? RebuildId { get; set; }
        public long? ObjectId { get; set; }
        public double? OffsetX { get; set; }
        public double? OffsetY { get; set; }
        public double? OffsetZ { get; set; }
        public double? FallAngleX { get; set; }
        public double? FallAngleY { get; set; }
        public double? FallAngleZ { get; set; }
        public double? FallHeight { get; set; }
        public string RequiresList { get; set; }
        public long? Size { get; set; }
        public long? BPlaced { get; set; }
    }
}
