using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class SmashableChain
    {
        public long? ChainIndex { get; set; }
        public long? ChainLevel { get; set; }
        public long? LootMatrixId { get; set; }
        public long? RarityTableIndex { get; set; }
        public long? CurrencyIndex { get; set; }
        public long? CurrencyLevel { get; set; }
        public long? SmashCount { get; set; }
        public long? TimeLimit { get; set; }
        public long? ChainStepId { get; set; }
    }
}
