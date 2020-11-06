using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class LootMatrix
    {
        public long? LootMatrixIndex { get; set; }
        public long? LootTableIndex { get; set; }
        public long? RarityTableIndex { get; set; }
        public double? Percent { get; set; }
        public long? MinToDrop { get; set; }
        public long? MaxToDrop { get; set; }
        public long? Id { get; set; }
        public long? FlagId { get; set; }
        public string GateVersion { get; set; }
    }
}
