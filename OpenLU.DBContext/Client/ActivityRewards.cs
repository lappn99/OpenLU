using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class ActivityRewards
    {
        public long? ObjectTemplate { get; set; }
        public long? ActivityRewardIndex { get; set; }
        public long? ActivityRating { get; set; }
        public long? LootMatrixIndex { get; set; }
        public long? CurrencyIndex { get; set; }
        public long? ChallengeRating { get; set; }
        public string Description { get; set; }
    }
}
