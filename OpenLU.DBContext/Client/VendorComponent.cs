using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class VendorComponent
    {
        public long? Id { get; set; }
        public double? BuyScalar { get; set; }
        public double? SellScalar { get; set; }
        public double? RefreshTimeSeconds { get; set; }
        public long? LootMatrixIndex { get; set; }
    }
}
