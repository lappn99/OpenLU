using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class SubscriptionPricing
    {
        public long? Id { get; set; }
        public string CountryCode { get; set; }
        public string MonthlyFeeGold { get; set; }
        public string MonthlyFeeSilver { get; set; }
        public string MonthlyFeeBronze { get; set; }
        public long? MonetarySymbol { get; set; }
        public long? SymbolIsAppended { get; set; }
    }
}
