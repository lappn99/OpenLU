using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class ExhibitComponent
    {
        public long? Id { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public double? OffsetX { get; set; }
        public double? OffsetY { get; set; }
        public double? OffsetZ { get; set; }
        public double? FReputationSizeMultiplier { get; set; }
        public double? FImaginationCost { get; set; }
    }
}
