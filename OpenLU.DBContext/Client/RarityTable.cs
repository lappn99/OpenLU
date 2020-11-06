using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class RarityTable
    {
        public long? Id { get; set; }
        public double? Randmax { get; set; }
        public long? Rarity { get; set; }
        public long? RarityTableIndex { get; set; }
    }
}
