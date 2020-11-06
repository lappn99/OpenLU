using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class RacingModuleComponent
    {
        public long? Id { get; set; }
        public double? TopSpeed { get; set; }
        public double? Acceleration { get; set; }
        public double? Handling { get; set; }
        public double? Stability { get; set; }
        public double? Imagination { get; set; }
    }
}
