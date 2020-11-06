using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class MovingPlatforms
    {
        public long? Id { get; set; }
        public long? PlatformIsSimpleMover { get; set; }
        public double? PlatformMoveX { get; set; }
        public double? PlatformMoveY { get; set; }
        public double? PlatformMoveZ { get; set; }
        public double? PlatformMoveTime { get; set; }
        public long? PlatformStartAtEnd { get; set; }
        public string Description { get; set; }
    }
}
