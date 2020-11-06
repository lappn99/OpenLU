using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class MotionFx
    {
        public long? Id { get; set; }
        public long? TypeId { get; set; }
        public double? SlamVelocity { get; set; }
        public double? AddVelocity { get; set; }
        public double? Duration { get; set; }
        public string DestGroupName { get; set; }
        public double? StartScale { get; set; }
        public double? EndScale { get; set; }
        public double? Velocity { get; set; }
        public double? Distance { get; set; }
    }
}
