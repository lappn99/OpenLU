using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class LootTable
    {
        public long? Itemid { get; set; }
        public long? LootTableIndex { get; set; }
        public long? Id { get; set; }
        public long? MissionDrop { get; set; }
        public long? SortPriority { get; set; }
    }
}
